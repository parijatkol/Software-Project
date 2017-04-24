using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;


namespace inventory_control
{
    class Commons
    {
        SqlDataAdapter MyDataAdapter = new SqlDataAdapter();
        clsGlobalValue MyValues = new clsGlobalValue();
        
        public void populateBrandMaster(DataAccessLayer MyDataLayer, DataTable myDataTable)
        {
            string strSQL = "select '' AS BrandID,'' AS BrandCode,'' AS BrandName from tbl_BrandMaster where Status=1 union "; 
                   strSQL += "select BrandID,BrandCode,BrandName from tbl_BrandMaster where Status=1";
            
            MyDataAdapter = MyDataLayer.PopulateData(strSQL);
            MyDataAdapter.Fill(myDataTable);
        }

        public void populateItemGroupMaster(DataAccessLayer MyDataLayer, DataTable myDataTable)
        {
            string strSQL = "select -1 AS ItemGroupCode,'' AS ItemGroupName from tbl_ItemGroupMaster where Status=1 union "; 
                   strSQL += "select ItemGroupCode,ItemGroupName from tbl_ItemGroupMaster where Status=1";
            MyDataAdapter = MyDataLayer.PopulateData(strSQL);
            MyDataAdapter.Fill(myDataTable);
        }

        public void populateUnitMaster(DataAccessLayer MyDataLayer, DataTable myDataTable)
        {
            string strSQL = "select -1 AS UnitID,'' AS UnitName from tbl_UnitMaster where Status=1 union "; 
                   strSQL += "select UnitID,UnitName from tbl_UnitMaster where Status=1";
            MyDataAdapter = MyDataLayer.PopulateData(strSQL);
            MyDataAdapter.Fill(myDataTable);
        }

        public void populateSupplierMaster(DataAccessLayer MyDataLayer, DataTable myDataTable)
        {
            string strSQL = "select -1 AS SupplierID,'' AS SupplierName from tbl_Suppliers where Status=1 union ";
            strSQL += "select SupplierID,SupplierName from tbl_Suppliers where Status=1";
            MyDataAdapter = MyDataLayer.PopulateData(strSQL);
            MyDataAdapter.Fill(myDataTable);
        }

        public void populateCustomerMaster(DataAccessLayer MyDataLayer, DataTable myDataTable)
        {
            string strSQL = "select -1 AS CustomerID,'' AS CustomerName from tbl_Customers where Status=1 union ";
            strSQL += "select CustomerID,CustomerName from tbl_Customers where Status=1";
            MyDataAdapter = MyDataLayer.PopulateData(strSQL);
            MyDataAdapter.Fill(myDataTable);
        }

        public DataTable populateItemMasterForGrid(DataAccessLayer MyDataLayer, string tblLookUp)
        {
            DataSet ds = new DataSet();
            string strSQL = "select -1 AS ItemNo,'' as ItemCode,'' AS ItemName,0 as Amount from tbl_ItemMaster where Status=1 union ";
            strSQL += "select ItemNo, ItemCode, ItemName, UnitPrice as Amount from tbl_ItemMaster where Status=1";
            MyDataAdapter = MyDataLayer.PopulateData(strSQL);
            MyDataAdapter.Fill(ds, tblLookUp);
            return ds.Tables[tblLookUp];
        }

        public DataSet populatePurchaseMasterDetailsRelationInGrid(int rec, DataAccessLayer MyDataLayer, string tblGrid)
        {
            DataSet ds = new DataSet();
            //string strSQL = "select b.ItemCode,b.ItemName,Amount,Qty,a.ItemNo,b.UnitName from tbl_PurchaseDetail a ";
              //     strSQL += "inner join tbl_PurchaseMaster c on c.PurchaseID = a.PurchaseID ";
              //      strSQL += "inner join tbl_ItemMaster b on a.ItemNo = b.ItemNo where a.PurchaseID = " + rec + " and a.Status=1 and c.FinancialYrID =" + MyValues.FinYearID;

            string strSQL = "select b.ItemCode,b.ItemName,Amount,Qty,a.ItemNo,d.UnitName from tbl_PurchaseDetail a ";
                 strSQL += "inner join tbl_PurchaseMaster c on c.PurchaseID = a.PurchaseID ";
                 strSQL += "inner join tbl_ItemMaster b on a.ItemNo = b.ItemNo ";
                 strSQL += "inner join tbl_Unitmaster d on d.UnitID = b.UnitID where a.PurchaseID = " + rec + " and a.Status=1 and c.FinancialYrID =" + MyValues.FinYearID;

            
            MyDataAdapter = MyDataLayer.PopulateData(strSQL);
            MyDataAdapter.Fill(ds, tblGrid);
            return ds;
        }

        public void populatePurchaseMaster(DataAccessLayer MyDataLayer, DataTable myDataTable, string invno,string suppid)
        {
            string strSQL ;
            if (invno !="")            
                strSQL = "select PurchaseID,InvoiceNo, CONVERT(char(10), InvoiceDate, 105) as InvoiceDate from tbl_PurchaseMaster where Status=1 and FinancialYrID =" + MyValues.FinYearID + " and InvoiceNo='" + invno + "'" ;
            else if(suppid !="" && Convert.ToInt16(suppid)>0)
                strSQL = "select PurchaseID,InvoiceNo, CONVERT(char(10), InvoiceDate, 105) as InvoiceDate from tbl_PurchaseMaster where Status=1 and FinancialYrID =" + MyValues.FinYearID + " and SupplierID=" + suppid;            
            else
                strSQL = "select PurchaseID,InvoiceNo, CONVERT(char(10), InvoiceDate, 105) as InvoiceDate from tbl_PurchaseMaster where Status=1 and FinancialYrID =" + MyValues.FinYearID;

            MyDataAdapter.Dispose();
            MyDataAdapter = MyDataLayer.PopulateData(strSQL);
            MyDataAdapter.Fill(myDataTable);
        }

        public DataSet populateIssueMasterDetailsRelationInGrid(int rec, DataAccessLayer MyDataLayer, string tblGrid)
        {
            DataSet ds = new DataSet();
            //string strSQL = "select b.ItemCode,b.ItemName,Amount,Qty,a.ItemNo,b.UnitName from tbl_PurchaseDetail a ";
            //     strSQL += "inner join tbl_PurchaseMaster c on c.PurchaseID = a.PurchaseID ";
            //      strSQL += "inner join tbl_ItemMaster b on a.ItemNo = b.ItemNo where a.PurchaseID = " + rec + " and a.Status=1 and c.FinancialYrID =" + MyValues.FinYearID;

            string strSQL = "select b.ItemCode,b.ItemName,Amount,Qty,a.ItemNo,d.UnitName from tbl_IssueDetails a ";
            strSQL += "inner join tbl_IssueMaster c on c.IssueID = a.IssueID ";
            strSQL += "inner join tbl_ItemMaster b on a.ItemNo = b.ItemNo ";
            strSQL += "inner join tbl_Unitmaster d on d.UnitID = b.UnitID where a.IssueID = " + rec + " and a.Status=1 and c.FinancialYrID =" + MyValues.FinYearID;


            MyDataAdapter = MyDataLayer.PopulateData(strSQL);
            MyDataAdapter.Fill(ds, tblGrid);
            return ds;
        }
        public void populateIssueMaster(DataAccessLayer MyDataLayer, DataTable myDataTable, string invno, string custid)
        {
            string strSQL;
            if (invno != "")
                strSQL = "select IssueID,InvoiceNo, CONVERT(char(10), InvoiceDate, 105) as InvoiceDate from tbl_IssueMaster where Status=1 and FinancialYrID =" + MyValues.FinYearID + " and InvoiceNo='" + invno + "'";
            else if (custid != "" && Convert.ToInt16(custid) > 0)
                strSQL = "select IssueID,InvoiceNo, CONVERT(char(10), InvoiceDate, 105) as InvoiceDate from tbl_IssueMaster where Status=1 and FinancialYrID =" + MyValues.FinYearID + " and SupplierID=" + custid;
            else
                strSQL = "select IssueID,InvoiceNo, CONVERT(char(10), InvoiceDate, 105) as InvoiceDate from tbl_IssueMaster where Status=1 and FinancialYrID =" + MyValues.FinYearID;

            MyDataAdapter.Dispose();
            MyDataAdapter = MyDataLayer.PopulateData(strSQL);
            MyDataAdapter.Fill(myDataTable);
        }

        public void ChangeCurrencyFormat(string symbol)
        {
            CultureInfo culture = new CultureInfo("en-US", true);
            culture.NumberFormat.CurrencySymbol = " " + symbol;
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            DevExpress.Utils.FormatInfo.AlwaysUseThreadFormat = true;
        }


        public decimal CalculateTotalAmt(string invTotal,string[] Params1,string[] Params2)
        {
            decimal Total = 0;
            decimal val = 0;

            Total = Convert.ToDecimal(invTotal);
            for (int i = 0; i < Params1.Length;i++)
            {
                if (Params1[i] == "")
                    val = 0;
                else
                    val = Convert.ToDecimal(Params1[i]);

                if (Params2[i] == "+")
                    Total = Total + val;
                else if (Params2[i] == "-")
                    Total = Total - val;
            }
            return Total;    
        }

        public decimal ToRoundedAmount(decimal val)
        {
            decimal fractionalValue = val - Decimal.Truncate(val);            

/*            if (fractionalValue < 50)
                val = Convert.ToInt32(val);
            else
                val = Convert.ToInt32(val) + 1; */

            return fractionalValue;
        }


        public bool  CheckGridItem(GridView view,string column1,string column2)
        {
            bool flag = false;

            for (int k = 0; k < view.RowCount; k++)
            {
                DataRow row = view.GetDataRow(k);

                if (row[column1] == "" && row[column2] == "")
                {
                    flag = false;
                    break;
                }
                else
                    flag = true;
            }

            return flag;
        }

    }

    public class PersonInfo
    {
        private string _firstName;
        private string _lastName;

        public PersonInfo(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public override string ToString()
        {
            return _firstName + " " + _lastName;
        }
    }
}
