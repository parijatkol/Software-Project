using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;


//namespace DevExpress.XtraGrid.Demos
namespace inventory_control
{
    /// <summary>
    /// Summary description for CellSelection.
    /// </summary>
    public partial class clsCustomerGrid
    {
        public clsCustomerGrid()
        {
//            CreateWaitDialog();
//            InitializeComponent();
//            InitNWindData();
//            InitEditors();
//            InitSelection();
        }

      //  bool updateValues = false;

        #region Init

        //private GridView CurrentGridView { get { return gridView2; } }


        //protected override void InitMDBData(string connectionString)
        //{
        //    DataSet dataSet = new DataSet();
        //    System.Data.OleDb.OleDbDataAdapter oleDBAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Customers", connectionString);

        //    SetWaitDialogCaption("Loading Customers...");
        //    oleDBAdapter.Fill(dataSet, "Customers");
        //    gridControl1.DataSource = dataSet.Tables["Customers"];
        //}
        //protected override void InitXMLData(string dataFileName)
        //{
        //    DataSet dataSet = new DataSet();
        //    SetWaitDialogCaption("Loading Tables...");
        //    dataSet.ReadXml(dataFileName);
        //    gridControl1.DataSource = dataSet.Tables["Customers"];
        //}
        //void InitEditors()
        //{
        //    Array arr = System.Enum.GetValues(typeof(GridMultiSelectMode));
        //    foreach (GridMultiSelectMode mode in arr)
        //        icbSelectMode.Properties.Items.Add(new ImageComboBoxItem(mode.ToString(), mode, -1));
        //    updateValues = true;
        //    icbSelectMode.EditValue = gridView2.OptionsSelection.MultiSelectMode;
        //    ceMultiSelect.Checked = gridView2.OptionsSelection.MultiSelect;
        //    updateValues = false;
        //}
//        void InitSelection( obje)
//        {
//            gridControl1.ForceInitialize();
//            gridView2.SelectCellAnchorRange(3, colCompanyName, 12, colPostalCode);
//        }
        #endregion
        //private void ceMultiSelect_CheckedChanged(object sender, System.EventArgs e)
        //{
        //    if (updateValues) return;
        //    gridView2.OptionsSelection.MultiSelect = ceMultiSelect.Checked;
        //    SetButtonEnabled();
        //}

        //private void icbSelectMode_SelectedIndexChanged(object sender, System.EventArgs e)
        //{
        //    if (updateValues) return;
        //    gridView2.OptionsSelection.MultiSelectMode = (GridMultiSelectMode)icbSelectMode.EditValue;
        //    sbRecords.Text = gridView2.OptionsSelection.MultiSelectMode == GridMultiSelectMode.CellSelect ? "Show Selected Values" : "Show Selected Records";
        //}

        //void SetButtonEnabled()
        //{
        //    sbRecords.Enabled = gridView2.SelectedRowsCount > 0 && ceMultiSelect.Checked;
        //    icbSelectMode.Enabled = ceMultiSelect.Checked;
        //}

        //private void icbTranslucentColors_CheckedChanged(object sender, System.EventArgs e)
        //{
        //    if (icbTranslucentColors.Checked)
        //    {
        //        gridView2.Appearance.SelectedRow.BackColor = Color.FromArgb(30, 0, 0, 240);
        //        gridView2.Appearance.FocusedRow.BackColor = Color.FromArgb(60, 0, 0, 240);
        //    }
        //    else
        //    {
        //        gridView2.Appearance.SelectedRow.Reset();
        //        gridView2.Appearance.FocusedRow.Reset();
        //    }
        //}

        //private void sbRecords_Click(object sender, System.EventArgs e)
        //{
        //    DemosHelper.ShowDescriptionForm(Control.MousePosition, GetSelectedRows(gridView2), gridView2.OptionsSelection.MultiSelectMode == GridMultiSelectMode.RowSelect ? "Selected Rows" : "Selected Cells");
        //}

        //private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        //{
        //    SetButtonEnabled();
        //}

        //string GetSelectedRows(GridView view)
        //{
        //    string ret = "";
        //    int rowIndex = -1;
        //    if (view.OptionsSelection.MultiSelectMode == GridMultiSelectMode.RowSelect)
        //    {
        //        foreach (int i in gridView2.GetSelectedRows())
        //        {
        //            DataRow row = gridView2.GetDataRow(i);
        //            if (ret != "") ret += "\r\n";
        //            ret += string.Format("Company Name: {0} (#{1})", row["CompanyName"], i);
        //        }
        //    }
        //    else
        //    {
        //        foreach (GridCell cell in view.GetSelectedCells())
        //        {
        //            if (rowIndex != cell.RowHandle)
        //            {
        //                if (ret != "") ret += "\r\n";
        //                ret += string.Format("Row: #{0}", cell.RowHandle);
        //            }
        //            ret += "\r\n    " + view.GetRowCellDisplayText(cell.RowHandle, cell.Column);
        //            rowIndex = cell.RowHandle;
        //        }
        //    }
        //    return ret;
        //}
    }
}
