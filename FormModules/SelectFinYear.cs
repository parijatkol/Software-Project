using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace inventory_control
{
    public partial class SelectFinYear : DevExpress.XtraEditors.XtraForm
    {
        DataAccessLayer InvDataFinYearAccessLayer = new DataAccessLayer();
        clsGlobalValue InvAcctPeriodVal = new clsGlobalValue();

        public SelectFinYear()
        {
            InitializeComponent();
        }

        private void cmdOpen_Click(object sender, EventArgs e)
        {
            int rowID = 0;

            try
            {
                foreach (int i in gridView2.GetSelectedRows())
                {
                    DataRow row = gridView2.GetDataRow(i);
                    rowID = Convert.ToInt16(row["FinancialYrID"]);
                    InvAcctPeriodVal.FinYearID = rowID;
                    InvAcctPeriodVal.FinYear = row["AcctPeriod"].ToString();
                    InvAcctPeriodVal.StartDate = row["StartDate"].ToString();
                    InvAcctPeriodVal.EndDate = row["EndDate"].ToString();
                    InvAcctPeriodVal.SelectFinYear = true;
                    InvAcctPeriodVal.Logged = true;
                    MDIParent1.ActiveForm.Text =  "I n v e n t o r y   C o n t r o l  S y s t e m " + " Financial Year : [" + InvAcctPeriodVal.FinYear + "]";
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void SelectFinYear_Load(object sender, EventArgs e)
        {
            FinYeargridpopulate(0);
        }

        private void FinYeargridpopulate(int focusrow)
        {
            try
            {
                string strSQL = "select FinancialYrID, AcctPeriod,CONVERT(char(10), StartDate, 101) AS StartDate, CONVERT(char(10), EndDate, 101) AS EndDate from tbl_FinancialYear where Status=1";
                SqlDataAdapter InvDataFinYrAdapter = new SqlDataAdapter();
                InvDataFinYrAdapter = InvDataFinYearAccessLayer.PopulateData(strSQL);
                InvDataFinYrAdapter.Fill(dsFinancialYear.tbl_FinancialYear);
                gridView2.FocusedRowHandle = focusrow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmdOpen.Focus();
        }
    }
}