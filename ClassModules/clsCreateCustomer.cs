using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace inventory_control
{
    class clsCreateCustomer
    {
        #region  Private Varibles CreateCustomer

        clsGlobalValue InvclsGlobalValue = new clsGlobalValue();
        DataAccessLayer InvDataAccessLayer = new DataAccessLayer();
        DataSet ds = new DataSet();

        private int _CustomerID = 0;
        private string _CustomerName = string.Empty;
        private string _Address1 = string.Empty;
        private string _Address2 = string.Empty;
        private string _Phone = string.Empty;
//        private string _Phone2 = string.Empty;
        private string _Fax1 = string.Empty;
        private string _Fax2 = string.Empty;
        private string _EmailID = string.Empty;
        private string _PANNo = string.Empty;
        private string _CSTNo = string.Empty;
        private string _STNo= string.Empty;
        private string _TINNo = string.Empty;
        private string _ECCNo = string.Empty;
        private string _VATNo = string.Empty;
        public bool _Status = false;
        private int _LOGINUserID = 0;
        private DateTime _LoginDate = DateTime.Now;
        private string _Mode = string.Empty;
        #endregion

        #region Public Properties  CreateCustomer

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
        //public string Phone2
        //{
        //    set
        //    {
        //        _Phone2 = value;
        //    }
        //    get
        //    {
        //        return _Phone2;
        //    }
        //}
        public string Fax1
        {
            set
            {
                _Fax1 = value;
            }
            get
            {
                return _Fax1;
            }
        }
        public string Fax2
        {
            set
            {
                _Fax2 = value;
            }
            get
            {
                return _Fax2;
            }
        }

        public string EmailID
        {
            set
            {
                _EmailID = value;
            }
            get
            {
                return _EmailID;
            }
        }

        public string PANNo
        {
            set
            {
                _PANNo = value;
            }
            get
            {
                return _PANNo;
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

        public string STNo
        {
            set
            {
                _STNo = value;
            }
            get
            {
                return _STNo;
            }
        }

        public string TINNo
        {
            set
            {
                _TINNo = value;
            }
            get
            {
                return _TINNo;
            }
        }

        public string ECCNo
        {
            set
            {
                _ECCNo = value;
            }
            get
            {
                return _ECCNo;
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
                _LOGINUserID = value;
            }
            get
            {
                return _LOGINUserID;
            }
        }

        public DateTime LoginDate
        {
            set
            {
                _LoginDate = value;
            }
            get
            {
                return _LoginDate;
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

        #region Public Methods  CreateCustomer

        public int UpdateData()
        {
            SqlParameter[] param =
                {
                    new SqlParameter("@CustomerID",SqlDbType.Int), 
                    new SqlParameter("@CustomerName",SqlDbType.NVarChar,100),
                    new SqlParameter("@Address1",SqlDbType.NVarChar,100),
                    new SqlParameter("@Address2",SqlDbType.NVarChar,100),
                    new SqlParameter("@Phone",SqlDbType.NVarChar,15),
 //                   new SqlParameter("@Phone2",SqlDbType.NVarChar,15),
                    new SqlParameter("@Fax1",SqlDbType.NVarChar,15),
                    new SqlParameter("@Fax2",SqlDbType.NVarChar,15),
                    new SqlParameter("@EmailID",SqlDbType.NVarChar,50),
                    new SqlParameter("@PAN",SqlDbType.NVarChar,20),
                    new SqlParameter("@CST",SqlDbType.NVarChar,20),
                    new SqlParameter("@ST",SqlDbType.NVarChar,20),
                    new SqlParameter("@TIN",SqlDbType.NVarChar,20),
                    new SqlParameter("@ECC",SqlDbType.NVarChar,20),
                    new SqlParameter("@VAT",SqlDbType.NVarChar,20),
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
            param[5].Value = _PANNo;
            param[6].Value = _Status;
            param[7].Value = _LOGINUserID;
            param[8].Value = _LoginDate;
            param[9].Value = _Mode;

/*          param[5].Value = _Phone2;
            param[5].Value = _Fax1;
            param[6].Value = _Fax2;
            param[7].Value = _EmailID;
*/ 

/*
            param[6].Value = _CSTNo;
            param[7].Value = _STNo;
            param[8].Value = _TINNo;
            param[9].Value = _ECCNo;
            param[10].Value = _VATNo; 
 */

            int i = InvDataAccessLayer.InsertUpdateDeleteData("SP_CustomerMasterUpdatee", param);
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

  
        public bool RetrieveData(int CustomerID)
        {
            string strSQL = String.Empty;

            strSQL = "select * from tbl_Customers where Status=1 and CustomerID=" + CustomerID;

            ds = InvDataAccessLayer.PopulateDataSet(strSQL, "CustomerMaster");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    _CustomerName = (row["CustomerName"].ToString());
                    _Address1 = (row["Address1"].ToString());
                    _Address2 = (row["Address2"].ToString());
                    _Phone = (row["Phone"].ToString());
                    _PANNo = (row["PANNO"].ToString());
                    /*
                                        _Phone2 = (row["Phone2"].ToString());
                                        _Fax1 = (row["Fax1"].ToString());
                                        _Fax2 = (row["Fax2"].ToString());
                                        _EmailID = (row["EmailId"].ToString());
                                         _CSTNo = (row["CST"].ToString());
                                        _STNo = (row["ST"].ToString());
                                        _ECCNo = (row["ECC"].ToString());
                                        _TINNo = (row["TIN"].ToString());
                                        _VATNo = (row["VAT"].ToString());

                     */
                }
                return true;
            }
            else
                return false;
            //ds.Dispose();
        }

        public int DeleteCustomerMaster()
        {
            int i = 0;

            SqlParameter[] param =
                {
                    new SqlParameter("@CustomerID",SqlDbType.Int),
                    new SqlParameter("@Mode",SqlDbType.NVarChar,10)                
                };

            param[0].Value = _CustomerID;
            param[1].Value = _Mode;
            i = InvDataAccessLayer.InsertUpdateDeleteData("SP_CustomerMasterDelete", param);
            return i;
        }
        #endregion
    }
}