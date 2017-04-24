using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace inventory_control
{
    class clsCustomers
    {
        DataAccessLayer InvDataAccessLayer = new DataAccessLayer();
        DataSet ds = new DataSet();

        #region private variables Customers

        private  int _CustomerID = 0;
        private string _CustomerName = String.Empty;
        private string _Address1 = String.Empty;
        private string _Address2 = String.Empty;
        private string _Phone = String.Empty;
        private string _PANNO = String.Empty;
        private bool _Status = false;
        private int _LoginUserID = 0;
        private DateTime _EntryDate = DateTime.Now;
        private string  _Mode = String.Empty;
        
        #endregion

        #region private Properties Customers

        public int CustomerID
        {
            set
            {
                _CustomerID = value;
            }
            get
            {
                return _CustomerID;
            }
        }
        public string CustomerName
        {
            set
            {
                _CustomerName = value;
            }
            get
            {
                return _CustomerName;
            }
        }
        public string Address1
        {
            set
            {
                _Address1 = value;
            }
            get
            {
                return _Address1;
            }
        }
        public string Address2
        {
            set
            {
                _Address2 = value;
            }
            get
            {
                return _Address2;
            }
        }
        public string Phone
        {
            set
            {
                _Phone = value;
            }
            get
            {
                return _Phone;
            }
        }
        public string PANNO
        {
            set
            {
                _PANNO = value;
            }
            get
            {
                return _PANNO;
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

        #region public Method Customers

        public int UpdateData()
        {
            SqlParameter[] param = 
            {
                               new SqlParameter("@CustomerID",SqlDbType.Int),
                               new SqlParameter("@CustomerName",SqlDbType.NVarChar,50),
                               new SqlParameter("@Address1",SqlDbType.NVarChar,100),
                               new SqlParameter("@Address2",SqlDbType.NVarChar,100),
                               new SqlParameter("@Phone",SqlDbType.NVarChar,20),
                               new SqlParameter("@PANNO",SqlDbType.NVarChar,25),
                               new SqlParameter("@Status",SqlDbType.Bit),
                               new SqlParameter("@LoginUserID",SqlDbType.Int),
                               new SqlParameter("@EntryDate",SqlDbType.DateTime),
                               new SqlParameter("@Mode",SqlDbType.NVarChar,10),
            };

            param[0].Value = _CustomerID;
            param[1].Value = _CustomerName;
            param[2].Value = _Address1;
            param[3].Value = _Address2;
            param[4].Value = _Phone;
            param[5].Value = _PANNO;
            param[6].Value = _Status;
            param[7].Value = _LoginUserID;
            param[8].Value = _EntryDate;
            param[9].Value = _Mode;

            int i = InvDataAccessLayer.InsertUpdateDeleteData("SP_CustomerMasterUpdate", param);
            return i;                   

        }

        public bool RetrieveData(int CustomerID)
        {
            string strSQL= String.Empty;

            strSQL = "select * from tbl_customers where Status=1 and CustomerID=" + CustomerID;

            ds = InvDataAccessLayer.PopulateDataSet(strSQL, "CustomerMaster");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    _CustomerName = (row["CustomerName"].ToString());
                    _Address1 = (row["Address1"].ToString());
                    _Address2 = (row["Address2"].ToString());
                    _Phone = (row["Phone"].ToString());
                    _PANNO =  (row["PANNO"].ToString());
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
