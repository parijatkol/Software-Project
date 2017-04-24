using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;


namespace inventory_control
{
    public partial class ItemPurchase : DevExpress.XtraEditors.XtraForm
    {
        clsGlobalValue InvclsGlobalValue = new clsGlobalValue();
        clsItemPurchase InvItemPurchase = new clsItemPurchase();
        DataAccessLayer InvItemPurchaseMaster = new DataAccessLayer();
        clsTools InvTools = new clsTools();
        clsValidation InvItemValidation = new clsValidation();
        clsCreateSuppliers InvSuppliers = new clsCreateSuppliers();
        ErrorProviderExtended MyErrorProvider = new ErrorProviderExtended();
        Commons clsInvCommon = new Commons();
        
        string tblGrid = "[Purchase Details]";

        int rowHit = 0;
        int getSupplierID = 0;
        int rowID = 0;

        public ItemPurchase()
        {
            InitializeComponent();
        }

        public void ItemPurchaseUpdate(int code)
        {
            DataTable dt = new DataTable();
//          InitializeComponent();
//          DevExpress.XtraEditors.LookUpEdit editnew = new LookUpEdit();
//          RepositoryItemLookUpEdit repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();

            Commons clsInvCommon1 = new Commons();

            dt = clsInvCommon1.populateItemMasterForGrid(InvItemPurchaseMaster, "NewItemMaster");
            MessageBox.Show(dt.Rows.Count.ToString());
            repositoryItemLookUpEdit1.ForceInitialize();
            repositoryItemLookUpEdit1.DataSource = dt;
            repositoryItemLookUpEdit1.DisplayMember = "ItemName";
            repositoryItemLookUpEdit1.ValueMember = "ItemNo";

            dt.NewRow();
            clsCreateItemMaster InvItemMasterNew = new clsCreateItemMaster();

            InvItemMasterNew.RetrieveData(code);

            GridView view = gridControl1.FocusedView as GridView; //gridView1;

            //foreach (int row in view.GetSelectedRows())
            //{
                //view.SetRowCellValue(view.FocusedRowHandle, view.Columns["ItemCode"], InvItemMaster.ItemCode);
                //view.SetRowCellValue(view;, view.Columns["UnitName"], InvItemMasterNew.UnitName);
                view.SetRowCellValue(view.FocusedRowHandle, view.Columns["Amount"], InvItemMasterNew.UnitPrice);
                view.SetRowCellValue(view.FocusedRowHandle, view.Columns["ItemNo"], code);
                view.SetRowCellValue(view.FocusedRowHandle, view.Columns["Qty"], 1);
           // }





        }

        //private void CmdSave_Click(object sender, EventArgs e)
        //{
        //    if ((MyErrorProvider.CheckAndShowSummaryErrorMessage() == true))
        //    {
        //        try
        //        {
        //            string msg = "Do You Want To Save?";
        //            DialogResult result = MessageBox.Show(this, msg, "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //            if (result == DialogResult.Yes)
        //            {
        //                InvclsItemMaster.ItemCode = InvTools.formatInputString(txtItemCode.Text.Trim());
        //                InvclsItemMaster.ItemName = InvTools.formatInputString(txtItemName.Text.Trim());
        //                InvclsItemMaster.ItemDesc = InvTools.formatInputString(txtItemDescription.Text.Trim());
        //                InvclsItemMaster.UnitPrice = Convert.ToDecimal(InvTools.formatInputString(txtPrice.Text.Trim()));
        //                InvclsItemMaster.UnitID = Convert.ToInt16(txtUnit.GetColumnValue("UnitID"));
        //                InvclsItemMaster.UnitIDItemIndex = txtUnit.ItemIndex;
        //                InvclsItemMaster.ItemGroupCode = Convert.ToInt16(ItemGroupCode.GetColumnValue("ItemGroupCode"));
        //                InvclsItemMaster.ItemGroupCodeItemIndex = ItemGroupCode.ItemIndex;
        //                InvclsItemMaster.ItemOpStock = Convert.ToInt16(InvTools.formatInputString(txtOpStock.Text.Trim()));
        //                InvclsItemMaster.ItemBrandId = Convert.ToInt16(CmbBrand.GetColumnValue("BrandID"));
        //                InvclsItemMaster.ItemBrandIdItemIndex = Convert.ToInt16(CmbBrand.ItemIndex);
        //                InvclsItemMaster.Status = true;
        //                InvclsItemMaster.UserLoginID = InvclsGlobalValue.Login_UserId;
        //                InvclsItemMaster.EntryDate = DateTime.Now;
        //                InvclsItemMaster.Mode = InvTools.formatInputString(txtMode.Text.Trim());

        //                int i = InvclsItemMaster.UpdateData();

        //                if (txtMode.Text.Trim() == "Insert")
        //                    msg = "New Item Created Successfully.";
        //                else
        //                    msg = "Item Information Updated Successfully.";

        //                if (i > 0)
        //                {
        //                    MessageBox.Show(msg);
        //                    ClearData();
        //                    Itemgridpopulate(rowHit);
        //                }
        //                else
        //                {
        //                    if (i == -1)
        //                    {
        //                        MessageBox.Show("Sorry!!! Duplicate ItemName Found.");
        //                    }
        //                    else if (i == -2)
        //                    {
        //                        MessageBox.Show("Sorry!!! Duplicate ItemCode Found.");
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Error In Saving!!!!!!!!!!!");
        //                    }
        //                }

        //                if (result == DialogResult.No)
        //                {
        //                    MessageBox.Show("Error In Saving !!!!!!!!!!");
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message.ToString());
        //        }
        //    }
        //}

        //Private void Itemgridpopulate(int focusrow)
        //{
        //    try
        //    {
        //        int totrow = gridView2.RowCount;
        //        for (int i = 0; i < totrow; )
        //        {
        //            DataRow row = gridView2.GetDataRow(i);
        //            row.Delete();
        //            totrow = gridView2.RowCount;
        //        }

        //        string strSQL = "select ItemNo,ItemCode,ItemName,UnitName,UnitPrice,OpStock from tbl_ItemMaster a inner join";
        //                strSQL += "  tbl_UnitMaster b on a.UnitID =b.UnitID where a.Status=1 and b.Status=1";
                
        //        SqlDataAdapter InvDataCustAdapter = new SqlDataAdapter();
        //        InvDataCustAdapter = InvItemMaster.PopulateData(strSQL);
        //        InvDataCustAdapter.Fill(dsItemMaster1.tbl_ItemMaster);
        //        gridView2.FocusedRowHandle = focusrow;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString());
        //    }
        //}

        //private void CmdNew_Click(object sender, EventArgs e)
        //{
        //    ClearData();
        //    txtMode.Text = "Insert";
        //}

        private void ClearData()
        {
            cmbSupplier.ItemIndex=-1;
            txtAddress.Text= "";
            txtVATNo.Text = "";
            txtCSTNo.Text="";
            txtPhone.Text = "";

            txtInvDate.Text = String.Format("{0:MM/dd/yyyy}",DateTime.Now);
            txtInvNo.Text = "";

            txtRemarks.Text = "";
            txtAdjustment.Text = "";
            txtdeliverycharge.Text = "";
            txtSubTotal.Text = "";
            txtdiscount.Text = "";
            txtVATAmt.Text = "";
            txtTotalAmt.Text = "";
            txtRoundedOff.Text = "";
            ChkRoundedOff.Checked = false;

            for (int i = gridView1.RowCount; i >= 0; i--)
                gridView1.DeleteRow(i);

            for (int i1 = gridView2.RowCount; i1 >= 0; i1--)
                gridView2.DeleteRow(i1);

            cmbSupplier.Focus();
        }

        /*private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            GridColumn column1 = view.Columns["ItemName"];
            GridColumn column2 = view.Columns["Qty"];

            if (column1==null) 
            {
                e.Valid = false;
                view.SetColumnError(column1, "Please Choose Any Item");
            }

            if (column2 !=null)
            {
                view.SetColumnError(column2, "Please Enter The Quantity"); 
                MessageBox.Show(gridView1.Columns["Total"].SummaryItem.SummaryValue.ToString());
            }
 
        } */

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            string Total = gridView1.Columns["Total"].SummaryItem.SummaryValue.ToString();
            txtSubTotal.Text = Total.ToString();
            txtTotalAmt.Text = txtSubTotal.Text;

            string[] param1 = { txtAdjustment.Text, txtVATAmt.Text, txtRoundedOff.Text,txtdeliverycharge.Text,txtdiscount.Text };
            string[] param2 = { "+", "+", "-", "+", "-"};
            txtTotalAmt.Text = clsInvCommon.CalculateTotalAmt(Total.ToString(), param1, param2).ToString(); 
        }

        private void cmbSupplier_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                if (InvItemValidation.IsEmptyValidate(cmbSupplier.Text) == false)
                {
                    errorProvider1.SetError(cmbSupplier, "Please Provide Supplier");
                    btnSave.Enabled = false;
                    cmbSupplier.Focus();
                }
                else
                {
                    errorProvider1.SetError(cmbSupplier, "");
                    btnSave.Enabled = true;
                    txtInvNo.Focus();
                }
            }
        }

        private void gridControl1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                DialogResult deleterow = MessageBox.Show(this, "Want To Delete This Row", "Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleterow == DialogResult.Yes)        
                    gridView1.DeleteRow(gridView1.SelectedRowsCount);
            }

            if (e.KeyCode == Keys.Escape)
            {
               // MessageBox.Show(gridView1.Columns["Total"].SummaryItem.SummaryValue.ToString());
                //txtTotalAmt.Text = gridView1.Columns["Total"].SummaryItem.SummaryValue.ToString();
                txtAdjustment.Focus();
                //gridView1_CustomSummaryCalculate(((gridView1.Columns["Qty"])sender), e.KeyCode); 
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (gridView1.FocusedColumn.ToString() == "Unit")
                    gridView1.FocusedColumn = gridView1.VisibleColumns[2];
                else
                {
                    if (gridView1.FocusedColumn.ToString() == "Price")
                        gridView1.FocusedColumn = gridView1.VisibleColumns[3];
                }
                


            }

/*            txtSubTotal.Text = gridView1.Columns["Total"].SummaryItem.SummaryValue.ToString();
            txtTotalAmt.Text = txtSubTotal.Text;
            //string Total = gridView1.Columns["Total"].SummaryItem.SummaryValue.ToString();

            string[] param1 = { txtAdjustment.Text, txtVATAmt.Text, txtRoundedOff.Text,txtdeliverycharge.Text,txtdiscount.Text };
            string[] param2 = { "+", "+", "-", "+", "-"};
            txtTotalAmt.Text = clsInvCommon.CalculateTotalAmt(Total.ToString(), param1, param2).ToString(); */
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            int rowID = 0;

            DataSet MyData = new DataSet();

            try
            {
                foreach (int i in gridView2.GetSelectedRows())
                {
                    DataRow row = gridView2.GetDataRow(i);
                    rowID = Convert.ToInt16(row["PurchaseID"]);
                    txtrefid.Text = rowID.ToString();
                    rowHit = i;
                }


                if (InvItemPurchase.RetrieveData(rowID))
                {
                    cmbSupplier.ItemIndex= InvItemPurchase.SupplierIDItemIndex;
                    txtAddress.Text = InvItemPurchase.Address;
                    txtPhone.Text = InvItemPurchase.Phone;
                    txtCSTNo.Text = InvItemPurchase.CSTNo;
                    txtVATNo.Text = InvItemPurchase.VATNo;

                    txtInvNo.Text = InvItemPurchase.InvoiceNo;
                    txtInvDate.Text = InvItemPurchase.InvoiceDate.ToString("MM/dd/yyyy");
                    txtRemarks.Text = InvItemPurchase.Remarks;
                    txtAdjustment.Text = InvItemPurchase.Adjustments.ToString();
                    txtdeliverycharge.Text = InvItemPurchase.deliverycharges.ToString();
                    txtdiscount.Text = InvItemPurchase.discount.ToString();
                    txtVATAmt.Text = InvItemPurchase.VatAmt.ToString();
                    txtRoundedOff.Text = InvItemPurchase.RoundedAmt.ToString();
                    txtTotalAmt.Text = InvItemPurchase.TotalAmt.ToString();


                    //MyData = InvItemPurchase.RetrievePurchaseDetails(rowID);

                    //if (MyData.Tables[0].Rows.Count > 0)
                    //{
                    //    int i = 1;

                    //    foreach (DataRow row in MyData.Tables[0].Rows)
                    //    {
                    //        //view.SetRowCellValue(row, view.Columns["ItemCode"], InvItemMaster.ItemCode);
                    //        gridView1.AddNewRow();
                    //        gridView1.SetRowCellValue(i, gridView1.Columns["ItemNo"], row["ItemNo"].ToString());
                    //        gridView1.SetRowCellValue(i, gridView1.Columns["ItemName"], row["ItemName"].ToString());
                    //        gridView1.SetRowCellValue(i, gridView1.Columns["ItemCode"], row["ItemCode"].ToString());
                    //        gridView1.SetRowCellValue(i, gridView1.Columns["Amount"], row["Amount"].ToString());
                    //        gridView1.SetRowCellValue(i, gridView1.Columns["Qty"], row["Qty"].ToString());
                    //        i++;
                    //    }
                    //}

                    MyData = clsInvCommon.populatePurchaseMasterDetailsRelationInGrid(rowID, InvItemPurchaseMaster, tblGrid);

                    DataViewManager dvManager = new DataViewManager(MyData);
                    DataView dv = dvManager.CreateDataView(MyData.Tables[tblGrid]);

                    gridControl1.DataSource = dv;


                    txtMode.Text = "Update";
                    InvItemPurchase.PurchaseID = rowID;
                    cmbSupplier.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void gridView1_FocusColumnChanged(object sender, EventArgs e)
        {
            gridView1.UpdateSummary();
        }
        
        private void gridView1_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {            
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
                MessageBox.Show("test");
        }

        private void gridView1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e )
        {
            if (e.Button.ToString() == "Right")
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Location);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    ContextMenu1.Show(view.GridControl, e.Location);
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

        private void ItemPurchase_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Te");
            DataSet ItemPurchDs = new DataSet();
            DataTable ItemPurchTbl = new DataTable();


            MyErrorProvider.Controls.Add((object)cmbSupplier, "Supplier");
            MyErrorProvider.Controls.Add((object)txtInvNo, "Purchase Invoice No.");
            MyErrorProvider.Controls.Add((object)txtInvDate, "Invoice Date");
//            MyErrorProvider.Controls.Add((object)gridControl1, "Item Name");
            
            MyErrorProvider.SummaryMessage = "Following fields are mandatory,";

            ItemPurchDs = clsInvCommon.populatePurchaseMasterDetailsRelationInGrid(0, InvItemPurchaseMaster, tblGrid);
            
            DataViewManager dvManager = new DataViewManager(ItemPurchDs);
            DataView dv = dvManager.CreateDataView(ItemPurchDs.Tables[tblGrid]);

            gridControl1.DataSource = dv;

            clsInvCommon.populateSupplierMaster(InvItemPurchaseMaster, dsSuppliers1.tbl_Suppliers);
            repositoryItemLookUpEdit1.DataSource = clsInvCommon.populateItemMasterForGrid(InvItemPurchaseMaster, "ItemMaster");

            clsInvCommon.populatePurchaseMaster(InvItemPurchaseMaster, purchaseMaster1.tbl_PurchaseMaster,"","");

            if (txtMode.Text == "Insert")
            {
                txtInvDate.Text = String.Format("{0:MM/dd/yyyy}",InvclsGlobalValue.Today.ToString());
                cmbSupplier.Focus();
            }

            clsInvCommon.ChangeCurrencyFormat(" Rs ");

        }

        private void cmbSupplier_EditValueChanged(object sender, EventArgs e)
        {
            getSupplierID = Convert.ToInt16(cmbSupplier.GetColumnValue("SupplierID"));

            if (getSupplierID == -1)
            {
                txtAddress.Text = "";
                txtVATNo.Text = "";
                txtCSTNo.Text = "";
                txtPhone.Text = "";
            }
            else
            {
                InvSuppliers.RetrieveData(getSupplierID);
                txtAddress.Text = InvSuppliers.Address1;
                txtVATNo.Text = InvSuppliers.VATNo;
                txtCSTNo.Text = InvSuppliers.CSTNo;
                txtPhone.Text = InvSuppliers.Phone1;
            }
        }

        private void repositoryItemLookUpEdit1_EditValueChanged(object sender, System.EventArgs e)
        {
            clsCreateItemMaster InvItemMaster = new clsCreateItemMaster();
            DevExpress.XtraEditors.LookUpEdit edit;
            edit = sender as DevExpress.XtraEditors.LookUpEdit;
//            string DisplayText = Convert.ToString(edit.Properties.GetDisplayValueByKeyValue());
//            int code = Convert.ToInt16(edit.Properties.GetKeyValueByDisplayValue(DisplayText));
            string DisplayText = edit.Text;

            int code = Convert.ToInt16(edit.EditValue);

            InvItemMaster.RetrieveData(code);

            GridView view = gridControl1.FocusedView as GridView; //gridView1;

            foreach (int row in view.GetSelectedRows())
            {
                //view.SetRowCellValue(view.FocusedRowHandle, view.Columns["ItemCode"], InvItemMaster.ItemCode);
                view.SetRowCellValue(view.FocusedRowHandle, view.Columns["UnitName"], InvItemMaster.UnitName);                
                view.SetRowCellValue(view.FocusedRowHandle, view.Columns["Amount"], InvItemMaster.UnitPrice);
                view.SetRowCellValue(view.FocusedRowHandle, view.Columns["ItemNo"], code);
                view.SetRowCellValue(view.FocusedRowHandle, view.Columns["Qty"], 1);
            }
                //view.FocusedColumn = view.VisibleColumns[1];


            //            MessageBox.Show(DisplayText);
            //            MessageBox.Show(code);            
        }

        private void repositoryItemLookUpEdit1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GridView view = gridControl1.FocusedView as GridView;
                //view.FocusedColumn = view.VisibleColumns[3];
                view.FocusedColumn = view.VisibleColumns[1];
            }

            if (e.KeyCode == Keys.Escape)
            {
                txtAdjustment.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((MyErrorProvider.CheckAndShowSummaryErrorMessage() == true))
            {
                try
                {
                    string msg = "Do You Want To Save?";
                    DialogResult result = MessageBox.Show(this, msg, "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        
                        //------------ Check The GridItems --------------------------------''

                        if (clsInvCommon.CheckGridItem(gridView1, "ItemNo", "Qty") == true)
                        {
                            /////////////////////////////////////////////////////////////////////


                            //====================Purchase Master ============================//

                            InvItemPurchase.InvoiceNo = InvTools.formatInputString(txtInvNo.Text.Trim());
                            InvItemPurchase.InvoiceDate = Convert.ToDateTime(txtInvDate.Text);
                            InvItemPurchase.SupplierID = getSupplierID;
                            InvItemPurchase.SupplierIDItemIndex = cmbSupplier.ItemIndex;
                            InvItemPurchase.FinancialYrID = clsGlobalValue._FinYearID;
                            InvItemPurchase.PaymentMode = "Credit";
                            InvItemPurchase.Remarks = InvTools.formatInputString(txtRemarks.Text);
                            InvItemPurchase.Adjustments = ((txtAdjustment.Text=="") ? 0 : Convert.ToDecimal(txtAdjustment.Text));
                            InvItemPurchase.deliverycharges = ((txtdeliverycharge.Text == "") ? 0 : Convert.ToDecimal(txtdeliverycharge.Text));
                            InvItemPurchase.discount = ((txtdiscount.Text == "") ? 0 : Convert.ToDecimal(txtdiscount.Text));
                            InvItemPurchase.VatAmt = ((txtVATAmt.Text=="")? 0 :Convert.ToDecimal(txtVATAmt.Text));
                            InvItemPurchase.RoundedAmt = ((txtRoundedOff.Text =="") ? 0 : Convert.ToDecimal(txtRoundedOff.Text));
                            //InvItemPurchase.TotalAmt = Convert.ToDecimal(gridView1.Columns["Total"].SummaryItem.SummaryValue);
                            InvItemPurchase.TotalAmt = Convert.ToDecimal(txtTotalAmt.Text);
                            InvItemPurchase.Status = true;
                            InvItemPurchase.UserLoginID = clsGlobalValue._Login_UserId;
                            InvItemPurchase.EntryDate = DateTime.Now;
                            InvItemPurchase.Mode = InvTools.formatInputString(txtMode.Text.Trim());
                            // MessageBox.Show(gridView1.Columns["Total"].SummaryItem.SummaryValue.ToString());

                            //InvItemPurchase.Cheque_DD_No = InvTools.formatInputString(txtCheque_DD_No.Text.Trim());
                            //InvItemPurchase.Cheque_DD_Date = Convert.ToDateTime(txtCheque_DD_Date.Text);
                            //InvItemPurchase.Cheque_DD_Bank = InvTools.formatInputString(txtCheque_DD_Bank.Text.Trim());

                            int i = InvItemPurchase.MasterUpdateData();

                            //=================================================================//


                            //====================Purchase Detail ============================//

                            if (txtMode.Text.Trim() == "Update")
                            {
                                InvItemPurchase.PurchaseID = Convert.ToInt16(txtrefid.Text);
                                InvItemPurchase.DeletePurchaseDetails();
                            }
                            else
                                InvItemPurchase.PurchaseID = i;

                            for (int k = 0; k < gridView1.RowCount; k++)
                            {
                                DataRow row = gridView1.GetDataRow(k);
                                rowID = Convert.ToInt16(row["ItemNo"]);
                                InvItemPurchase.RefPurchaseID = InvItemPurchase.PurchaseID;
                                InvItemPurchase.ItemNo = Convert.ToInt32(row["ItemNo"]);
                                InvItemPurchase.Qty = Convert.ToInt32(row["Qty"]);
                                InvItemPurchase.Amount = Convert.ToDecimal(row["Amount"]);
                                //InvItemPurchase.Amount = Convert.ToDecimal(row["Total"]);
                                InvItemPurchase.RefStatus = true;

                                int no = InvItemPurchase.DetailsUpdateData();
                            }

                            if (txtMode.Text.Trim() == "Insert")
                                msg = "New Purchase Item Entered Successfully.";
                            else
                                msg = "Purchase Item Updated Successfully.";

                            if (i > 0)
                            {
                                MessageBox.Show(msg);
                                ClearData();
                                //Itemgridpopulate(rowHit);
                                clsInvCommon.populatePurchaseMaster(InvItemPurchaseMaster, purchaseMaster1.tbl_PurchaseMaster,"","");
                            }
                            else
                            {
                                if (i == -1)
                                {
                                    MessageBox.Show("Sorry!!! Duplicate Invoice No Found.");
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
                        else
                        {
                            MessageBox.Show("Error In Saving! Please Enter The ItemName / Quantity");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void txtInvNo_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode== Keys.Escape)
            {
                if (InvItemValidation.IsEmptyValidate(txtInvNo.Text) == false)
                {
                    errorProvider1.SetError(cmbSupplier, "Please Provide Invoice No");
                    btnSave.Enabled = false;
                    txtInvDate.Focus();
                }
                else
                {
                    errorProvider1.SetError(cmbSupplier, "");
                    btnSave.Enabled = true;
                    txtInvDate.Focus();
                }
            }
        }

        private void txtInvNo_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtInvNo, "");
            btnSave.Enabled = true;
        }

        private void txtInvDate_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                if (InvItemValidation.IsEmptyValidate(txtInvDate.Text) == false)
                {
                    errorProvider1.SetError(txtInvDate, "Please Provide Invoice Date");
                    btnSave.Enabled = false;
                    txtInvDate.Focus();
                }
                else
                {
                    //DateTime StartDate = Convert.ToDateTime(InvclsGlobalValue.StartDate);
                    //DateTime EndDate = Convert.ToDateTime(InvclsGlobalValue.EndDate);
                    //DateTime InvDate = Convert.ToDateTime(txtInvDate.Text);

                    //if ((InvDate >= StartDate) && (InvDate <= EndDate))
                    //{
                    //    MyErrorProvider.Controls.Add((object)txtInvDate, "Invoice Date");
                    //    MyErrorProvider.SummaryMessage = "Inv Date Should Be Within The Following Periods" + "\n" + InvclsGlobalValue.StartDate + "-" + InvclsGlobalValue.EndDate;
                    //    txtInvDate.Focus();
                    //}
                    //else
                    //{
                        errorProvider1.SetError(txtInvDate, "");
                        btnSave.Enabled = true;
                        gridView1.Focus();
                   // }
                }
            }
        }

        private void txtInvDate_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtInvDate, "");
            btnSave.Enabled = true;
        }

        private void txtAdjustment_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAdjustment.Text.Trim() !="")
                {
                    string Total;
                    Total = gridView1.Columns["Total"].SummaryItem.SummaryValue.ToString();
                    //txtSubTotal.Text = ((Convert.ToDecimal(Total) + Convert.ToDecimal(txtAdjustment.Text)).ToString());
                    string[] subparam1 = {txtAdjustment.Text, txtdeliverycharge.Text, txtdiscount.Text };
                    string[] subparam2 = {"+", "+", "-"};

                    txtSubTotal.Text = clsInvCommon.CalculateTotalAmt(Total, subparam1, subparam2).ToString(); 
                    //((Convert.ToDecimal(Total) + Convert.ToDecimal(txtAdjustment.Text) + Convert.ToDecimal(txtdeliverycharge.Text) - Convert.ToDecimal(txtdiscount.Text)).ToString());

                    string[] param1 = {txtAdjustment.Text,txtVATAmt.Text,txtRoundedOff.Text,txtdeliverycharge.Text,txtdiscount.Text};
                    string[] param2 = {"+", "+", "-", "+", "-"};
                    txtTotalAmt.Text = clsInvCommon.CalculateTotalAmt(Total,param1,param2).ToString();
                }
                txtdeliverycharge.Focus();
            }
        }

        private void txtVATAmt_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtVATAmt.Text.Trim() != "")
                {
                    string Total;
                    Total = gridView1.Columns["Total"].SummaryItem.SummaryValue.ToString();

                    string[] param1 = { txtAdjustment.Text, txtVATAmt.Text, txtRoundedOff.Text,txtdeliverycharge.Text,txtdiscount.Text };
                    string[] param2 = { "+", "+", "-", "+", "-"};
                    txtTotalAmt.Text = clsInvCommon.CalculateTotalAmt(Total, param1, param2).ToString();
                }
                txtRemarks.Focus();
                //ChkRoundedOff.Focus();
            }
        }

        private void txtdeliverycharge_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtdeliverycharge.Text.Trim() != "")
                {
                    string Total;
                    Total = gridView1.Columns["Total"].SummaryItem.SummaryValue.ToString();

                    string[] subparam1 = { txtAdjustment.Text, txtdeliverycharge.Text, txtdiscount.Text };
                    string[] subparam2 = { "+", "+", "-" };

                    txtSubTotal.Text = clsInvCommon.CalculateTotalAmt(Total, subparam1, subparam2).ToString(); 


                    string[] param1 = { txtAdjustment.Text, txtVATAmt.Text, txtRoundedOff.Text, txtdeliverycharge.Text,txtdiscount.Text};
                    string[] param2 = { "+", "+", "-", "+", "-"};
                    txtTotalAmt.Text = clsInvCommon.CalculateTotalAmt(Total, param1, param2).ToString();
                }
                txtdiscount.Focus();
            }
        }

        private void txtdiscount_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Enter)
            {
                if (txtdiscount.Text.Trim() != "")
                {
                    string Total;
                    Total = gridView1.Columns["Total"].SummaryItem.SummaryValue.ToString();

                    string[] subparam1 = { txtAdjustment.Text, txtdeliverycharge.Text, txtdiscount.Text };
                    string[] subparam2 = { "+", "+", "-" };

                    txtSubTotal.Text = clsInvCommon.CalculateTotalAmt(Total, subparam1, subparam2).ToString(); 


                    string[] param1 = { txtAdjustment.Text, txtVATAmt.Text, txtRoundedOff.Text, txtdeliverycharge.Text, txtdiscount.Text };
                    string[] param2 = { "+", "+", "-", "+", "-" };
                    txtTotalAmt.Text = clsInvCommon.CalculateTotalAmt(Total, param1, param2).ToString();
                }
                txtVATAmt.Focus();
            }
        }

        
        private void ChkRoundedOff_CheckedChanged(object sender, EventArgs e)
        {
            string Total;
            decimal oPurchasedAmt = 0;
            decimal PurchasedAmt = 0;
            decimal roundedamt = 0;
            decimal orgrndamt = 0;


            Total = gridView1.Columns["Total"].SummaryItem.SummaryValue.ToString();
            string[] param1 = { txtAdjustment.Text, txtVATAmt.Text,txtdeliverycharge.Text,txtdiscount.Text };
            string[] param2 = { "+", "+", "+", "-"};

            PurchasedAmt = clsInvCommon.CalculateTotalAmt(Total, param1, param2);
            oPurchasedAmt = PurchasedAmt;

            if (ChkRoundedOff.Checked)
            {
                roundedamt = clsInvCommon.ToRoundedAmount(PurchasedAmt); //.28
                orgrndamt = roundedamt;  //.28

                txtRoundedOff.Text = roundedamt.ToString();

                if (roundedamt < 50)
                    PurchasedAmt = Convert.ToInt32(PurchasedAmt);
                else
                    PurchasedAmt = Convert.ToInt32(PurchasedAmt)+1;
            }
            else
            {
                txtRoundedOff.Text = "";
                PurchasedAmt = oPurchasedAmt;
            }
            txtTotalAmt.Text = PurchasedAmt.ToString();
            txtRemarks.Focus();
        }

        private void txtRemarks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btnSave.Focus();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
            clsInvCommon.populatePurchaseMaster(InvItemPurchaseMaster, purchaseMaster1.tbl_PurchaseMaster, "", "");
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemMaster ItemMasterInItemPurchase = new ItemMaster();
            ItemMasterInItemPurchase.CallMenuFrom = "ItemPurchase";
//            ItemMasterInItemPurchase.gridRowHandle = gridView1.SelectRow(gridView1.FocusedRowHandle).;
            ItemMasterInItemPurchase.Location = new Point(260, 110);
            ItemMasterInItemPurchase.Show();
        }

        private void txtSearchInvNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
                CmdSearch.Focus();
        }

        private void txtSearchInvNo_Click(object sender, EventArgs e)
        {
            if (txtSearchInvNo.Enabled == false)
            {
                txtSearchInvNo.Enabled = true;
                cmbSrchSupplier.Enabled =false;
            }
        }
        
        private void CmdSearch_Click(object sender, EventArgs e)
        {
            
            cleargridData();

            if (InvItemValidation.IsEmptyValidate(txtSearchInvNo.Text) == true)
            {
                clsInvCommon.populatePurchaseMaster(InvItemPurchaseMaster, purchaseMaster1.tbl_PurchaseMaster, txtSearchInvNo.Text,"");

//                gridView1.Columns["InvoiceNo"].FilterMode = DevExpress.XtraGrid.ColumnFilterMode
//                gridView1.ActiveFilterString = "[InvoiceNo] = " + txtSearchInvNo.Text.Trim();
//                gridView1.ActiveFilter.fi = "[InvoiceNo]= '" + txtSearchInvNo.Text.Trim() + "'";

//                GridColumn columnInvNo = gridView1.Columns["InvoiceNo"];
//                columnInvNo.FilterInfo = new ColumnFilterInfo("[InvoiceNo]='4545'");

            }
            else
                clsInvCommon.populatePurchaseMaster(InvItemPurchaseMaster, purchaseMaster1.tbl_PurchaseMaster, "",getSupplierID.ToString());

        }

        private void cleargridData()
        {
            for (int i1 = gridView2.RowCount; i1 >= 0; i1--)
                gridView2.DeleteRow(i1);
        }

        private void ChkOpt_CheckedChanged(object sender,  EventArgs e)
        {
            if (ChkOpt.Checked == true)
            {
                cmbSrchSupplier.Enabled = true;
                txtSearchInvNo.Enabled = false;
                txtSearchInvNo.Text = "";
                cmbSrchSupplier.Focus();
            }
            else
            {
                cmbSrchSupplier.ItemIndex = -1;
                cmbSrchSupplier.Enabled = false;
                txtSearchInvNo.Enabled = true;
                txtSearchInvNo.Focus();
            }
        }

        private void cmbSrchSupplier_EditValueChanged(object sender, EventArgs e)
        {
            getSupplierID = Convert.ToInt16(cmbSrchSupplier.GetColumnValue("SupplierID"));
        }

        private void cmbSrchSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
                CmdSearch.Focus();
            
        }

        private void repositoryItemLookUpEdit1_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
        {
            if (MessageBox.Show(this, "Add the '" + e.DisplayValue.ToString() +
              "' entry to the list?",
              "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
/*                (repositoryItemLookUpEdit1.Properties.DataSource as ContactList).Add(
                  new Contact(e.DisplayValue.ToString()));
                e.Handled = true; */
               // repositoryItemLookUpEdit1.DataSource = clsInvCommon.populateItemMasterForGrid(InvItemPurchaseMaster, "ItemMaster");



                GridView view = gridControl1.FocusedView as GridView;

                view.SetRowCellValue(view.FocusedRowHandle, view.Columns["UnitName"], "PCS");
                view.SetRowCellValue(view.FocusedRowHandle, view.Columns["Amount"], 200);
                view.SetRowCellValue(view.FocusedRowHandle, view.Columns["ItemNo"], "1001");
                view.SetRowCellValue(view.FocusedRowHandle, view.Columns["Qty"], 1);

            }
        }



    }
}