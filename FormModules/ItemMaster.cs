using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace inventory_control
{
    public partial class ItemMaster : DevExpress.XtraEditors.XtraForm
    {
        clsGlobalValue InvclsGlobalValue = new clsGlobalValue();
        clsCreateItemMaster InvclsItemMaster = new clsCreateItemMaster();
        DataAccessLayer InvItemMaster = new DataAccessLayer();
        clsTools InvTools = new clsTools();
        clsValidation InvItemValidation = new clsValidation();
        ErrorProviderExtended MyErrorProvider = new ErrorProviderExtended();
        Commons clsInvCommon = new Commons();
        public string CallMenuFrom = string.Empty;
        public int gridRowHandle;

        int rowHit = 0;

        
        public ItemMaster()
        {
            InitializeComponent();
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
                        InvclsItemMaster.ItemCode = InvTools.formatInputString(txtItemCode.Text.Trim());
                        InvclsItemMaster.ItemName = InvTools.formatInputString(txtItemName.Text.Trim());
                        InvclsItemMaster.ItemDesc = InvTools.formatInputString(txtItemDescription.Text.Trim());
                        InvclsItemMaster.UnitPrice = Convert.ToDecimal(InvTools.formatInputString(txtPrice.Text.Trim()));
                        InvclsItemMaster.UnitID = Convert.ToInt16(txtUnit.GetColumnValue("UnitID"));
                        InvclsItemMaster.UnitIDItemIndex = txtUnit.ItemIndex;
                        InvclsItemMaster.ItemGroupCode =Convert.ToInt16(ItemGroupCode.GetColumnValue("ItemGroupCode"));
                        InvclsItemMaster.ItemGroupCodeItemIndex = ItemGroupCode.ItemIndex;
                        InvclsItemMaster.ItemOpStock = Convert.ToInt16(InvTools.formatInputString(txtOpStock.Text.Trim()));
                        InvclsItemMaster.ItemBrandId = Convert.ToInt16(CmbBrand.GetColumnValue("BrandID"));
                        InvclsItemMaster.ItemBrandIdItemIndex = Convert.ToInt16(CmbBrand.ItemIndex);
                        InvclsItemMaster.Status = true;
                        InvclsItemMaster.UserLoginID = InvclsGlobalValue.Login_UserId;
                        InvclsItemMaster.EntryDate= DateTime.Now;
                        InvclsItemMaster.Mode =  InvTools.formatInputString(txtMode.Text.Trim());

                        int i = InvclsItemMaster.UpdateData();

                        if (txtMode.Text.Trim() == "Insert")
                            msg = "New Item Created Successfully.";
                        else
                            msg = "Item Information Updated Successfully.";

                        if (i > 0)
                        {
                            MessageBox.Show(msg);
                            ClearData();
                            Itemgridpopulate(rowHit);

                            if (CallMenuFrom == "ItemPurchase")
                            {
                                string[] param = new string[4];

                                param[0] = "A";
                                param[1] = "B";
                                param[2] = "C";

//                                ItemPurchase clsItemPurchase = new ItemPurchase(param, CallMenuFrom,gridRowHandle);
                                ItemPurchase clsItemPurchase = new ItemPurchase();
                                int code = InvclsItemMaster.GetLastID();
                                clsItemPurchase.ItemPurchaseUpdate(code);

                                this.Close();
                            }
                        }
                        else
                        {
                            if (i == -1)
                            {
                                MessageBox.Show("Sorry!!! Duplicate ItemName Found.");
                            }
                            else if (i == -2)
                            {
                                MessageBox.Show("Sorry!!! Duplicate ItemCode Found.");
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

        private void Itemgridpopulate(int focusrow)
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

                string strSQL = "select ItemNo,ItemCode,ItemName,UnitName,UnitPrice,OpStock from tbl_ItemMaster a inner join";
                        strSQL += "  tbl_UnitMaster b on a.UnitID =b.UnitID where a.Status=1 and b.Status=1";
                
                SqlDataAdapter InvDataCustAdapter = new SqlDataAdapter();
                InvDataCustAdapter = InvItemMaster.PopulateData(strSQL);
                InvDataCustAdapter.Fill(dsItemMaster1.tbl_ItemMaster);
                gridView2.FocusedRowHandle = focusrow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void CmdNew_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            txtItemCode.Text = "";
            txtItemName.Text = "";
            txtItemDescription.Text = "";
            txtOpStock.Text = "";
            txtUnit.ItemIndex = -1;
            ItemGroupCode.ItemIndex = -1;
            CmbBrand.ItemIndex = -1;
            txtMode.Text = "Insert";
            txtItemCode.Text = InvclsItemMaster.AutoGeneratedItemCode();
            txtOpStock.Text = "0";
            txtPrice.Text = "0.00";
            txtItemName.Focus();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            int rowID = 0;

            try
            {

                foreach (int i in gridView2.GetSelectedRows())
                {
                    DataRow row = gridView2.GetDataRow(i);
                    rowID = Convert.ToInt16(row["ItemNo"]);
                    rowHit = i;
                }

                if (InvclsItemMaster.RetrieveData(rowID))
                {
                    txtItemCode.Text = InvclsItemMaster.ItemCode;
                    txtItemName.Text = InvclsItemMaster.ItemName;
                    txtItemDescription.Text = InvclsItemMaster.ItemDesc;
                    txtPrice.Text = InvclsItemMaster.UnitPrice.ToString();
                    txtOpStock.Text = InvclsItemMaster.ItemOpStock.ToString();
                    txtUnit.ItemIndex = InvclsItemMaster.UnitIDItemIndex;
                    ItemGroupCode.ItemIndex = InvclsItemMaster.ItemGroupCodeItemIndex;
                    CmbBrand.ItemIndex = InvclsItemMaster.ItemBrandIdItemIndex;
                    txtMode.Text = "Update";
                    InvclsItemMaster.ItemNo = rowID;
                    txtItemName.Focus();
                    txtItemName.SelectionStart = txtItemName.Text.Length + 1;
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
                DialogResult deleterow = MessageBox.Show(this, "Want To Delete This Item ?", "Delete Confirmation ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleterow == DialogResult.Yes)
                {
                    foreach (int i in gridView2.GetSelectedRows())
                    {
                        DataRow row = gridView2.GetDataRow(i);
                        rowID = Convert.ToInt16(row["ItemNo"]);
                        rowHit = i;
                    }

                    InvclsItemMaster.ItemNo = rowID;
                    InvclsItemMaster.Mode = "Delete";

                    stat = InvclsItemMaster.DeleteItemMaster();

                    if (stat == -1)
                    {
                        msg = "Deletion Error!!! Transaction Record Found Against This Item.";
                        msg += "\n\n";
                        msg += "So First Delete All The Transactions Against This Item And Then Delete This Item.";
                        Itemgridpopulate(rowHit);
                    }
                    else
                    {
                        msg = "The Item Is Deleted Successfully.";
                        Itemgridpopulate(0);
                    }
                    MessageBox.Show(msg, "Delete Status", MessageBoxButtons.OK);
                    txtItemName.Focus();
                }
            }
        }

        //private void txtItemName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{

        //    if (InvItemValidation.IsEmptyValidate(txtItemName.Text) == false)
        //    {
        //        errorProvider1.SetError(txtItemName, "Please Provide Item Name");
        //        CmdSave.Enabled = false;
        //        txtItemName.Focus();
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtItemName, "");
        //        CmdSave.Enabled = true;
        //    }
        //}

        private void txtItemName_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                if (InvItemValidation.IsEmptyValidate(txtItemName.Text) == false)
                {
                    errorProvider1.SetError(txtItemName, "Please Provide Item Name");
                    CmdSave.Enabled = false;
                    txtItemName.Focus();
                }
                else
                {
                    errorProvider1.SetError(txtItemName, "");
                    CmdSave.Enabled = true;
                    ItemGroupCode.Focus();
                }
            }
        }

        private void txtItemName_TextChanged(object sender, System.EventArgs e)
        {
            errorProvider1.SetError(txtItemName, "");
            CmdSave.Enabled = true;
        }

        private void ItemGroupCode_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                if (InvItemValidation.IsEmptyValidate(ItemGroupCode.Text.Trim()) == false)
                {
                    errorProvider1.SetError(ItemGroupCode, "Please Choose Item Group");
                    CmdSave.Enabled = false;
                    ItemGroupCode.Focus();
                }
                else
                {
                    errorProvider1.SetError(ItemGroupCode, "");
                    CmdSave.Enabled = true;
                    txtUnit.Focus();
                }
            }
        }

        private void ItemGroupCode_ItemChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            ItemGroupCode.SelectedText = ItemGroupCode.GetColumnValue("ItemGroupCode").ToString();
        }

        private void txtUnit_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                if (InvItemValidation.IsEmptyValidate(txtUnit.Text.Trim()) == false)
                {
                    errorProvider1.SetError(txtUnit, "Please Choose Item Unit");
                    CmdSave.Enabled = false;
                    txtUnit.Focus();
                }
                else
                {
                    errorProvider1.SetError(txtUnit, "");
                    CmdSave.Enabled = true;
                    CmbBrand.Focus();
                }
            }
        }

        private void txtUnit_ItemChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            txtUnit.SelectedText = txtUnit.GetColumnValue("UnitID").ToString();
        }

        private void CmbBrand_ItemChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {

            CmbBrand.SelectedText = CmbBrand.GetColumnValue("BrandID").ToString();
        }

        private void CmbBrand_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                if (InvItemValidation.IsEmptyValidate(CmbBrand.Text.Trim()) == false)
                {
                    errorProvider1.SetError(CmbBrand, "Please Choose Item Brand");
                    CmdSave.Enabled = false;
                    CmbBrand.Focus();
                }
                else
                {
                    errorProvider1.SetError(CmbBrand, "");
                    CmdSave.Enabled = true;
                    txtOpStock.Focus();
                }
            }
        }

        private void txtOpStock_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
                    txtPrice.Focus();
        }

        private void txtOpStock_TextChanged(object sender, System.EventArgs e)
        {
            errorProvider1.SetError(txtOpStock, "");
            CmdSave.Enabled = true;
        }

        private void txtPrice_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                if (InvItemValidation.IsNumber(txtPrice.Text.Trim()) == false)
                {
                    errorProvider1.SetError(txtPrice, "Please Provide Item Price.");
                    CmdSave.Enabled = false;
                    CmbBrand.Focus();
                }
                else if (Convert.ToDecimal(txtPrice.Text) <= 0)
                {
                    errorProvider1.SetError(txtPrice, "Item Price Should Be Greater Than Zero.");
                    CmdSave.Enabled = false;
                    txtPrice.Focus();
                }
                else
                {
                    errorProvider1.SetError(txtPrice, "");
                    CmdSave.Enabled = true;
                    txtItemDescription.Focus();
                }
            }
        }

        private void txtPrice_TextChanged(object sender, System.EventArgs e)
        {
            if (Convert.ToDecimal(txtPrice.Text) < 0)
            {
                errorProvider1.SetError(txtPrice, "Item Price Should Be Greater Than Zero.");
                CmdSave.Enabled = false;
                txtPrice.Focus();
            }
            else
            {
                errorProvider1.SetError(txtPrice, "");
                CmdSave.Enabled = true;
            }
        }

        private void txtItemDescription_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                CmdSave.Focus();
        }

        //private void txtItemCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{

        //    if (InvItemValidation.IsEmptyValidate(txtItemCode.Text) == false)
        //    {
        //        errorProvider1.SetError(txtItemCode, "Please Provide Item Code");
        //        CmdSave.Enabled = false;
        //        txtItemCode.Focus();
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtItemCode, "");
        //        CmdSave.Enabled = true;
        //    }
        //}

        //private void txtPrice_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{

        //    if (InvItemValidation.IsEmptyValidate(txtPrice.Text) == false)
        //    {
        //        errorProvider1.SetError(txtPrice, "Please Provide Item Price");
        //        CmdSave.Enabled = false;
        //        txtPrice.Focus();
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtPrice, "");
        //        CmdSave.Enabled = true;
        //    }
        //}

        //private void txtOpStock_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (InvItemValidation.IsEmptyValidate(txtOpStock.Text) == false)
        //    {
        //        errorProvider1.SetError(txtOpStock, "Please Provide Item OpStock");
        //        CmdSave.Enabled = false;
        //        txtOpStock.Focus();
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtOpStock, "");
        //        CmdSave.Enabled = true;
        //    }
        //}

        //private void ItemGroupCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (InvItemValidation.IsEmptyValidate(ItemGroupCode.Text) == false)
        //    {
        //        errorProvider1.SetError(ItemGroupCode, "Please Select Item Group");
        //        CmdSave.Enabled = false;
        //        ItemGroupCode.Focus();
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(ItemGroupCode, "");
        //        CmdSave.Enabled = true;
        //    }
        //}

        //private void CmbBrand_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (InvItemValidation.IsEmptyValidate(CmbBrand.Text) == false)
        //    {
        //        errorProvider1.SetError(CmbBrand, "Please Select Item Brand");
        //        CmdSave.Enabled = false;
        //        CmbBrand.Focus();
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(CmbBrand, "");
        //        CmdSave.Enabled = true;
        //    }
        //}

        //private void txtUnit_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (InvItemValidation.IsEmptyValidate(txtUnit.Text) == false)
        //    {
        //        errorProvider1.SetError(txtUnit, "Please Select Item Unit");
        //        CmdSave.Enabled = false;
        //        txtUnit.Focus();
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtUnit, "");
        //        CmdSave.Enabled = true;
        //    }
        //}

        private void CreateItemMaster_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(InvclsGlobalValue.Logged.ToString());
            //MessageBox.Show(InvclsGlobalValue.Login_UserId.ToString());
            //MessageBox.Show(InvclsGlobalValue.FinYear.ToString());
            //MessageBox.Show(InvclsGlobalValue.StartDate.ToString());
            //MessageBox.Show(InvclsGlobalValue.EndDate.ToString());
            MyErrorProvider.Controls.Add((object)txtItemCode, "Item Code");
            MyErrorProvider.Controls.Add((object)txtItemName, "Item Name");
            MyErrorProvider.Controls.Add((object)ItemGroupCode, "Item Group");
            MyErrorProvider.Controls.Add((object)txtUnit, "Item Unit");
            MyErrorProvider.Controls.Add((object)txtPrice, "Item Price");
            MyErrorProvider.Controls.Add((object)CmbBrand, "Item Brand");
            MyErrorProvider.Controls.Add((object)txtOpStock, "Item OpStock");
            // Initially make emergency contact field as non mandatory
            MyErrorProvider.SummaryMessage = "Following fields are mandatory,";

            clsInvCommon.populateUnitMaster(InvItemMaster, dsUnitMaster1.tbl_UnitMaster);
            clsInvCommon.populateItemGroupMaster(InvItemMaster, dsItemGroup1.tbl_ItemGroupMaster);
            clsInvCommon.populateBrandMaster(InvItemMaster,dsBrandMaster1.tbl_BrandMaster);

            Itemgridpopulate(0); 
      
            if (txtMode.Text == "Insert")
            {
                txtItemCode.Text = InvclsItemMaster.AutoGeneratedItemCode();
                txtOpStock.Text = "0";
                txtPrice.Text = "0.00";
            }
        }

        
    }
}