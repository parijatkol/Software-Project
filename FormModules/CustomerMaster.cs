using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid.Events;

using DevExpress.XtraGrid.Views.Grid;


namespace inventory_control
{
    public partial class CustomerMaster : DevExpress.XtraEditors.XtraForm
    {        
        clsGlobalValue InvclsGlobal = new clsGlobalValue();
        DataAccessLayer InvclsDataAccessLayer = new DataAccessLayer();
        clsCustomers InvclsCustomer = new clsCustomers();
        clsTools InvTools = new clsTools();
        clsValidation InvCustValidation = new clsValidation();
        ErrorProviderExtended MyErrorProvider = new ErrorProviderExtended();
        int rowHit = 0;

        public CustomerMaster()
        {
            InitializeComponent();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            if ((MyErrorProvider.CheckAndShowSummaryErrorMessage()==true))
            {
                try
                {
                    string msg = "Do You Want To Save?";
                    DialogResult result = MessageBox.Show(this, msg, "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        InvclsCustomer.CustomerName = InvTools.formatInputString(txtCustomerName.Text.Trim());
                        InvclsCustomer.Address1 = InvTools.formatInputString(txtAddress1.Text.Trim());
                        InvclsCustomer.Address2 = InvTools.formatInputString(txtAddress2.Text.Trim());
                        InvclsCustomer.Phone = InvTools.formatInputString(txtPhoneNo.Text.Trim());
                        InvclsCustomer.PANNO = InvTools.formatInputString(txtPANNo.Text.Trim());
                        InvclsCustomer.Status = true;
                        InvclsCustomer.LoginUserID = clsGlobalValue._Login_UserId;
                        InvclsCustomer.EntryDate = DateTime.Now;
                        InvclsCustomer.Mode = InvTools.formatInputString(txtMode.Text.Trim());

                        int i = InvclsCustomer.UpdateData();

                        if (txtMode.Text.Trim() == "Insert")
                            msg = "New Customer Created Successfully.";
                        else
                            msg = "Customer Information Updated Successfully.";

                        if (i > 0)
                        {
                            MessageBox.Show(msg);
                            clearData();
                            Custgridpopulate(rowHit);
                        }
                        else
                        {
                            if (i == -1)
                            {
                                MessageBox.Show("Sorry!!! Duplicate Customer Found.");
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

        public void CustomerMaster_Load(object sender, EventArgs e)
        {
            MyErrorProvider.Controls.Add((object)txtCustomerName, "Customer Name");
            MyErrorProvider.Controls.Add((object)txtAddress1, "Address1");
            MyErrorProvider.Controls.Add((object)txtPhoneNo, "Contact No");
            // Initially make emergency contact field as non mandatory
            MyErrorProvider.SummaryMessage = "Following fields are mandatory,";
            Custgridpopulate(0);
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            int rowID=0;

            try
            {
                foreach (int i in gridView2.GetSelectedRows())
                {
                    DataRow row = gridView2.GetDataRow(i);
                    rowID = Convert.ToInt16(row["CustomerID"]);
                    rowHit = i;
                }

                if (InvclsCustomer.RetrieveData(rowID))
                {
                    txtCustomerName.Text = InvclsCustomer.CustomerName;
                    txtAddress1.Text = InvclsCustomer.Address1;
                    txtAddress2.Text = InvclsCustomer.Address2;
                    txtPhoneNo.Text = InvclsCustomer.Phone;
                    txtPANNo.Text = InvclsCustomer.PANNO;
                    txtMode.Text = "Update";
                    InvclsCustomer.CustomerID = rowID;
                    txtCustomerName.Focus();
                    txtCustomerName.SelectionStart = txtCustomerName.Text.Length + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //private void txtCustomerName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{

        //    if (InvCustValidation.IsEmptyValidate(txtCustomerName.Text) == false)
        //    {
        //        errorProvider1.SetError(txtCustomerName, "Please Provide Customer Name");
        //        CmdSave.Enabled = false;
        //        txtCustomerName.Focus();
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtCustomerName, "");
        //        CmdSave.Enabled = true;
        //    }
        //}

        private void txtCustomerName_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                if (InvCustValidation.IsEmptyValidate(txtCustomerName.Text) == false)
                {
                    errorProvider1.SetError(txtCustomerName, "Please Provide Customer Name");
                    CmdSave.Enabled = false;
                    txtCustomerName.Focus();
                }
                else
                {
                    errorProvider1.SetError(txtCustomerName, "");
                    CmdSave.Enabled = true;
                    txtAddress1.Focus();
                }
            }
        }

        private void txtCustomerName_TextChanged(object sender, System.EventArgs e)
        {
            errorProvider1.SetError(txtCustomerName, "");
            CmdSave.Enabled = true;
        }

        private void txtAddress1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                if (InvCustValidation.IsEmptyValidate(txtAddress1.Text) == false)
                {
                    errorProvider1.SetError(txtAddress1, "Please Provide Address1");
                    CmdSave.Enabled = false;
                    txtAddress1.Focus();
                }
                else
                {
                    errorProvider1.SetError(txtAddress1, "");
                    CmdSave.Enabled = true;
                    txtAddress2.Focus();
                }
            }
        }

        private void txtAddress1_TextChanged(object sender, System.EventArgs e)
        {
            errorProvider1.SetError(txtAddress1, "");
            CmdSave.Enabled = true;
        }

        private void txtAddress2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
                txtPhoneNo.Focus();
        }

        //private void txtAddress1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (InvCustValidation.IsEmptyValidate(txtAddress1.Text) == false)
        //    {
        //        errorProvider1.SetError(txtAddress1, "Please Provide Address1");
        //        CmdSave.Enabled = false;
        //        txtAddress1.Focus();
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtAddress1, "");
        //        CmdSave.Enabled = true;
        //    }
        //}

        //private void txtPhoneNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (InvCustValidation.IsEmptyValidate(txtPhoneNo.Text) == false)
        //    {
        //        errorProvider1.SetError(txtPhoneNo, "Please Provide Phone No");
        //        CmdSave.Enabled = false;
        //        txtPhoneNo.Focus();
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtPhoneNo, "");
        //        CmdSave.Enabled = true;
        //    }
        //}

        private void txtPhoneNo_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                if (InvCustValidation.IsEmptyValidate(txtPhoneNo.Text) == false)
                {
                    errorProvider1.SetError(txtPhoneNo, "Please Provide Phone No");
                    CmdSave.Enabled = false;
                    txtPhoneNo.Focus();
                }
                else
                {
                    errorProvider1.SetError(txtPhoneNo, "");
                    CmdSave.Enabled = true;
                    txtPANNo.Focus();
                }
            }
        }

        private void txtPhoneNo_TextChanged(object sender, System.EventArgs e)
        {
            errorProvider1.SetError(txtPhoneNo, "");
            CmdSave.Enabled = true;
        }
        private void txtPANNo_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
                CmdSave.Focus();
        }

        private void Custgridpopulate(int focusrow)
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

                string strSQL = "select CustomerID,CustomerName,Phone from tbl_Customers where Status=1";
                SqlDataAdapter InvDataCustAdapter = new SqlDataAdapter();
                InvDataCustAdapter = InvclsDataAccessLayer.PopulateData(strSQL);
                InvDataCustAdapter.Fill(dsCustomerList1.tbl_Customers);
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
            txtCustomerName.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text="";
            txtPhoneNo.Text="";
            txtPANNo.Text="";
            txtMode.Text = "Insert";
            txtCustomerName.Focus();
        }

    }
}