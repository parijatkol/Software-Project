using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace inventory_control
{
    class clsGlobalValue
    {
        #region  Public Varibles clsGlobalValue

        public static int _Login_UserId = 0;
        public static bool _Logged = false;
        public static int _FinYearID = 0;
        public static string _FinYear;
        public static string _StartDate;
        public static string _EndDate;
        public static string _loggedusername;
        public static string _today = DateTime.Now.ToString("d");
        public static bool _SelectFinYear = false;

        public static decimal _vatpercent = 4;

        public string _callmenu = string.Empty;
        #endregion

        #region Public Properties  clsGlobalValue
        
        public int Login_UserId
        {
            set
            {
                _Login_UserId = value;
            }
            get
            {
                return _Login_UserId;
            }
        }
        public bool Logged
        {
            set
            {
                _Logged = value;
            }
            get
            {
                return _Logged;
            }
        }
        public string FinYear
        {
            set
            {
                _FinYear = value;
            }
            get
            {
                return _FinYear;
            }
        }
        public int FinYearID
        {
            set
            {
                _FinYearID = value;
            }
            get
            {
                return _FinYearID;
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
        public string loggedusername
        {
            set
            {
                _loggedusername = value;
            }
            get
            {
                return _loggedusername;
            }
        }

        public decimal vatPercentage
        {
            set
            {
                _vatpercent = value;
            }
            get
            {
                return _vatpercent;
            }
        }

        public string Today
        {
            set
            {
                _today = value;
            }
            get
            {
                return _today;
            }
        }

        public bool SelectFinYear
        {
            set
            {
                _SelectFinYear = value;
            }
            get
            {
                return _SelectFinYear;
            }
        }

        public string callmenu
        {
            set
            {
                _callmenu = value;
            }
            get
            {
                return _callmenu;
            }
        }

        #endregion

    }
}
