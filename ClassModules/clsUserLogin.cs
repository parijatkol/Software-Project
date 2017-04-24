using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace inventory_control
{
    class clsUserLogin
    {
        #region  Private Varibles clsUserLogin

        clsGlobalValue InvclsGlobalValue = new clsGlobalValue();
        DataAccessLayer InvDataAccessLayer = new DataAccessLayer();

//        private int _UserID = 0;
        private string _UserName = string.Empty;
        private string _Password = string.Empty;
        private DateTime _EntryDate = DateTime.Now;
        #endregion

        #region Public Properties  clsUserLogin

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

        //public int UserLoginID
        //{
        //    set
        //    {
        //        _UserLoginID = value;
        //    }
        //    get
        //    {
        //        return _UserLoginID;
        //    }
        //}
        //public DateTime EntryDate
        //{
        //    set
        //    {
        //        _EntryDate = value;
        //    }
        //    get
        //    {
        //        return _EntryDate;
        //    }
        //}

        #endregion
        #region Public Methods  UserLogin

        public int UserCheckLogin()
        {
            SqlParameter[] param =
                {
                    new SqlParameter("@UserName",SqlDbType.NVarChar,50),
                    new SqlParameter("@Password",SqlDbType.NVarChar,50),
                };

            param[0].Value = _UserName;
            param[1].Value = _Password;

            int i = InvDataAccessLayer.CheckLogin("SP_CheckLogin", param);
            
            return i;
        }
        

        #endregion
    }



}
