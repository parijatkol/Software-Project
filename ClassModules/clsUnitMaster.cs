using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace inventory_control
{
    class clsUnitMaster
    {
         #region  Private Varibles UnitMaster

        clsGlobalValue InvclsGlobalValue = new clsGlobalValue();
        DataAccessLayer InvDataAccessLayer = new DataAccessLayer();
        DataSet ds = new DataSet();
        
        private int _UnitID = 0;
        private string _UnitName = string.Empty;
        private bool _Status = false;
        private int _UserLoginID = 0;
        private DateTime _EntryDate = DateTime.Now;
        private string _Mode = string.Empty;
        #endregion

        #region Public Properties  UnitMaster

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

        #region Public Methods  UnitMaster

        public int UpdateData()
        {
            SqlParameter[] param =
                {
                    new SqlParameter("@UnitID",SqlDbType.Int),
                    new SqlParameter("@UnitName",SqlDbType.NVarChar,10),
                    new SqlParameter("@Status",SqlDbType.Bit), 
                    new SqlParameter("@UserLoginID",SqlDbType.Int), 
                    new SqlParameter("@EntryDate",SqlDbType.DateTime), 
                    new SqlParameter("@Mode",SqlDbType.NVarChar,10),
                };

            param[0].Value = _UnitID;
            param[1].Value = _UnitName;
            param[2].Value = _Status;
            param[3].Value = _UserLoginID;
            param[4].Value = _EntryDate;
            param[5].Value = _Mode;

            int i = InvDataAccessLayer.InsertUpdateDeleteData("SP_UnitMasterUpdate", param);
            return i;
        }

        public bool RetrieveData(int UnitID)
        {
            string strSQL = String.Empty;

            strSQL = "select * from tbl_UnitMaster where Status=1 and UnitID=" + UnitID;

            ds = InvDataAccessLayer.PopulateDataSet(strSQL, "UnitMaster");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    _UnitName = (row["UnitName"].ToString());
                }
                return true;
            }
            else
                return false;
            //ds.Dispose();
        }

        public int DeleteUnitMaster()
        {
            int i = 0;

            SqlParameter[] param =
                {
                    new SqlParameter("@UnitID",SqlDbType.Int),
                    new SqlParameter("@Mode",SqlDbType.NVarChar,10)                
                };

            param[0].Value = _UnitID;
            param[1].Value = _Mode;
            i = InvDataAccessLayer.InsertUpdateDeleteData("SP_UnitMasterDelete", param);
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
