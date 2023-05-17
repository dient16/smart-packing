using SmartParking.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartParking.GUI.UserControls
{
    public partial class UC_Employee : UserControl
    {
        public UC_Employee()
        {
            InitializeComponent();
            GetAllUser();
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type, 1579, 871);
        }
        private void GetAllUser()
        {
            Grid_Users.Rows.Clear();
            var List = HandleDataDB.Ins.GetAllUsers("2");
            Grid_Users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_Users.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (var item in List)
            {
                Grid_Users.Rows.Add(item.UserID, item.Username, item.DisplayName, item.Email);
            }
        }

        private void Grid_Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid_Users.Columns[e.ColumnIndex].Name == "edit")
            {
                fEditUser fEditUser = new fEditUser();
                fEditUser.UpdateUser(HandleDataDB.Ins.GetUserById(Convert.ToInt32(Grid_Users.Rows[e.RowIndex].Cells["Id"].Value)));
                fEditUser.ShowDialog();
                GetAllUser();
            }
            if (Grid_Users.Columns[e.ColumnIndex].Name == "Delete")
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này này?", "Thông báo", MessageBoxButtons.OKCancel);
                if (result != DialogResult.OK)
                    return;
                var iSuccess = HandleDataDB.Ins.DeleteUserById(Convert.ToInt32(Grid_Users.Rows[e.RowIndex].Cells["Id"].Value));
                if (iSuccess)
                {
                    this.Alert("Xóa thành công", Form_Alert.enmType.Success);
                    GetAllUser();
                }
                else
                {
                    this.Alert("Xóa thất bại", Form_Alert.enmType.Error);
                    GetAllUser();
                }
                
            }
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            fAddNewUser fAddNewUser = new fAddNewUser();
            fAddNewUser.SetRole(2);
            fAddNewUser.ShowDialog();
            GetAllUser();
        }
    }
}
