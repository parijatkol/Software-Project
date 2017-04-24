using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;

namespace inventory_control
{
    class clsValidation
    {
        clsGlobalValue InvTranValidation = new clsGlobalValue();

        public bool IsEmptyValidate(string str)
        {
            if (str == "" || str.Length == 0)
            {
                return false;
            }
            else
                return true;
        }

        public bool IsInteger(String strNumber)
        {
            Regex objNotIntPattern=new Regex("[^0-9-]");
            Regex objIntPattern=new Regex("^-[0-9]+$|^[0-9]+$");
            return !objNotIntPattern.IsMatch(strNumber) && objIntPattern.IsMatch(strNumber);
        }

        public bool IsNumber(String strNumber)
        {
            Regex objNotNumberPattern=new Regex("[^0-9.-]");
            Regex objTwoDotPattern=new Regex("[0-9]*[.][0-9]*[.][0-9]*");
            Regex objTwoMinusPattern=new Regex("[0-9]*[-][0-9]*[-][0-9]*");
            String strValidRealPattern="^([-]|[.]|[-.]|[0-9])[0-9]*[.]*[0-9]+$";
            String strValidIntegerPattern="^([-]|[0-9])[0-9]*$";
            Regex objNumberPattern =new Regex("(" + strValidRealPattern +")|(" + strValidIntegerPattern + ")");
            return !objNotNumberPattern.IsMatch(strNumber) &&
            !objTwoDotPattern.IsMatch(strNumber) &&
            !objTwoMinusPattern.IsMatch(strNumber) &&
            objNumberPattern.IsMatch(strNumber);
        }

        public bool IsAlpha(String strToCheck)
        {
            Regex objAlphaPattern=new Regex("[^a-zA-Z]");
            return !objAlphaPattern.IsMatch(strToCheck);
        }

        public bool IsAlphaNumeric(String strToCheck)
        {
            Regex objAlphaNumericPattern=new Regex("[^a-zA-Z0-9]");
            return !objAlphaNumericPattern.IsMatch(strToCheck);
        }

        //public bool DateWithinFinancialYear(DateTime TransactDate)
        //{
        //    int dy, mth, yr;

        //    dy = TransactDate.Day;
        //    mth = TransactDate.Month;
        //    yr = TransactDate.Year;

        //    return true;
        //}
    }
 }




