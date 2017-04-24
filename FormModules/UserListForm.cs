using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using DevExpress.Utils;
//The DevExpress.Utils.WaitDialogForm

namespace inventory_control
{
    public partial class UserListForm : DevExpress.XtraEditors.XtraForm
    {
        DataAccessLayer InvDataAccessLayer = new DataAccessLayer();
        public UserListForm()
        {
            InitializeComponent();
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            string strSQL1 = "select a.UserID,a.FirstName,a.LastName,a.UserName,a.Password,a.ContactNo,b.UserGroupName from tbl_MainUsers a inner join tbl_UserGroup b on a.usergroupid = b.usergroupid where a.Status=1";
            SqlDataAdapter InvDataAdapter1 = new SqlDataAdapter();
            InvDataAdapter1 = InvDataAccessLayer.PopulateData(strSQL1);
            InvDataAdapter1.Fill(dsUserList1.tbl_MainUsers);

/*            string strSQL2 = "select * from tbl_MainUsers where Status=1";
            SqlDataAdapter InvDataAdapter2 = new SqlDataAdapter();
            InvDataAdapter2 = InvDataAccessLayer.PopulateData(strSQL2);
            InvDataAdapter2.Fill(dsUserList1.tbl_MainUsers); */
        }
    }
}