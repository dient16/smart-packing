using SmartParking.GUI.UserControls;
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
    public partial class fCustomer : MetroFramework.Forms.MetroForm
    {
        fCustomer _this;
        public fCustomer()
        {
            _this = this;
            InitializeComponent();
            lb_DisplayName.Text = HandleDataDB.Ins.Accconut.DisplayName;
            UC_ParkingSpace uC_ = new UC_ParkingSpace();
            addUserControl(uC_);
        }
       
        private void addUserControl(UserControl uc)
        {
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            panelContainer.Controls.Add(uc);
        }

        private void btn_NavBooking_Click(object sender, EventArgs e)
        {
            UC_ParkingSpace uC_ = new UC_ParkingSpace();
            addUserControl(uC_);
           // btn_NavBooking.StateCommon.Back.Color1 = Color.FromArgb(122, 104, 220);
           // btn_NavBooking.StateCommon.Back.Color2 = Color.FromArgb(122, 104, 220);
        }

        private void btn_Bookinghistory_Click(object sender, EventArgs e)
        {
            UC_BookingHistory uC_ = new UC_BookingHistory();
            addUserControl(uC_);
            //btn_Bookinghistory.StateCommon.Back.Color1 = Color.FromArgb(122, 104, 220);
            //btn_Bookinghistory.StateCommon.Back.Color2 = Color.FromArgb(122, 104, 220);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            
            _this.Close();
        }
    }
}
