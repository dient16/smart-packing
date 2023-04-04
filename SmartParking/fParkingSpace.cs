using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartParking.Model;

namespace SmartParking
{
    public partial class fParkingSpace : MetroFramework.Forms.MetroForm
    {
        private static fParkingSpace _instance;
        public fParkingSpace()
        {
            InitializeComponent();
            //flp_SpaceA.HorizontalScroll.Maximum = 800;
            _instance = this;
            LoadParkingSpace(flp_SpaceA, 'A');
            LoadParkingSpace(flp_SpaceB, 'B');
            LoadParkingSpace(flp_SpaceC, 'C');
        }
        public static Control GetChildrenControl(string name, Control f)

        {
            foreach (Control item in f.Controls)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }
        void LoadParkingSpace(FlowLayoutPanel flp, char zone)
        {
            flp.Controls.Clear();

            ObservableCollection<ParkingSpace>  ls = HandleDataDB.Ins.GetListParkingSpace();

            foreach (var item in ls)
            {
                if(item.SpaceNumber.ToCharArray()[item.SpaceNumber.ToCharArray().Length -1 ] == zone)
                {
                    Button btn = new Button() { Width = 70, Height = 70 };

                    btn.Click += Btn_Click;
                    btn.Name = "btn_" + item.SpaceNumber;
                    btn.Tag = item;

                    switch (item.Availability)
                    {
                        case "Tr?ng":
                            btn.BackColor = Color.Aqua;
                            btn.Text = item.SpaceNumber + Environment.NewLine + "Trống";
                            break;
                        case "Ðã d?t ch?":
                            btn.BackColor = Color.LightYellow;
                            btn.Text = item.SpaceNumber + Environment.NewLine + "Đã đặt chỗ";
                            break;
                        default:
                            btn.BackColor = Color.LightPink;
                            btn.Text = item.SpaceNumber + Environment.NewLine + "Đã đậu xe";
                            break;
                    }
                    flp.Controls.Add(btn);
                }  
            }        
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var spaceName = (sender as Button).Tag as ParkingSpace;
            if (spaceName.Availability == "Ðã d? xe")
            {
                MessageBox.Show("Chỗ này có chủ rồi");
                return;
            }
            if (spaceName.Availability == "Ðã d?t ch?")
            {
                MessageBox.Show("Chỗ này có có người đặt rồi ba");
                return;
            }
            fBooking fBooking = new fBooking();
            int BookingID = HandleDataDB.Ins.GetCountBooking() + 1;
            var txt_id = GetChildrenControl("txb_BookingID", fBooking);
            txt_id.Text = BookingID.ToString();
            txt_id.Enabled = false;
            GetChildrenControl("txb_parkingspace", fBooking).Text = spaceName.SpaceNumber;
            GetChildrenControl("txb_totalcost", fBooking).Enabled = false;
            GetChildrenControl("txb_totalcost", fBooking).Enabled = false;
            var paneluser = GetChildrenControl("Panel_User", fBooking);
            if (HandleDataDB.Ins.Accconut != null)
            {
                var txb_EmailUser = GetChildrenControl("txb_EmailUser", paneluser);
                txb_EmailUser.Text = HandleDataDB.Ins.Accconut.Email;
                txb_EmailUser.Enabled = false;
                var txb_UserName = GetChildrenControl("txb_UserName", paneluser);
                txb_UserName.Text = HandleDataDB.Ins.Accconut.Username;
                txb_UserName.Enabled = false;
                fBooking.Controls.Remove(GetChildrenControl("lb_EmailGuesst", fBooking));
                fBooking.Controls.Remove(GetChildrenControl("txb_EmailGuest", fBooking));               
            }
            else
            {
                fBooking.Controls.Remove(paneluser);
            }
            var btn_Booking = GetChildrenControl("btn_Booking", fBooking);
            btn_Booking.Tag = fBooking;
            if (btn_Booking != null)
                btn_Booking.Click += Btn_Booking_Click;
            
            fBooking.ShowDialog();
            /*char zone = spaceName.SpaceNumber.ToCharArray()[spaceName.SpaceNumber.ToCharArray().Length - 1];
            FlowLayoutPanel flp = null;
            if(zone == 'A')
            {
                flp = flp_SpaceA;
            }
            else if(zone == 'B')
            {
                flp = flp_SpaceB;
            }
            else if (zone == 'C')
            {
                flp = flp_SpaceC;
            }*/
        }

        private void Btn_Booking_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chúc quý khách ngon miệng :))))");
            if((sender as Control) != null)
                ((sender as Control).Tag as fBooking).Close();
            
        }
    }
}
