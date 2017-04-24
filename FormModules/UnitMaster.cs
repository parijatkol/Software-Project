using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace inventory_control
{
    public partial class UnitMaster : DevExpress.XtraEditors.XtraForm
    {
        DataAccessLayer InvUnitDataAccessLayer = new DataAccessLayer();
        clsGlobalValue InvclsGlobalValue = new clsGlobalValue();
        clsUnitMaster InvclsUnitMaster = new clsUnitMaster();
        clsTools InvTools = new clsTools();
        clsValidation InvUnitValidation = new clsValidation();
        ErrorProviderExtended MyErrorProvider = new ErrorProviderExtended();
        int rowHit = 0;

        public UnitMaster()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if ((MyErrorProvider.CheckAndShowSummaryErrorMessage() == true))
            {
                try
                {
                    string msg = "Do You Want To Save?";
                    DialogResult result = MessageBox.Show(this, msg, "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        InvclsUnitMaster.UnitName = InvTools.formatInputString(txtUnitName.Text.Trim());
                        InvclsUnitMaster.Status = true;;
                        InvclsUnitMaster.UserLoginID = InvclsGlobalValue.Login_UserId;
                        InvclsUnitMaster.EntryDate = DateTime.Now;
                        InvclsUnitMaster.Mode = InvTools.formatInputString(txtMode.Text.Trim());

                        int i = InvclsUnitMaster.UpdateData();

                        if (txtMode.Text.Trim() == "Insert")
                            msg = "New Unit Created Successfully.";
                        else
                            msg = "Unit Master Updated Successfully.";


                        if (i > 0)
                        {
                            MessageBox.Show(msg);
                            clearData();
                            Unitgridpopulate(rowHit);
                        }
                        else
                        {
                            if (i == -1)
                            {
                                MessageBox.Show("Sorry!!! Duplicate Unit Name Found.");
                            }
                            else
                            {
                                MessageBox.Show("Error In Saving!!!!!!!!!!!");
                            }
                        }

                        if (result == DialogResult.No)
                        {
                            MessageBox.Show("Error In Saving !!!!!!!!!!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void UnitMaster_Load(object sender, EventArgs e)
        {
            MyErrorProvider.Controls.Add((object)txtUnitName, "Unit Name");
            // Initially make emergency contact field as non mandatory
            MyErrorProvider.SummaryMessage = "Following fields are mandatory,";
            Unitgridpopulate(0);
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            int rowID = 0;

            try
            {
                foreach (int i in gridView2.GetSelectedRows())
                {
                    DataRow row = gridView2.GetDataRow(i);
                    rowID = Convert.ToInt16(row["UnitID"]);
                    rowHit = i;
                }

                if (InvclsUnitMaster.RetrieveData(rowID))
                {
                    txtUnitName.Text = InvclsUnitMaster.UnitName;
                    txtMode.Text = "Update";
                    InvclsUnitMaster.UnitID= rowID;
                    txtUnitName.Focus();
                    txtUnitName.SelectionStart = txtUnitName.Text.Length + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void gridControl1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            int rowID = 0;
            int stat = 0;
            string msg = string.Empty;

            if (e.KeyCode == Keys.Delete)
            {
                DialogResult deleterow = MessageBox.Show(this, "Want To Delete This Unit ?", "Delete Confirmation ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleterow == DialogResult.Yes)
                {
                    foreach (int i in gridView2.GetSelectedRows())
                    {
                        DataRow row = gridView2.GetDataRow(i);
                        rowID = Convert.ToInt16(row["UnitID"]);
                        rowHit = i;
                    }

                    InvclsUnitMaster.UnitID = rowID;
                    InvclsUnitMaster.Mode = "Delete";

                    stat = InvclsUnitMaster.DeleteUnitMaster();

                    if (stat == -1)
                    {
                        msg = "Deletion Error!!! Product Found Against This Unit.";
                        msg += "\n\n";
                        msg += "So First Delete The Product Against This Unit And Then Delete This Unit.";
                        Unitgridpopulate(rowHit);
                    }
                    else
                    {
                        msg = "The Unit Information Is Deleted Successfully.";
                        Unitgridpopulate(0);
                    }
                    MessageBox.Show(msg, "Delete Status", MessageBoxButtons.OK);
                    txtUnitName.Focus();
                }
            }
        }

        private void Unitgridpopulate(int focusrow)
        {
            try
            {
                int totrow = gridView2.RowCount;
                for (int i = 0; i < totrow; )
                {
                    DataRow row = gridView2.GetDataRow(i);
                    row.Delete();
                    totrow = gridView2.RowCount;
                }

                string strSQL = "select UnitID,UnitName from tbl_UnitMaster where Status=1";
                SqlDataAdapter InvDataCustAdapter = new SqlDataAdapter();
                InvDataCustAdapter = InvUnitDataAccessLayer.PopulateData(strSQL);
                InvDataCustAdapter.Fill(dsUnitMaster1.tbl_UnitMaster);
                gridView2.FocusedRowHandle = focusrow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void CmdNew_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void clearData()
        {
            txtUnitName.Text = "";
            txtMode.Text = "Insert";
            txtUnitName.Focus();
        }

        //private void txtUnitName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (InvUnitValidation.IsEmptyValidate(txtUnitName.Text) == false)
        //    {
        //        errorProvider1.SetError(txtUnitName, "Please Provide Unit Name");
        //        cmdSave.Enabled = false;
        //        txtUnitName.Focus();
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtUnitName, "");
        //        cmdSave.Enabled = true;
        //    }
        //}

        private void txtUnitName_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                if (InvUnitValidation.IsEmptyValidate(txtUnitName.Text) == false)
                {
                    errorProvider1.SetError(txtUnitName, "Please Provide Unit Name");
                    cmdSave.Enabled = false;
                    txtUnitName.Focus();
                }
                else
                {
                    errorProvider1.SetError(txtUnitName, "");
                    cmdSave.Enabled = true;
                    cmdSave.Focus();
                }
            }
        }

        private void txtUnitName_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtUnitName, "");
            cmdSave.Enabled = true;
        }

    }
}