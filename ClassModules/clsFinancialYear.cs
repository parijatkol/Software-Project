using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace inventory_control
{
    class clsFinancialYear
    {
        #region  Private Varibles FinancialYear

        clsGlobalValue InvclsGlobalValue = new clsGlobalValue();
        DataAccessLayer InvDataAccessLayer = new DataAccessLayer();

        private int _FinancialYrID = 0;
        private string _StartDate = string.Empty; 
        private string _EndDate = string.Empty;
        private string _AcctPeriod = string.Empty;
        public bool _Status = false;
        private int _LoginUserID = 0;
        private DateTime _EntryDate = DateTime.Now;
        private string _Mode = string.Empty;
        #endregion

        #region Public Properties  FinancialYear

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
        public string StartDate
        {
            set
            {
                _StartDate = value;
            }
            get
            {
                return _StartDate;
            }
        }
        public string EndDate
        {
            set
            {
                _EndDate = value;
            }
            get
            {
                return _EndDate;
            }
        }

        public string AcctPeriod
        {
            set
            {
                _AcctPeriod = value;

            }
            get
            {
                return _AcctPeriod;
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

        public int LoginUserID
        {
            set
            {
                _LoginUserID = value;
            }
            get
            {
                return _LoginUserID;
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

        #region Public Methods  FinancialYear

        public int UpdateData()
        {
            SqlParameter[] param =
                {
                    new SqlParameter("@StartDate",SqlDbType.Date,10),
                    new SqlParameter("@EndDate",SqlDbType.Date,10),
                    new SqlParameter("@AcctPeriod",SqlDbType.NVarChar,10),
                    new SqlParameter("@LoginUserID",SqlDbType.Int,4),
                    new SqlParameter("@EntryDate",SqlDbType.DateTime,20),
                    new SqlParameter("@Status",SqlDbType.Bit), 
                    new SqlParameter("@Mode",SqlDbType.NVarChar,10),
                };

            param[0].Value = _StartDate;
            param[1].Value = _EndDate;
            param[2].Value = _AcctPeriod;
            param[3].Value = _LoginUserID;
            param[4].Value = _EntryDate;
            param[5].Value = _Status;
            param[6].Value = _Mode;
            int i = InvDataAccessLayer.InsertUpdateDeleteData("SP_FinancialYearUpdate", param);
            return i;
        }
        
        public int UpdateStatus()
        {
            SqlParameter[] param =
                {
                    new SqlParameter("@AcctPeriod",SqlDbType.NVarChar,4),
                    new SqlParameter("@Status",SqlDbType.Bit), 
                    new SqlParameter("@Mode",SqlDbType.NVarChar,20),
                };
            param[0].Value = _AcctPeriod;
            param[1].Value = _Status;
            param[2].Value = _Mode;
            int i = InvDataAccessLayer.InsertUpdateDeleteData("SP_FinancialYearUpdate", param);
            return i;
        }

        #endregion
    }
}