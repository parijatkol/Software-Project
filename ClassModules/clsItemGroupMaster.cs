using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace inventory_control
{
    class clsItemGroupMaster
    {
        #region  Private Varibles ItemGroupMaster

        clsGlobalValue InvclsGlobalValue = new clsGlobalValue();
        DataAccessLayer InvDataAccessLayer = new DataAccessLayer();
        DataSet ds = new DataSet();
        
        private int _ItemGroupCode = 0;
        private string _ItemGroupName = string.Empty;
        private string _ItemGroupDesc = string.Empty;
        private bool _Status = false;
        private int _UserLoginID = 0;
        private DateTime _EntryDate = DateTime.Now;
        private string _Mode = string.Empty;
        #endregion

        #region Public Properties  ItemGroupMaster

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
        public string ItemGroupDesc
        {
            set
            {
                _ItemGroupDesc = value;
            }
            get
            {
                return _ItemGroupDesc;
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
        #endregion

        #region Public Methods  ItemGroupMaster

        public int UpdateData()
        {
            SqlParameter[] param =
                {
                    new SqlParameter("@ItemGroupCode",SqlDbType.NVarChar,25),
                    new SqlParameter("@ItemGroupName",SqlDbType.NVarChar,25),
                    new SqlParameter("@ItemGroupDesc",SqlDbType.NVarChar,255),
                    new SqlParameter("@Status",SqlDbType.Bit), 
                    new SqlParameter("@UserLoginID",SqlDbType.Int), 
                    new SqlParameter("@EntryDate",SqlDbType.DateTime), 
                    new SqlParameter("@Mode",SqlDbType.NVarChar,10),
                };

            param[0].Value = _ItemGroupCode;
            param[1].Value = _ItemGroupName;
            param[2].Value = _ItemGroupDesc;
            param[3].Value = _Status;
            param[4].Value = _UserLoginID;
            param[5].Value = _EntryDate;
            param[6].Value = _Mode;

            int i = InvDataAccessLayer.InsertUpdateDeleteData("SP_ItemGroupMasterUpdate", param);
            return i;
        }

        public bool RetrieveData(int ItemGroupCode)
        {
            string strSQL = String.Empty;

            strSQL = "select * from tbl_ItemGroupMaster where Status=1 and ItemGroupCode=" + ItemGroupCode;

            ds = InvDataAccessLayer.PopulateDataSet(strSQL, "ItemGroupMaster");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    _ItemGroupName = (row["ItemGroupName"].ToString());
                    _ItemGroupDesc = (row["ItemGroupDesc"].ToString());
                }
                return true;
            }
            else
                return false;
            //ds.Dispose();
        }

        public int DeleteGroupMaster()
        {
            int i = 0;

            SqlParameter[] param =
                {
                    new SqlParameter("@ItemGroupCode",SqlDbType.Int),
                    new SqlParameter("@Mode",SqlDbType.NVarChar,10)                
                };

            param[0].Value = _ItemGroupCode;
            param[1].Value = _Mode;
            i = InvDataAccessLayer.InsertUpdateDeleteData("SP_GroupMasterDelete", param);
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

        #endregion
    }

}
