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
    public partial class fEditUser : MetroFramework.Forms.MetroForm
    {
        public fEditUser()
        {
            InitializeComponent();
            
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type, 1579 ,871);
        }
        public void UpdateUser(User user)
        {
            if (user == null)
                return;
            txb_id.Text = user.UserID.ToString();
            txb_username.Text = user.Username.ToString();
            txb_displayname.Text = user.DisplayName.ToString();
            txb_Email.Text = user.Email.ToString();
        }

        private void btn_UpdateUser_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                UserID = Convert.ToInt32(txb_id.Text),
                Username = txb_username.Text,
                DisplayName = txb_displayname.Text,
                Email = txb_Email.Text
            };
            HandleDataDB.Ins.UpdateUser(user);
            this.Alert("Cập nhập thành công", Form_Alert.enmType.Success);
            this.Close();
           
        }
    }
}
