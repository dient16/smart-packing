using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartParking.Model;
using SmartParking.GUI;

namespace SmartParking
{
    public partial class fLogin :  MetroFramework.Forms.MetroForm
    {
        private fLogin _this;

        [Obsolete]
        public fLogin()
        {
            InitializeComponent();
            _this = this;
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type, _this.Location.X + _this.Size.Width, _this.Location.Y + _this.Size.Height);
        }
        private void UpdateText()
        {
            txt_Username.Text = "";
            txt_Password.Text = "";
        }
        [Obsolete]
        private void btn_login_Click(object sender, EventArgs e)
        {
            string userName = txt_Username.Text;
            string passWord = txt_Password.Text;
            string passWordEncode =DataProvider.Ins.MD5Hash(DataProvider.Ins.Base64Encode(passWord));
            if (Login(userName, passWordEncode))
            {
                var user = HandleDataDB.Ins.GetUserByUsername(userName);
                if (user != null)
                {
                    HandleDataDB.Ins.SetAccount(user);
                    if (user.RoleID == 1)
                    {
                        fAdminManager fAdminManager = new fAdminManager();
                        fAdminManager.ShowDialog();
                        HandleDataDB.Ins.SetAccount(null);
                        UpdateText();
                        _this.Show();
                        this.Alert("Đã đăng xuất", Form_Alert.enmType.Success);
                    }
                    else if(user.RoleID == 2)
                    {
                        fManagerCheckInOut fParkingManager = new fManagerCheckInOut();
                        fParkingManager.ShowDialog();
                        HandleDataDB.Ins.SetAccount(null);
                        UpdateText();
                        _this.Show();
                    }
                    else if(user.RoleID == 3)
                    {
                        fCustomer fcustomer = new fCustomer();
                        fcustomer.ShowDialog();
                        HandleDataDB.Ins.SetAccount(null);
                        UpdateText();
                        _this.Show();
                        this.Alert("Đã đăng xuất", Form_Alert.enmType.Success);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
           
        }
        bool Login(string userName, string passWord)
        {
            return HandleDataDB.Ins.Login(userName, passWord, _this);
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
