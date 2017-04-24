using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace inventory_control
{
    class clsUserCreation
    {
        #region  Private Varibles UserCreation

        clsGlobalValue InvclsGlobalValue = new clsGlobalValue();
        DataAccessLayer InvDataAccessLayer = new DataAccessLayer();
        DataSet ds = new DataSet();

        private string _FirstName = string.Empty;
        private string _LastName = string.Empty; 
        private string _ContactNo = string.Empty;
        private string _Address = string.Empty;
        private string _UserName = string.Empty;
        private string _Password = string.Empty;
        public bool _Status = false;
        private int _UserID = 0;
        private int _UserGroupID = 0;
        private int _UserGroupIDItemIndex = 0;
        private int _UserLoginID = 0;
        private DateTime _EntryDate = DateTime.Now;
        private string _Mode = string.Empty;
        private string _UserGroupName = string.Empty;
        #endregion

        #region Public Properties  UserCreation

        public string FirstName
        {
            set
            {
                _FirstName = value;
            }
            get
            {
                return _FirstName;
            }
        }
        public string LastName
        {
            set
            {
                _LastName = value;
            }
            get
            {
                return _LastName;
            }
        }
        public string ContactNo
        {
            set
            {
                _ContactNo = value;
            }
            get
            {
                return _ContactNo;
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
        public string UserName
        {
            set
            {
                _UserName = value;
            }
            get
            {
                return _UserName;
            }
        }
        public string Password
        {
            set
            {
                _Password = value;
            }
            get
            {
                return _Password;
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
        public int UserID
        {
            set
            {
                _UserID = value;
            }
            get
            {
                return _UserID;
            }
        }
        public int UserGroupID
        {
            set
            {
                _UserGroupID = value;
            }
            get
            {
                return _UserGroupID;
            }
        }
        public int UserGroupIDItemIndex
        {
            set
            {
                _UserGroupIDItemIndex = value;
            }
            get
            {
                return _UserGroupIDItemIndex;
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
        public string UserGroupName
        {
            set
            {
                _UserGroupName = value;
            }
            get
            {
                return _UserGroupName;
            }
        }

        #endregion

        #region Public Methods  UserCreation

        public int UpdateData()
        {
            SqlParameter[] param =
                {
                    new SqlParameter("@UserID",SqlDbType.Int), 
                    new SqlParameter("@UserName",SqlDbType.NVarChar,50),
                    new SqlParameter("@Password",SqlDbType.NVarChar,50),
                    new SqlParameter("@FirstName",SqlDbType.NVarChar,50),
                    new SqlParameter("@LastName",SqlDbType.NVarChar,50),
                    new SqlParameter("@Address",SqlDbType.NVarChar,255),
                    new SqlParameter("@ContactNo",SqlDbType.NVarChar,20),
                    new SqlParameter("@Status",SqlDbType.Bit), 
                    new SqlParameter("@UserGroupID",SqlDbType.Int), 
                    new SqlParameter("@UserGroupIDItemIndex",SqlDbType.Int), 
                    new SqlParameter("@UserLoginID",SqlDbType.Int),
                    new SqlParameter("@EntryDate",SqlDbType.DateTime),
                    new SqlParameter("@Mode",SqlDbType.NVarChar,10),
                };

            param[0].Value = _UserID;
            param[1].Value = _UserName;
            param[2].Value = _Password;
            param[3].Value = _FirstName;
            param[4].Value = _LastName;
            param[5].Value = _Address;
            param[6].Value = _ContactNo;
            param[7].Value = _Status;
            param[8].Value = _UserGroupID;
            param[9].Value = _UserGroupIDItemIndex;
            param[10].Value = _UserLoginID;
            param[11].Value = _EntryDate;
            param[12].Value = _Mode;
            int i = InvDataAccessLayer.InsertUpdateDeleteData("SP_MainUsersUpdate", param);
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

        public bool RetrieveData(int UserID)
        {
            string strSQL = String.Empty;

            strSQL = "select a.*,b.UserGroupName from tbl_MainUsers a inner join tbl_UserGroup b on a.UserGroupID = b.UserGroupID where a.Status=1 and b.status=1 and a.UserID =" + UserID;

            ds = InvDataAccessLayer.PopulateDataSet(strSQL, "CustomerMaster");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    _FirstName = (row["FirstName"].ToString());
                    _LastName = (row["LastName"].ToString());
                    _Address = (row["Address"].ToString());
                    _ContactNo = (row["ContactNo"].ToString());
                    _UserName = (row["UserName"].ToString());
                    _Password = (row["Password"].ToString());
                    _UserGroupID = Convert.ToInt16(row["UserGroupID"]);
                    _UserGroupName = (row["UserGroupName"].ToString());
                    _UserGroupIDItemIndex = Convert.ToInt16(row["UserGroupIDItemIndex"]);
                }
                return true;
            }
            else
                return false;
            //ds.Dispose();
        }
        #endregion
    }
}