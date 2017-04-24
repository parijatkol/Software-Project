using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace inventory_control
{
    class clsBrandMaster
    {
        #region  Private Varibles BrandMaster

        clsGlobalValue InvclsGlobalValue = new clsGlobalValue();
        DataAccessLayer InvDataAccessLayer = new DataAccessLayer();

        DataSet ds = new DataSet();

        private int _BrandID = 0;
        private string _BrandCode = string.Empty;
        private string _BrandName = string.Empty;
        private string _BrandDesc = string.Empty;
        private bool _Status = false;
        private int _UserLoginID = 0;
        private DateTime _EntryDate = DateTime.Now;
        private string _Mode = string.Empty;
        #endregion

        #region Public Properties  BrancdMaster

        public int BrandID
        {
            set
            {
                _BrandID = value;
            }
            get
            {
                return _BrandID;
            }
        }
        public string BrandCode
        {
            set
            {
                _BrandCode = value;
            }
            get
            {
                return _BrandCode;
            }
        }
        public string BrandName
        {
            set
            {
                _BrandName = value;
            }
            get
            {
                return _BrandName;
            }
        }
        public string BrandDesc
        {
            set
            {
                _BrandDesc = value;
            }
            get
            {
                return _BrandDesc;
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
        #region Public Methods  BrandMaster

        public int UpdateData()
        {
            SqlParameter[] param =
                {
                    new SqlParameter("@BrandID",SqlDbType.Int),
                    new SqlParameter("@BrandCode",SqlDbType.NVarChar,20),
                    new SqlParameter("@BrandName",SqlDbType.NVarChar,50),
                    new SqlParameter("@BrandDesc",SqlDbType.NVarChar,100),
                    new SqlParameter("@Status",SqlDbType.Bit), 
                    new SqlParameter("@UserLoginID",SqlDbType.Int), 
                    new SqlParameter("@EntryDate",SqlDbType.DateTime), 
                    new SqlParameter("@Mode",SqlDbType.NVarChar,10),
                };

            param[0].Value = _BrandID;
            param[1].Value = _BrandCode;
            param[2].Value = _BrandName;
            param[3].Value = _BrandDesc;
            param[4].Value = _Status;
            param[5].Value = _UserLoginID;
            param[6].Value = _EntryDate;
            param[7].Value = _Mode;

            int i = InvDataAccessLayer.InsertUpdateDeleteData("SP_BrandMasterUpdate", param);
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

        public bool RetrieveData(int BrandID)
        {
            string strSQL = String.Empty;

            strSQL = "select * from tbl_Brandmaster where Status=1 and BrandID=" + BrandID;

            ds = InvDataAccessLayer.PopulateDataSet(strSQL, "BrandMaster");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    _BrandCode = (row["BrandCode"].ToString());
                    _BrandName = (row["BrandName"].ToString());
                    _BrandDesc = (row["BrandDesc"].ToString());
                }
                return true;
            }
            else
                return false;
            //ds.Dispose();
        }

        public int DeleteBrandMaster()
        {
            int i=0 ;

            SqlParameter[] param =
                {
                    new SqlParameter("@BrandID",SqlDbType.Int),
                    new SqlParameter("@Mode",SqlDbType.NVarChar,10)                
                };

            param[0].Value = _BrandID;
            param[1].Value = _Mode;
            i = InvDataAccessLayer.InsertUpdateDeleteData("SP_BrandMasterDelete", param);
            return i;
        }

        public string AutoGeneratedBrandCode()
        {
            string AutoID;
            string SQL = "SELECT ISNULL(RIGHT(REPLICATE('0',3) + CAST(MAX(CAST(BRANDCODE AS INT))+1 AS VARCHAR(4)),4),'0001') AS AUTOID FROM tbl_BrandMaster WHERE Status=1";
            AutoID = InvDataAccessLayer.AutoCode(SQL);
            return AutoID;
        }

        #endregion
    }
}
