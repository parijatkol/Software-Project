using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace inventory_control
{
    class clsCreateItemMaster
    {
        #region  Private Varibles ItemMaster

        clsGlobalValue InvclsGlobalValue = new clsGlobalValue();
        DataAccessLayer InvDataAccessLayer = new DataAccessLayer();

        DataSet ds = new DataSet();

        private int _ItemNo = 0;
        private string _ItemCode = string.Empty;
        private string _ItemName = string.Empty;
        private string _ItemDesc = string.Empty;
        private decimal  _UnitPrice = 0;
        private int _UnitID = 0;
        private int _UnitIDItemIndex=0;
        private int _ItemGroupCode = 0;
        private int _ItemGroupCodeItemIndex = 0;
        private int _ItemOpStock = 0;
        private int _ItemBrandId = 0;
        private int _ItemBrandIdItemIndex = 0;
        private bool _Status = false;
        private int _UserLoginID = 0;
        private string _ItemGroupName = string.Empty;
        private string _UnitName = string.Empty;
        private DateTime _EntryDate = DateTime.Now;
        private string _Mode = string.Empty;
        #endregion

        #region Public Properties  ItemMaster

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
        public string ItemCode
        {
            set
            {
                _ItemCode = value;
            }
            get
            {
                return _ItemCode;
            }
        }
        public string ItemName
        {
            set
            {
                _ItemName = value;
            }
            get
            {
                return _ItemName;
            }
        }
        public string ItemDesc
        {
            set
            {
                _ItemDesc = value;
            }
            get
            {
                return _ItemDesc;
            }
        }
        public decimal UnitPrice
        {
            set
            {
                _UnitPrice = value;
            }
            get
            {
                return _UnitPrice;
            }
        }
        public int UnitID
        {
            set
            {
                _UnitID = value;
            }
            get
            {
                return _UnitID;
            }
        }
        public int UnitIDItemIndex
        {
            set
            {
                _UnitIDItemIndex = value;
            }
            get
            {
                return _UnitIDItemIndex;
            }
        }
        public int ItemGroupCode
        {
            set
            {
                _ItemGroupCode = value;
            }
            get
            {
                return _ItemGroupCode;
            }
        }
        public int ItemGroupCodeItemIndex
        {
            set
            {
                _ItemGroupCodeItemIndex = value;
            }
            get
            {
                return _ItemGroupCodeItemIndex;
            }               
        }
        public int ItemOpStock
        {
            set
            {
                _ItemOpStock=value;
            }
            get
            {
                return _ItemOpStock;
            }
        }
        public int ItemBrandId
        {
            set
            {
                _ItemBrandId = value;
            }
            get
            {
                return _ItemBrandId;
            }
        }
        public int ItemBrandIdItemIndex
        {
            set
            {
                _ItemBrandIdItemIndex = value;
            }
            get
            {
                return _ItemBrandIdItemIndex;
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
        public string ItemGroupName
        {
            set
            {
                _ItemGroupName = value;
            }
            get
            {
                return _ItemGroupName;
            }
        }
        public string UnitName
        {
            set
            {
                _UnitName = value;
            }
            get
            {
                return _UnitName;
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

        #endregion

        #region Public Methods  ItemMaster

        public int UpdateData()
        {
            SqlParameter[] param =
                {
                    new SqlParameter("@ItemNo",SqlDbType.Int),
                    new SqlParameter("@ItemCode",SqlDbType.NVarChar,50),
                    new SqlParameter("@ItemName",SqlDbType.NVarChar,50),
                    new SqlParameter("@ItemDesc",SqlDbType.NVarChar,255),
                    new SqlParameter("@UnitPrice",SqlDbType.Decimal,10),
                    new SqlParameter("@UnitID",SqlDbType.Int),
                    new SqlParameter("@UnitIDItemIndex",SqlDbType.Int),
                    new SqlParameter("@ItemGroupCode",SqlDbType.Int),
                    new SqlParameter("@ItemGroupCodeItemIndex",SqlDbType.Int),
                    new SqlParameter("@OpStock",SqlDbType.Int),
                    new SqlParameter("@ItemBrandId",SqlDbType.Int),
                    new SqlParameter("@ItemBrandIdItemIndex",SqlDbType.Int),
                    new SqlParameter("@Status",SqlDbType.Bit), 
                    new SqlParameter("@LoginUserID",SqlDbType.Int), 
                    new SqlParameter("@EntryDate",SqlDbType.DateTime), 
                    new SqlParameter("@Mode",SqlDbType.NVarChar,10),
                };

            param[0].Value = _ItemNo;
            param[1].Value = _ItemCode;
            param[2].Value = _ItemName;
            param[3].Value = _ItemDesc;
            param[4].Value = _UnitPrice;
            param[5].Value = _UnitID;
            param[6].Value = _UnitIDItemIndex;
            param[7].Value = _ItemGroupCode;
            param[8].Value = _ItemGroupCodeItemIndex;
            param[9].Value = _ItemOpStock;
            param[10].Value = _ItemBrandId;
            param[11].Value = _ItemBrandIdItemIndex;
            param[12].Value = _Status;
            param[13].Value = _UserLoginID;
            param[14].Value = _EntryDate;
            param[15].Value = _Mode;

            int i = InvDataAccessLayer.InsertUpdateDeleteData("SP_ItemMasterUpdate", param);
            return i;
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

        public bool RetrieveData(int ItemNo)
        {
            string strSQL = String.Empty;

            strSQL = "select ItemNo,ItemCode,ItemName,ItemDesc,UnitPrice,a.BrandID,a.BrandIDItemIndex,a.UnitID,a.UnitIDItemIndex,a.ItemGroupCode,a.ItemGroupCodeItemIndex,OpStock,ItemGroupName,UnitName from tbl_ItemMaster a inner join ";
            strSQL += "tbl_UnitMaster b on a.UnitID =b.UnitID inner join tbl_ItemGroupMaster c on ";
            strSQL += "a.ItemGroupCode = c.ItemGroupCode where a.Status=1 and b.Status=1 and c.Status=1 and  a.ItemNo=" + ItemNo;

            ds = InvDataAccessLayer.PopulateDataSet(strSQL, "ItemMaster");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    _ItemCode = (row["ItemCode"].ToString());
                    _ItemName= (row["ItemName"].ToString());
                    _ItemDesc= (row["ItemDesc"].ToString());
                    _UnitPrice= (decimal) (row["UnitPrice"]);
                    _UnitID= (int) (row["UnitID"]);
                    _UnitIDItemIndex = (int) (row["UnitIDItemIndex"]);
                    _ItemGroupCode= (int) (row["ItemGroupCode"]);
                    _ItemGroupCodeItemIndex = (int) (row["ItemGroupCodeItemIndex"]);
                    _ItemOpStock  = (int) (row["OpStock"]);
                    _ItemBrandId = (int) (row["BrandID"]);
                    _ItemBrandIdItemIndex = (int)(row["BrandIDItemIndex"]);
                    _ItemGroupName = (row["ItemGroupName"].ToString());
                    _UnitName = (row["UnitName"].ToString());
                    _ItemOpStock  = (int) (row["OpStock"]);
                }
                return true;
            }
            else
                return false;
            //ds.Dispose();
        }

        public int DeleteItemMaster()
        {
            int i = 0;

            SqlParameter[] param =
                {
                    new SqlParameter("@ItemNo",SqlDbType.Int),
                    new SqlParameter("@Mode",SqlDbType.NVarChar,10)                
                };

            param[0].Value = _ItemNo;
            param[1].Value = _Mode;
            i = InvDataAccessLayer.InsertUpdateDeleteData("SP_ItemMasterDelete", param);
            return i;
        }

        public string AutoGeneratedItemCode()
        {
            string AutoID;
            string SQL = "SELECT ISNULL(RIGHT(REPLICATE('0',5) + CAST(MAX(CAST(ItemCode AS INT))+1 AS VARCHAR(6)),6),'000001') AS AUTOID FROM tbl_ItemMaster WHERE Status=1";
            AutoID = InvDataAccessLayer.AutoCode(SQL);
            return AutoID;
        }

        public int GetLastID()
        {
            int LastID;
            string SQL = "select top 1 itemno from tbl_itemmaster where Status=1 order by ItemNo desc";
            LastID = InvDataAccessLayer.GetLastID(SQL);
            return LastID;
        }

        #endregion
    }

}
