using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace inventory_control
{
    class clsItemPurchase
    {
        #region  Private Varibles ItemPurchase

        clsGlobalValue InvclsGlobalValue = new clsGlobalValue();
        DataAccessLayer InvDataAccessLayer = new DataAccessLayer();

        DataSet ds = new DataSet();

        //================== Purchase Master ====================//

        private int _PurchaseID = 0;
        private string _InvoiceNo = string.Empty;
        private DateTime _InvoiceDate = DateTime.Now;
        private int _SupplierID = 0;
        private int _SupplierIDItemIndex = 0;
        private decimal _TotalAmt = 0;
        private int _FinancialYrID = 0;
        private string _PaymentMode = string.Empty;
        private string _Cheque_DD_No = string.Empty;
        private DateTime _Cheque_DD_Date = DateTime.Now;
        private string _Cheque_DD_Bank = string.Empty;
        private string _Remarks = string.Empty;
        private decimal _Adjustments=0;
        private decimal _deliverycharges = 0;
        private decimal _discount = 0;
        private decimal _VatAmt = 0;
        private decimal _RoundedAmt = 0;
        private bool _Status = true;
        private int _UserLoginID = 0;
        private DateTime _EntryDate = DateTime.Now;
        private string _Mode = string.Empty;


        //========================================================//

        //================== Purchase Detail ====================//

        private int _DetailsID = 0;
        private int _RefPurchaseID = 0;
        private int _ItemNo = 0;
        private int _Qty = 0;
        private decimal _Amount = 0;
        private bool _refStatus = true;

       //========================================================//

       //================== Supplier Details ====================//

        private string _Address = string.Empty;
        private string _phone = string.Empty;
        private string _CSTNo = string.Empty;
        private string _VATNo = string.Empty;

       //========================================================//

        #endregion


        #region Public Properties  PurchaseMaster

        public int PurchaseID
        {
            set
            {
                _PurchaseID = value;
            }
            get
            {
                return _PurchaseID;
            }
        }
        public string InvoiceNo
        {
            set
            {
                _InvoiceNo = value;
            }
            get
            {
                return _InvoiceNo;
            }
        }
        public DateTime InvoiceDate
        {
            set
            {
                _InvoiceDate = value;
            }
            get
            {
                return _InvoiceDate;
            }
        }
        public int SupplierID
        {
            set
            {
                _SupplierID = value;
            }
            get
            {
                return _SupplierID;
            }
        }
        public int SupplierIDItemIndex
        {
            set
            {
                _SupplierIDItemIndex = value;
            }
            get
            {
                return _SupplierIDItemIndex;
            }
        }
        public decimal TotalAmt
        {
            set
            {
                _TotalAmt = value;
            }
            get
            {
                return _TotalAmt;
            }
        }
        public int FinancialYrID
        {
            set
            {
                _FinancialYrID = value;
            }
            get
            {
                return _FinancialYrID;
            }
        }
        public string PaymentMode
        {
            set
            {
                _PaymentMode = value;
            }
            get
            {
                return _PaymentMode;
            }
        }
        public string Cheque_DD_No
        {
            set
            {
                _Cheque_DD_No = value;
            }
            get
            {
                return _Cheque_DD_No;
            }
        }
        public DateTime Cheque_DD_Date
        {
            set
            {
                _Cheque_DD_Date = value;
            }
            get
            {
                return _Cheque_DD_Date;
            }
        }
        public string Cheque_DD_Bank
        {
            set
            {
                _Cheque_DD_Bank = value;
            }
            get
            {
                return _Cheque_DD_Bank;
            }
        }
        public string Remarks
        {
            set
            {
                _Remarks = value;
            }
            get
            {
                return _Remarks;
            }
        }
        public decimal Adjustments
        {
            set
            {
                _Adjustments = value;
            }
            get
            {
                return _Adjustments;
            }
        }
        public decimal deliverycharges
        {
            set
            {
                _deliverycharges = value;
            }
            get
            {
                return _deliverycharges;
            }
        }
        public decimal discount
        {
            set
            {
                _discount = value;
            }
            get
            {
                return _discount;
            }
        }
        public decimal VatAmt
        {
            set
            {
                _VatAmt = value;
            }
            get
            {
                return _VatAmt;
            }
        }
        public decimal RoundedAmt
        {
            set
            {
                _RoundedAmt = value;
            }
            get
            {
                return _RoundedAmt;
            }
        }
        public bool Status
        {
            set
            {
                _Status = value;
            }
            get
            {
                return _Status;
            }
        }
        public int UserLoginID
        {
            set
            {
                _UserLoginID = value;
            }
            get
            {
                return _UserLoginID;
            }
        }
        public DateTime EntryDate
        {
            set
            {
                _EntryDate = value;
            }
            get
            {
                return _EntryDate;
            }
        }
        public string Mode
        {
            set
            {
                _Mode = value;
            }
            get
            {
                return _Mode;
            }
        }


        public int DetailsID
        {
            set
            {
                _DetailsID = value;
            }
            get
            {
                return _DetailsID;
            }
        }
        public int RefPurchaseID
        {
            set
            {
                _RefPurchaseID = value;
            }
            get
            {
                return _RefPurchaseID;
            }
        }
        public int ItemNo
        {
            set
            {
                _ItemNo = value;
            }
            get
            {
                return _ItemNo;
            }
        }
        public int Qty
        {
            set
            {
                _Qty = value;
            }
            get
            {
                return _Qty;
            }
        }
        public decimal Amount
        {
            set
            {
                _Amount = value;
            }
            get
            {
                return _Amount;
            }
        }
        public bool RefStatus
        {
            set
            {
                _refStatus = value;
            }
            get
            {
                return _refStatus;
            }
        }

        public string Address
        {
            set
            {
                _Address = value;
            }
            get
            {
                return _Address;
            }
        }

        public string Phone
        {
            set
            {
                _phone = value;
            }
            get
            {
                return _phone;
            }
        }

        public string CSTNo
        {
            set
            {
                _CSTNo = value;
            }
            get
            {
                return _CSTNo;
            }
        }

        public string VATNo
        {
            set
            {
                _VATNo = value;
            }
            get
            {
                return _VATNo;
            }
        }


        #endregion

        #region Public Methods  PurchaseMaster

        public int MasterUpdateData()
        {
            SqlParameter[] param =
                {
                    new SqlParameter("@PurchaseID",SqlDbType.Int),
                    new SqlParameter("@InvoiceNo",SqlDbType.NVarChar,50),
                    new SqlParameter("@InvoiceDate",SqlDbType.DateTime),
                    new SqlParameter("@SupplierID",SqlDbType.Int),
                    new SqlParameter("@SupplierIDItemIndex",SqlDbType.Int),
                    new SqlParameter("@TotalAmt",SqlDbType.Decimal),
                    new SqlParameter("@FinancialYrID",SqlDbType.Int),
                    new SqlParameter("@PaymentMode",SqlDbType.NVarChar,10),
                    new SqlParameter("@Cheque_DD_No",SqlDbType.NVarChar,20),
                    new SqlParameter("@Cheque_DD_Date",SqlDbType.DateTime),
                    new SqlParameter("@Cheque_DD_Bank",SqlDbType.NVarChar,20),
                    new SqlParameter("@Remarks",SqlDbType.Text),
                    new SqlParameter("@Adjustments",SqlDbType.Decimal),
                    new SqlParameter("@deliverycharges",SqlDbType.Decimal),
                    new SqlParameter("@discount",SqlDbType.Decimal),
                    new SqlParameter("@VatAmt",SqlDbType.Decimal),
                    new SqlParameter("@RoundedAmt",SqlDbType.Decimal),
                    new SqlParameter("@Status",SqlDbType.Bit),
                    new SqlParameter("@UserLoginID",SqlDbType.Int),
                    new SqlParameter("@EntryDate",SqlDbType.DateTime),
                    new SqlParameter("@Mode",SqlDbType.NVarChar,10)
                };

            param[0].Value = _PurchaseID;
            param[1].Value = _InvoiceNo;
            param[2].Value = _InvoiceDate;
            param[3].Value = _SupplierID;
            param[4].Value = _SupplierIDItemIndex;
            param[5].Value = _TotalAmt;
            param[6].Value = _FinancialYrID;
            param[7].Value = _PaymentMode;
            param[8].Value = _Cheque_DD_No;
            param[9].Value = _Cheque_DD_Date;
            param[10].Value = _Cheque_DD_Bank;
            param[11].Value = _Remarks;
            param[12].Value = _Adjustments;
            param[13].Value = _deliverycharges;
            param[14].Value = _discount;

            param[15].Value = _VatAmt;
            param[16].Value = _RoundedAmt;

            param[17].Value = _Status;
            param[18].Value = _UserLoginID;
            param[19].Value = _EntryDate; ;
            param[20].Value = _Mode;

            int i = InvDataAccessLayer.InsertUpdateDeleteData("SP_ItemPurchaseMasterUpdate", param);
            return i;
        }

        public int DetailsUpdateData()
        {
            SqlParameter[] param =
                {
                    new SqlParameter("@DetailsID",SqlDbType.Int),
                    new SqlParameter("@RefPurchaseID",SqlDbType.Int),
                    new SqlParameter("@ItemNo",SqlDbType.Int),
                    new SqlParameter("@Qty",SqlDbType.Int),
                    new SqlParameter("@Amount",SqlDbType.Decimal),
                    new SqlParameter("@RefStatus",SqlDbType.Bit),
                    new SqlParameter("@Mode",SqlDbType.NVarChar,10)
                };

            param[0].Value = _DetailsID;
            param[1].Value = _RefPurchaseID;
            param[2].Value = _ItemNo;
            param[3].Value = _Qty;
            param[4].Value = _Amount;
            param[5].Value = _refStatus;
            param[6].Value = _Mode;

            int i = InvDataAccessLayer.InsertUpdateDeleteData("SP_ItemPurchaseDetailUpdate", param);
            return i;
        }

        public void DeletePurchaseDetails()
        {
                SqlParameter[] param =
                {
                    new SqlParameter("@RefPurchaseID",SqlDbType.Int),
                    new SqlParameter("@Mode",SqlDbType.NVarChar,10)                
                };

                param[0].Value = _PurchaseID;
                param[1].Value = "Delete";
                InvDataAccessLayer.InsertUpdateDeleteData("SP_ItemPurchaseDetailDelete", param);
        }


        //public int UpdateStatus()
        //{
        //    SqlParameter[] param =
        //        {
        //            new SqlParameter("@AcctPeriod",SqlDbType.NVarChar,4),
        //            new SqlParameter("@Status",SqlDbType.Bit), 
        //            new SqlParameter("@Mode",SqlDbType.NVarChar,20),
        //        };
        //    param[0].Value = _AcctPeriod;
        //    param[1].Value = _Status;
        //    param[2].Value = _Mode;
        //    int i = InvDataAccessLayer.InsertUpdateDeleteData("SP_FinancialYearUpdate", param);
        //    return i;
        //}

        public bool RetrieveData(int PurchaseID)
        {
            string strSQL = String.Empty;

            strSQL = "select a.SupplierID,SupplierIDItemIndex,a.TotalAmt,a.VatAmt,a.Adjustments,isnull(a.deliverycharges,0) as deliverycharges,isnull(a.discount,0) as discount,a.RoundedAmt,a.Remarks,a.InvoiceNo, ";
            strSQL += "a.InvoiceDate,b.Address1,b.CST,b.VAT,b.Phone1 from tbl_PurchaseMaster a inner join ";
            strSQL += "tbl_Suppliers b on a.SupplierID= b.SupplierID where a.PurchaseID=" + PurchaseID + " and a.Status=1 and b.Status=1" ;
            
            ds = InvDataAccessLayer.PopulateDataSet(strSQL, "PurchaseMaster");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    _SupplierID =Convert.ToInt16(row["SupplierID"]);
                    _SupplierIDItemIndex = Convert.ToInt16(row["SupplierIDItemIndex"]);
                    _InvoiceNo = row["InvoiceNo"].ToString();
                    _InvoiceDate =Convert.ToDateTime(row["InvoiceDate"]);
                    _Remarks = row["Remarks"].ToString();
                    _Adjustments = Convert.ToDecimal(row["Adjustments"].ToString());
                    _deliverycharges = Convert.ToDecimal(row["deliverycharges"].ToString());
                    _discount = Convert.ToDecimal(row["discount"].ToString());
                    _VatAmt = Convert.ToDecimal(row["VatAmt"]);
                    _RoundedAmt = Convert.ToDecimal(row["RoundedAmt"]);
                    _Address = row["Address1"].ToString();
                    _phone = row["Phone1"].ToString();
                    _CSTNo = row["CST"].ToString();
                    _VATNo = row["VAT"].ToString();
                    _TotalAmt =Convert.ToDecimal(row["TotalAmt"]);
                }
                return true;
            }
            else
                return false;
        }

        public DataSet RetrievePurchaseDetails(int PurchaseID)
        {
            string strSQL = String.Empty;
            strSQL = "select a.ItemNo,ItemName,ItemCode,Amount,Qty,UnitName from tbl_PurchaseDetail a inner join tbl_ItemMaster b";
            strSQL += " on a.ItemNo = b.ItemNo inner join tbl_UnitMaster c on c.UnitID = b.UnitID where PurchaseID=" + PurchaseID + " and a.Status=1 and b.Status=1 ";

            ds = InvDataAccessLayer.PopulateDataSet(strSQL, "PurchaseDetail");
            return ds;
        }

        #endregion
    }

}
