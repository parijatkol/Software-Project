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
    public partial class ViewStock : DevExpress.XtraEditors.XtraForm
    {

        DataAccessLayer InvStock = new DataAccessLayer();
        clsGlobalValue StockclsGlobalValue = new clsGlobalValue();

        public ViewStock()
        {
            InitializeComponent();
        }

        private void ViewStock_Load(object sender, EventArgs e)
        {
            GridStockView(0);
        }

        private void GridStockView(int focusrow)
        {
            try
            {
                int totrow = gridView2.RowCount;
                for (int i = 0; i < totrow; )
                {
                    DataRow row = gridView2.GetDataRow(i);
                    row.Delete();
                    totrow = gridView2.RowCount;
                }

                string strSQL = "select a.ItemCode,a.ItemName, isnull(b.OpStock,0) as Opstock, isnull(b.OpStockAmount,0.00) as OpStockAmount,";
                strSQL += "isnull(b.TotPurchased,0) as TotPurchased,isnull(b.TotSold,0) as TotSold, ";
                strSQL += "isnull(b.TotSoldAmount,0) as TotSoldAmount,isnull(b.ClosingStock,0) as ClosingStock, ";
                strSQL += "isnull(b.ClosingStockAmt,0.00) as ClosingStockAmt from tbl_ItemMaster a left join tbl_StockMaster b ";
                strSQL += "on (a.ItemNo = b.ItemNo and a.Status=1) and b.FinancialYrID=" + StockclsGlobalValue.FinYearID;


                SqlDataAdapter InvDataStockAdapter = new SqlDataAdapter();

                InvDataStockAdapter = InvStock.PopulateData(strSQL);
                InvDataStockAdapter.Fill(viewStockData1.tbl_StockMaster);
                gridView2.FocusedRowHandle = focusrow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

    }
}