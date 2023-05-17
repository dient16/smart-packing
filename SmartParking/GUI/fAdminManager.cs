using SmartParking.GUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartParking
{
    public partial class fAdminManager : MetroFramework.Forms.MetroForm  
    {
        fAdminManager _this;
        public fAdminManager()
        {
            InitializeComponent();
            _this = this;
            UC_Dashboard uC_ = new UC_Dashboard();
            addUserControl(uC_);

        }
        private void addUserControl(UserControl uc)
        {
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            panelContainer.Controls.Add(uc);
        }
        private void btn_Customer_Click(object sender, EventArgs e)
        {
            UC_Customer uC_ = new UC_Customer();
            addUserControl(uC_);
           //btn_Customer.StateCommon.Back.Color1 = Color.FromArgb(122, 104, 220);
            //btn_Customer.StateCommon.Back.Color2 = Color.FromArgb(122, 104, 220);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            _this.Close();
        }

        private void btn_NavEmployee_Click(object sender, EventArgs e)
        {
            UC_Employee uC_ = new UC_Employee();
            addUserControl(uC_);
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            UC_Dashboard uC_ = new UC_Dashboard();
            addUserControl(uC_);
        }
    }
}
