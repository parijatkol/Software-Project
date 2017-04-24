﻿using System;
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
    public partial class BrandMaster : DevExpress.XtraEditors.XtraForm
    {
        clsGlobalValue InvClsGlobal = new clsGlobalValue();
        DataAccessLayer InvDataAccessLayer = new DataAccessLayer();
        clsBrandMaster InvclsBrandMaster = new clsBrandMaster();
        clsTools InvclsTools = new clsTools();
        clsValidation InvBrandValidation = new clsValidation();
        ErrorProviderExtended MyErrorProvider = new ErrorProviderExtended();
        int rowHit = 0;

        public BrandMaster()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if ((MyErrorProvider.CheckAndShowSummaryErrorMessage()==true))
            {
                try
                {
                    string msg = "Do You Want To Save?";
                    DialogResult result = MessageBox.Show(this, msg, "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        InvclsBrandMaster.BrandCode = InvclsTools.formatInputString(txtBrandCode.Text.Trim());
                        InvclsBrandMaster.BrandName = InvclsTools.formatInputString(txtBrandName.Text.Trim());
                        InvclsBrandMaster.BrandDesc = InvclsTools.formatInputString(txtBrandDesc.Text);
                        InvclsBrandMaster.UserLoginID = InvClsGlobal.Login_UserId;
                        InvclsBrandMaster.EntryDate = DateTime.Now;
                        InvclsBrandMaster.Status = true;
                        InvclsBrandMaster.Mode = InvclsTools.formatInputString(txtMode.Text.Trim());

                        int i = InvclsBrandMaster.UpdateData();

                        if (txtMode.Text.Trim() == "Insert")
                            msg = "New Brand Master Created Successfully.";
                        else
                            msg = "Brand Master Updated Successfully.";


                        if (i > 0)
                        {
                            MessageBox.Show(msg);
                            clearData();
                            gridpopulate(rowHit);
                        }
                        else
                        {
                            if (i == -1)
                            {
                                MessageBox.Show("Sorry!!! Duplicate Brand Name Found.");
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

        private void BrandMaster_Load(object sender, EventArgs e)
        {
//            MyErrorProvider.Controls.Add((object)txtBrandCode, "Brand Code");
            MyErrorProvider.Controls.Add((object)txtBrandName, "Brand Name");
            // Initially make emergency contact field as non mandatory
            MyErrorProvider.SummaryMessage = "Following fields are mandatory,";
            gridpopulate(0);

            if (txtMode.Text == "Insert")
            {
                txtBrandCode.Text = InvclsBrandMaster.AutoGeneratedBrandCode();
            }
        }

        //private void txtBrandCode_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        //{
        //    if ((e.KeyCode == Keys.Enter) | (e.KeyCode == Keys.Tab))
        //    {
        //        if (InvBrandValidation.IsEmptyValidate(txtBrandCode.Text) == false)
        //        {
        //            errorProvider1.SetError(txtBrandCode, "Please Provide BrandCode");
        //            cmdSave.Enabled = false;
        //            txtBrandCode.Focus();
        //        }
        //        else
        //        {
        //            errorProvider1.SetError(txtBrandCode, "");
        //            cmdSave.Enabled = true;
        //            txtBrandName.Focus();
        //        }
        //    }
        //}

        private void txtBrandName_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                if (InvBrandValidation.IsEmptyValidate(txtBrandName.Text) == false)
                {
                    errorProvider1.SetError(txtBrandName, "Please Provide BrandName");
                    cmdSave.Enabled = false;
                    txtBrandName.Focus();
                }
                else
                {
                    errorProvider1.SetError(txtBrandName, "");
                    cmdSave.Enabled = true;
                    txtBrandDesc.Focus();
                }
            }
        }

        private void txtBrandName_TextChanged(object sender, System.EventArgs e)
        {
            errorProvider1.SetError(txtBrandName, "");
            cmdSave.Enabled = true;
        }

        private void txtBrandDesc_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                cmdSave.Focus();
        }        
        
        //private void txtBrandName_GotFocus(object sender,System.EventArgs e)
        //{
        //    if (InvBrandValidation.IsEmptyValidate(txtBrandCode.Text) == false)
        //    {
        //        errorProvider1.SetError(txtBrandCode, "Please Provide BrandCode");
        //        cmdSave.Enabled = false;
        //        txtBrandCode.Focus();
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtBrandCode, "");
        //    }
        //}


        //private void txtBrandCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (InvBrandValidation.IsEmptyValidate(txtBrandCode.Text) == false)
        //    {
        //        errorProvider1.SetError(txtBrandCode, "Please Provide BrandCode");
        //        cmdSave.Enabled = false;
        //        txtBrandCode.Focus();
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtBrandCode, "");
        //        cmdSave.Enabled = true;
        //    }
        //}

        //private void txtBrandName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (InvBrandValidation.IsEmptyValidate(txtBrandName.Text) == false)
        //    {
        //        errorProvider1.SetError(txtBrandName, "Please Provide BrandName");
        //        cmdSave.Enabled = false;
        //        txtBrandName.Focus();
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtBrandName, "");
        //        cmdSave.Enabled = true;
        //    }
        //}

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            int rowID = 0;

            try
            {

                foreach (int i in gridView2.GetSelectedRows())
                {
                    DataRow row = gridView2.GetDataRow(i);
                    rowID = Convert.ToInt16(row["BrandID"]);
                    rowHit = i;
                }

                if (InvclsBrandMaster.RetrieveData(rowID))
                {
                    txtBrandCode.Text = InvclsBrandMaster.BrandCode;
                    txtBrandName.Text = InvclsBrandMaster.BrandName;
                    txtBrandDesc.Text = InvclsBrandMaster.BrandDesc;
                    txtMode.Text = "Update";
                    txtBrandName.Focus();
                    InvclsBrandMaster.BrandID = rowID;
                    txtBrandName.SelectionStart = txtBrandName.Text.Length;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void gridpopulate(int focusrow)
        {
            try
            {
                int totrow = gridView2.RowCount;
                for (int i = 0; i <totrow ; )
                {
                    DataRow row = gridView2.GetDataRow(i);
                    row.Delete();
                    totrow = gridView2.RowCount;
                }

                SqlDataAdapter InvBrandDataAdpt = new SqlDataAdapter();
                string SQL = "select BrandID,BrandCode,BrandName from tbl_BrandMaster where Status=1";
                InvBrandDataAdpt = InvDataAccessLayer.PopulateData(SQL);
                InvBrandDataAdpt.Fill(dsBrandMaster1.tbl_BrandMaster);
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
            txtBrandCode.Text = "";
            txtBrandName.Text = "";
            txtBrandDesc.Text = "";
            txtMode.Text = "Insert";
            txtBrandName.Focus();
            txtBrandCode.Text = InvclsBrandMaster.AutoGeneratedBrandCode();
        }

        private void gridControl1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            int rowID = 0;
            int stat = 0;
            string msg = string.Empty;


            if (e.KeyCode == Keys.Delete)
            {
                DialogResult deleterow = MessageBox.Show(this, "Want To Delete This Brand ?", "Delete Confirmation ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleterow == DialogResult.Yes)
                {
                    foreach (int i in gridView2.GetSelectedRows())
                    {
                        DataRow row = gridView2.GetDataRow(i);
                        rowID = Convert.ToInt16(row["BrandID"]);
                        rowHit = i;
                    }

                    InvclsBrandMaster.BrandID = rowID;
                    InvclsBrandMaster.Mode = "Delete";

                    stat = InvclsBrandMaster.DeleteBrandMaster();

                    if (stat == -1)
                    {
                        msg = "Deletion Error!!! Product(s) Found Against This Brand.";
                        msg += "\n";
                        msg += "So First Delete The Product Belongs To This Brand And Then Delete This Brand.";
                        gridpopulate(rowHit);
                    }
                    else
                    {
                        msg = "This Brand Is Deleted Successfully.";
                        gridpopulate(0);
                    }

                    MessageBox.Show(msg,"Delete Status",MessageBoxButtons.OK);
                    txtBrandName.Focus();
                }
            }
        }

    }
}