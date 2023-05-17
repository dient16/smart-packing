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

namespace SmartParking.GUI
{
    public partial class fAddNewUser : MetroFramework.Forms.MetroForm
    {
        public fAddNewUser()
        {
            InitializeComponent();
        }
        private int Role = 3;
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type, 1579, 871);
        }
        public void SetRole(int r)
        {
            Role = r;
        }

        private void btn_AddNewUser_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Username = txb_username.Text,
                DisplayName = txb_displayname.Text,
                Email = txb_Email.Text,
                Password = DataProvider.Ins.MD5Hash(DataProvider.Ins.Base64Encode("123")),
                RoleID = Role
            };
            var iSuccess = HandleDataDB.Ins.InsertUser(user);
            if (iSuccess)
            {
                this.Alert("Thêm mới thành công", Form_Alert.enmType.Success);
                this.Close();
            }
            else
            {
                this.Alert("Thêm mới thất bại", Form_Alert.enmType.Error);
                this.Close();
            }
        }
    }
}
