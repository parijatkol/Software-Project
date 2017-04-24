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
    public partial class ItemGroupMaster : DevExpress.XtraEditors.XtraForm
    {
        clsGlobalValue InvclsGlobalValue = new clsGlobalValue();
        clsItemGroupMaster InvclsItemGroupMaster = new clsItemGroupMaster();
        DataAccessLayer InvDataItemGroupAccessLayer = new DataAccessLayer();
        clsTools InvTools = new clsTools();
        clsValidation InvItemGroupValidation = new clsValidation();
        ErrorProviderExtended MyErrorProvider = new ErrorProviderExtended();
        int rowHit = 0;


        public ItemGroupMaster()
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
                        InvclsItemGroupMaster.ItemGroupName = InvTools.formatInputString(txtGroupName.Text.Trim());
                        InvclsItemGroupMaster.ItemGroupDesc = InvTools.formatInputString(txtGroupDesc.Text.Trim());
                        InvclsItemGroupMaster.UserLoginID = InvclsGlobalValue.Login_UserId;
                        InvclsItemGroupMaster.EntryDate = DateTime.Now;
                        InvclsItemGroupMaster.Status = true;
                        InvclsItemGroupMaster.Mode = InvTools.formatInputString(txtMode.Text.Trim());

                        int i = InvclsItemGroupMaster.UpdateData();

                        if (txtMode.Text.Trim() == "Insert")
                            msg = "New Group Master Created Successfully.";
                        else
                            msg = "Group Master Updated Successfully.";

                        if (i > 0)
                        {
                            MessageBox.Show(msg);
                            clearData();
                            ItemGroupgridpopulate(rowHit);
                        }
                        else
                        {
                            if (i == -1)
                            {
                                MessageBox.Show("Sorry!!! Duplicate Item GroupName Found.");
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

        private void ItemGroupMaster_Load(object sender, EventArgs e)
        {
            MyErrorProvider.Controls.Add((object)txtGroupName, "Group Name");
            // Initially make emergency contact field as non mandatory
            MyErrorProvider.SummaryMessage = "Following fields are mandatory,";
            ItemGroupgridpopulate(0);
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            int rowID = 0;

            try
            {

                foreach (int i in gridView2.GetSelectedRows())
                {
                    DataRow row = gridView2.GetDataRow(i);
                    rowID = Convert.ToInt16(row["ItemGroupCode"]);
                    rowHit = i;
                }

                if (InvclsItemGroupMaster.RetrieveData(rowID))
                {
                    txtGroupName.Text = InvclsItemGroupMaster.ItemGroupName;
                    txtGroupDesc.Text = InvclsItemGroupMaster.ItemGroupDesc;
                    txtMode.Text = "Update";
                    InvclsItemGroupMaster.ItemGroupCode = rowID;
                    txtGroupName.Focus();
                    txtGroupName.SelectionStart = txtGroupName.Text.Length + 1;
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
                DialogResult deleterow = MessageBox.Show(this, "Want To Delete This ItemGroup ?", "Delete Confirmation ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleterow == DialogResult.Yes)
                {
                    foreach (int i in gridView2.GetSelectedRows())
                    {
                        DataRow row = gridView2.GetDataRow(i);
                        rowID = Convert.ToInt16(row["ItemGroupCode"]);
                        rowHit = i;
                    }

                    InvclsItemGroupMaster.ItemGroupCode = rowID;
                    InvclsItemGroupMaster.Mode = "Delete";

                    stat = InvclsItemGroupMaster.DeleteGroupMaster();

                    if (stat == -1)
                    {
                        msg = "Deletion Error!!! Product Found Against This Group.";
                        msg += "\n\n";
                        msg += "So First Delete The Product Against This ItemGroup And Then Delete This Group.";
                        ItemGroupgridpopulate(rowHit);
                    }
                    else
                    {
                        msg = "The Item Group Information Is Deleted Successfully.";
                        ItemGroupgridpopulate(0);
                    }

                    MessageBox.Show(msg, "Delete Status", MessageBoxButtons.OK);
                    txtGroupName.Focus();
                }
            }
        }

        //private void txtGroupName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{

        //    if (InvItemGroupValidation.IsEmptyValidate(txtGroupName.Text) == false)
        //    {
        //        errorProvider1.SetError(txtGroupName, "Please Provide Group Name");
        //        cmdSave.Enabled = false;
        //        txtGroupName.Focus();
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtGroupName, "");
        //        cmdSave.Enabled = true;
        //    }
        //}

        private void txtGroupDesc_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                cmdSave.Focus();
        }

        private void txtGroupName_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                if (InvItemGroupValidation.IsEmptyValidate(txtGroupName.Text) == false)
                {
                    errorProvider1.SetError(txtGroupName, "Please Provide Group Name");
                    cmdSave.Enabled = false;
                    txtGroupName.Focus();
                }
                else
                {
                    errorProvider1.SetError(txtGroupName, "");
                    cmdSave.Enabled = true;
                    txtGroupDesc.Focus();
                }
            }
        }

        private void txtGroupName_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtGroupName, "");
            cmdSave.Enabled = true;
        }

        private void ItemGroupgridpopulate(int focusrow)
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

                string strSQL = "select ItemGroupCode,ItemGroupName from tbl_ItemGroupMaster where Status=1";
                SqlDataAdapter InvDataItemGrouopAdapter = new SqlDataAdapter();
                InvDataItemGrouopAdapter = InvDataItemGroupAccessLayer.PopulateData(strSQL);
                InvDataItemGrouopAdapter.Fill(dsItemGroup1.tbl_ItemGroupMaster);
                gridView2.FocusedRowHandle = focusrow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void clearData()
        {
            txtGroupName.Text = "";
            txtGroupDesc.Text = "";
            txtGroupName.Focus();
            txtMode.Text = "Insert";

        }



    }
}