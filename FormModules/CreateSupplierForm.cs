using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace inventory_control
{
    public partial class CreateSupplierForm : DevExpress.XtraEditors.XtraForm
    {
        clsGlobalValue InvclsGlobalValue = new clsGlobalValue();
        clsCreateSuppliers InvclsSuppliers = new clsCreateSuppliers();
        DataAccessLayer InvDataAccessLayer = new DataAccessLayer();
        clsTools InvTools = new clsTools();
        ErrorProviderExtended MyErrorProvider = new ErrorProviderExtended();
        clsValidation InvSuppValidation = new clsValidation();
        int rowHit = 0;

        public CreateSupplierForm()
        {
            InitializeComponent();
        }


        private void txtSupplierName_KeyDown(object sender,KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                if (InvSuppValidation.IsEmptyValidate(txtSupplierName.Text) == false)
                {
                    errorProvider1.SetError(txtSupplierName, "Please Provide Supplier Name");
                    CmdSave.Enabled = false;
                    txtSupplierName.Focus();
                }
                else
                {
                    errorProvider1.SetError(txtSupplierName, "");
                    CmdSave.Enabled = true;
                    txtAddress1.Focus();
                }
            }
        }

        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtSupplierName, "");
            CmdSave.Enabled = true;
        }

        private void CreateSupplierForm_Load(object sender, EventArgs e)
        {
            MyErrorProvider.Controls.Add((object)txtSupplierName, "Supplier Name");
            MyErrorProvider.Controls.Add((object)txtAddress1, "Address1");
            MyErrorProvider.Controls.Add((object)txtPhone1, "Phone No1");
            MyErrorProvider.Controls.Add((object)txtPanNo, "PAN No");
            MyErrorProvider.Controls.Add((object)txtVATNo, "VAT No");
            // Initially make emergency contact field as non mandatory
            MyErrorProvider.SummaryMessage = "Following fields are mandatory,";
            Suppliergridpopulate(0);

            if (txtMode.Text == "Insert")
                txtSupplierName.Focus();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            int rowID = 0;

            try
            {
                foreach (int i in gridView2.GetSelectedRows())
                {
                    DataRow row = gridView2.GetDataRow(i);
                    rowID = Convert.ToInt16(row["SupplierID"]);
                    rowHit = i;
                }

                if (InvclsSuppliers.RetrieveData(rowID))
                {
                    txtSupplierName.Text = InvclsSuppliers.SupplierName;
                    txtAddress1.Text = InvclsSuppliers.Address1;
                    txtAddress2.Text = InvclsSuppliers.Address2;
                    txtPhone1.Text = InvclsSuppliers.Phone1;
                    txtPhone2.Text = InvclsSuppliers.Phone2;
                    txtFax1.Text = InvclsSuppliers.Fax1;
                    txtfax2.Text = InvclsSuppliers.Fax2;
                    txtEmail.Text = InvclsSuppliers.EmailID;
                    txtPanNo.Text = InvclsSuppliers.PANNo;
                    TxtCSTNo.Text = InvclsSuppliers.CSTNo;
                    txtSTNo.Text = InvclsSuppliers.STNo;
                    txtECCNo.Text = InvclsSuppliers.ECCNo;
                    txtTIN.Text = InvclsSuppliers.TINNo;
                    txtVATNo.Text = InvclsSuppliers.VATNo;
                    txtMode.Text = "Update";
                    InvclsSuppliers.SupplierID = rowID;
                    txtSupplierName.Focus();
                    txtSupplierName.SelectionStart = txtSupplierName.Text.Length + 1;
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
                DialogResult deleterow = MessageBox.Show(this, "Want To Delete This Supplier ?", "Delete Confirmation ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleterow == DialogResult.Yes)
                {
                    foreach (int i in gridView2.GetSelectedRows())
                    {
                        DataRow row = gridView2.GetDataRow(i);
                        rowID = Convert.ToInt16(row["SupplierID"]);
                        rowHit = i;
                    }

                    InvclsSuppliers.SupplierID = rowID;
                    InvclsSuppliers.Mode = "Delete";

                    stat = InvclsSuppliers.DeleteSupplierMaster();

                    if (stat == -1)
                    {
                        msg = "Deletion Error!!! Purchase Transaction Found Against This Supplier.";
                        msg += "\n\n";
                        msg += "So First Delete The Purchase Invoices Against The Supplier And Then Delete This Supplier.";
                        Suppliergridpopulate(rowHit);
                    }
                    else
                    {
                        msg = "Th Supplier Information Is Deleted Successfully.";
                        Suppliergridpopulate(0);
                    }
                    MessageBox.Show(msg, "Delete Status", MessageBoxButtons.OK);
                    txtSupplierName.Focus();
                }
            }
        }

        private void Suppliergridpopulate(int focusrow)
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

                string strSQL = "select SupplierID,SupplierName,Address1, Phone1 from tbl_Suppliers where Status=1 order by SupplierName";
                SqlDataAdapter InvDataSuppAdapter = new SqlDataAdapter();
                InvDataSuppAdapter = InvDataAccessLayer.PopulateData(strSQL);
                InvDataSuppAdapter.Fill(dsSuppliers1.tbl_Suppliers);
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
            txtSupplierName.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtPhone1.Text = "";
            txtPhone2.Text = "";
            txtFax1.Text = "";
            txtfax2.Text = "";
            txtEmail.Text = "";
            txtPanNo.Text = "";
            TxtCSTNo.Text = "";
            txtSTNo.Text = "";
            txtTIN.Text = "";
            txtECCNo.Text = "";
            txtVATNo.Text = "";
            txtMode.Text = "Insert";
            txtSupplierName.Focus();
        }


        private void txtAddress1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                if (InvSuppValidation.IsEmptyValidate(txtAddress1.Text) == false)
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

        //private void txtAddress1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (InvSuppValidation.IsEmptyValidate(txtAddress1.Text) == false)
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


        private void txtAddress1_TextChanged(object sender,System.EventArgs e)
        {
            errorProvider1.SetError(txtAddress1, "");
            CmdSave.Enabled = true;
        }

        private void txtAddress2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
                txtPhone1.Focus();
        }

        //private void txtPhone1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{            
        //    if (InvSuppValidation.IsEmptyValidate(txtPhone1.Text) == false)
        //    {
        //        errorProvider1.SetError(txtPhone1, "Please Provide Phone1");
        //        CmdSave.Enabled = false;
        //        txtPhone1.Focus();
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtPhone1, "");
        //        CmdSave.Enabled = true;
        //    }
        //}

        private void txtPhone1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                if (InvSuppValidation.IsEmptyValidate(txtPhone1.Text) == false)
                {
                    errorProvider1.SetError(txtPhone1, "Please Provide Phone1");
                    CmdSave.Enabled = false;
                    txtPhone1.Focus();
                }
                else
                {
                    errorProvider1.SetError(txtPhone1, "");
                    CmdSave.Enabled = true;
                    txtFax1.Focus();
                }
            }
        }

        private void txtPhone1_TextChanged(object sender, System.EventArgs e)
        {
            errorProvider1.SetError(txtPhone1, "");
            CmdSave.Enabled = true;
        }

        private void txtFax1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
                txtPhone2.Focus();
        }

        private void txtPhone2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
                txtfax2.Focus();
        }

        private void txtfax2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
                txtEmail.Focus();
        }

        private void txtEmail_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
                txtPanNo.Focus();
        }

        private void txtPanNo_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                if (InvSuppValidation.IsEmptyValidate(txtPanNo.Text) == false)
                {
                    errorProvider1.SetError(txtPanNo, "Please Provide PAN No");
                    CmdSave.Enabled = false;
                    txtPanNo.Focus();
                }
                else
                {
                    errorProvider1.SetError(txtPanNo, "");
                    CmdSave.Enabled = true;
                    TxtCSTNo.Focus();
                }
            }
        }

        private void txtPanNo_TextChanged(object sender,System.EventArgs e)
        {
            errorProvider1.SetError(txtPanNo, "");
            CmdSave.Enabled = true;
        }

        //private void txtPanNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{            
        //    if (InvSuppValidation.IsEmptyValidate(txtPanNo.Text) == false)
        //    {
        //        errorProvider1.SetError(txtPanNo, "Please Provide PAN No");
        //        CmdSave.Enabled = false;
        //        txtPanNo.Focus();
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtPanNo, "");
        //        CmdSave.Enabled = true;
        //    }
        //}

        private void TxtCSTNo_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                CmdSave.Enabled = true;
                txtSTNo.Focus();
            }
        }

        private void txtSTNo_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                CmdSave.Enabled = true;
                txtTIN.Focus();
            }
        }

        private void txtTIN_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                CmdSave.Enabled = true;
                txtECCNo.Focus();
            }
        }

        private void txtECCNo_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                CmdSave.Enabled = true;
                txtVATNo.Focus();
            }
        }

        //private void txtVATNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (InvSuppValidation.IsEmptyValidate(txtVATNo.Text) == false)
        //    {
        //        errorProvider1.SetError(txtVATNo, "Please Provide VAT No");
        //        CmdSave.Enabled = false;
        //        txtVATNo.Focus();
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtVATNo, "");
        //        CmdSave.Enabled = true;
        //    }
        //}

        private void txtVATNo_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                if (InvSuppValidation.IsEmptyValidate(txtVATNo.Text) == false)
                {
                    errorProvider1.SetError(txtVATNo, "Please Provide VAT No");
                    CmdSave.Enabled = false;
                    txtVATNo.Focus();
                }
                else
                {
                    errorProvider1.SetError(txtVATNo, "");
                    CmdSave.Enabled = true;
                    CmdSave.Focus();
                }
            }
        }

        private void txtVATNo_TextChanged(object sender, System.EventArgs e)
        {
            errorProvider1.SetError(txtVATNo, "");
            CmdSave.Enabled = true;
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            if ((MyErrorProvider.CheckAndShowSummaryErrorMessage() == true))
            {
                try
                {
                    string msg = "Do You Want To Save?";
                    DialogResult result = MessageBox.Show(this, msg, "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        InvclsSuppliers.SupplierName = InvTools.formatInputString(txtSupplierName.Text.Trim());
                        InvclsSuppliers.Address1 = InvTools.formatInputString(txtAddress1.Text.Trim());
                        InvclsSuppliers.Address2 = InvTools.formatInputString(txtAddress1.Text.Trim());
                        InvclsSuppliers.Phone1 = InvTools.formatInputString(txtPhone1.Text.Trim());
                        InvclsSuppliers.Phone2 = InvTools.formatInputString(txtPhone2.Text.Trim());
                        InvclsSuppliers.Fax1 = InvTools.formatInputString(txtFax1.Text.Trim());
                        InvclsSuppliers.Fax2 = InvTools.formatInputString(txtfax2.Text.Trim());
                        InvclsSuppliers.EmailID = InvTools.formatInputString(txtEmail.Text.Trim());

                        InvclsSuppliers.PANNo = InvTools.formatInputString(txtPanNo.Text.Trim());
                        InvclsSuppliers.CSTNo = InvTools.formatInputString(TxtCSTNo.Text.Trim());
                        InvclsSuppliers.STNo = InvTools.formatInputString(txtSTNo.Text.Trim());
                        InvclsSuppliers.TINNo = InvTools.formatInputString(txtTIN.Text.Trim());
                        InvclsSuppliers.ECCNo = InvTools.formatInputString(txtECCNo.Text.Trim());
                        InvclsSuppliers.VATNo = InvTools.formatInputString(txtVATNo.Text.Trim());
                        InvclsSuppliers.LoginUserID = InvclsGlobalValue.Login_UserId;
                        InvclsSuppliers.LoginDate = DateTime.Now;
                        InvclsSuppliers.Status = true;

                        InvclsSuppliers.Mode = InvTools.formatInputString(txtMode.Text.Trim());

                        int i = InvclsSuppliers.UpdateData();

                        if (txtMode.Text.Trim() == "Insert")
                            msg = "New Supplier Created Successfully.";
                        else
                            msg = "Supplier Information Updated Successfully.";


                        if (i > 0)
                        {
                            MessageBox.Show(msg);
                            clearData();
                            Suppliergridpopulate(rowHit);
                        }
                        else
                        {
                            if (i == -1)
                            {
                                MessageBox.Show("Sorry!!! Duplicate Supplier Found.");
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

    }
}