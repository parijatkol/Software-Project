using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace inventory_control
{
    public partial class CurrentAcctPeriod : DevExpress.XtraEditors.XtraForm
    {
        DataAccessLayer InvAcctPeriod = new DataAccessLayer();
        clsGlobalValue InvAcctPeriodVal = new clsGlobalValue();
        ErrorProviderExtended MyErrorProvider = new ErrorProviderExtended();

        public CurrentAcctPeriod()
        {
            InitializeComponent();
        }

        private void CurrentAcctPeriod_Load(object sender, EventArgs e)
        {
            string stSQL = "select FinancialYrID,AcctPeriod,Convert(Char(10),StartDate,103) as StartDate,Convert(Char(10),EndDate,103) as EndDate from tbl_FinancialYear where Status=1";
            SqlDataAdapter InvAcctPeriodAdapter = new SqlDataAdapter();
            InvAcctPeriodAdapter= InvAcctPeriod.PopulateData(stSQL);
            InvAcctPeriodAdapter.Fill(dsAcctPeriod1.tbl_FinancialYear);
            cmbAcctPeriod.Focus();
        }

        private void cmdOpen_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Controls.Add((object)cmbAcctPeriod, "Accounting Period");

            if ((MyErrorProvider.CheckAndShowSummaryErrorMessage() == true))
            {
                InvAcctPeriodVal.FinYearID = Convert.ToInt16(cmbAcctPeriod.GetColumnValue("FinancialYrID"));
                InvAcctPeriodVal.FinYear = cmbAcctPeriod.GetColumnValue("AcctPeriod").ToString();
                InvAcctPeriodVal.StartDate = cmbAcctPeriod.GetColumnValue("StartDate").ToString();
                InvAcctPeriodVal.EndDate = cmbAcctPeriod.GetColumnValue("EndDate").ToString();
                InvAcctPeriodVal.SelectFinYear = true;
                InvAcctPeriodVal.Logged = true;
                this.Close();
            }
        }
    }
}