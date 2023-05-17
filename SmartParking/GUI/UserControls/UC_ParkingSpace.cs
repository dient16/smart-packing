using SmartParking.Model;
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

namespace SmartParking.GUI.UserControls
{
    public partial class UC_ParkingSpace : UserControl
    {
        private static UC_ParkingSpace _instance;
        public UC_ParkingSpace()
        {
            InitializeComponent();
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

            ObservableCollection<ParkingSpace> ls = HandleDataDB.Ins.GetListParkingSpace();

            foreach (var item in ls)
            {
                if (item.SpaceNumber.ToCharArray()[item.SpaceNumber.ToCharArray().Length - 1] == zone)
                {
                    Krypton.Toolkit.KryptonButton btn = new Krypton.Toolkit.KryptonButton() { Width = 76, Height = 89 };
                    btn.Click += Btn_Click;
                    btn.Name = "btn_" + item.SpaceNumber;
                    btn.Tag = item;
                    btn.StateCommon.Border.Rounding = 5;
                    btn.StateCommon.Border.Width = 2;
                    btn.StateCommon.Border.Color1 = Color.Black;
                    btn.StateCommon.Content.ShortText.Font = new Font("Poppins", 8, FontStyle.Regular);
                    /*btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 10;
                    btn.FlatAppearance.BorderColor = Color.Black; //Color.FromArgb(255, 255, 255, 255);*/

                    switch (item.Availability)
                    {
                        case "Trống":
                            btn.StateCommon.Back.Color1 = Color.Aqua;
                            btn.StateCommon.Back.Color2 = Color.Aqua;
                            btn.Text = item.SpaceNumber + Environment.NewLine + "Trống";
                            break;
                        case "Ðã đặt chỗ":
                            btn.StateCommon.Back.Color1 = Color.LightYellow;
                            btn.StateCommon.Back.Color2 = Color.LightYellow;
                            btn.Text = item.SpaceNumber + Environment.NewLine + "Đã đặt chỗ";
                            break;
                        case "Đang đỗ xe":
                            btn.StateCommon.Back.Color1 = Color.LightPink;
                            btn.StateCommon.Back.Color2 = Color.LightPink;
                            btn.Text = item.SpaceNumber + Environment.NewLine + "Đang đỗ xe";
                            break;
                        default:
                            btn.StateCommon.Back.Color1 = Color.Aqua;
                            btn.StateCommon.Back.Color2 = Color.Aqua;
                            btn.Text = item.SpaceNumber + Environment.NewLine + "Trống";
                            break;
                    }
                    flp.Controls.Add(btn);
                }
            }
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type, 1674, 908);
        }
        private void BookingSpace(ParkingSpace space)
        {
            fBooking fBooking = new fBooking();
            //int BookingID = HandleDataDB.Ins.GetCountBooking() + 1;

            var p_wrap = GetChildrenControl("p_wrap", fBooking);
            var panel1 = GetChildrenControl("panel1", p_wrap);
            var panel2 = GetChildrenControl("panel2", p_wrap);
            var txt_id = GetChildrenControl("txb_BookingID", panel1);

            txt_id.Enabled = false;
            GetChildrenControl("txb_parkingspace", panel1).Text = space.SpaceNumber;
            var txb_totalcost = GetChildrenControl("txb_totalcost", panel1);
            txb_totalcost.Enabled = false;
            Krypton.Toolkit.KryptonComboBox cb_CarName = GetChildrenControl("cb_CarName", panel1) as Krypton.Toolkit.KryptonComboBox;
            cb_CarName.DataSource = new List<string>() { "Ô tô", "Xe máy" };
            var txb_LicensePlate = GetChildrenControl("txb_LicensePlate", panel1);
            var btn_Booking = GetChildrenControl("btn_Booking", panel2);

            var paneluser = GetChildrenControl("Panel_User", p_wrap);
            var txb_EmailUser = GetChildrenControl("txb_EmailUser", panel1);
            txb_EmailUser.Text = HandleDataDB.Ins.Accconut.Email;
            txb_EmailUser.Enabled = false;
            var txb_UserName = GetChildrenControl("txb_UserName", panel1);
            txb_UserName.Text = HandleDataDB.Ins.Accconut.Username;
            txb_UserName.Enabled = false;
            var txb_DisplayName = GetChildrenControl("txb_DisplayName", panel1);
            txb_DisplayName.Text = HandleDataDB.Ins.Accconut.DisplayName;
            txb_UserName.Enabled = false;
            btn_Booking.Tag = fBooking;
            if (btn_Booking != null)
                btn_Booking.Click += (sender, e) =>
                {
                    string typeCar = "XM";
                    if (cb_CarName.SelectedValue.ToString() == "Ô tô")
                        typeCar = "OT";
                    Car car = HandleDataDB.Ins.GetCarbyLicensePlate(txb_LicensePlate.Text);
                    if (car == null)
                    {
                        Car newCar = new Car()
                        {
                            CarType = typeCar,
                            CarName = cb_CarName.SelectedValue.ToString(),
                            LicensePlate = txb_LicensePlate.Text
                        };
                        car = newCar;
                        HandleDataDB.Ins.InsertCar(car);
                    }
                    Booking booking = null;
                    var caR = HandleDataDB.Ins.GetCarbyLicensePlate(car.LicensePlate);
                    booking = new Booking()
                    {
                        UserID = HandleDataDB.Ins.Accconut.UserID,
                        CarID = caR.CarID,
                        SpaceID = space.SpaceID,
                        BookingTime = DateTime.Now,
                        Status = "Đã đặt chỗ"
                    };
                    txt_id.Text = booking.BookingID.ToString();
                    HandleDataDB.Ins.InsertBooking(booking);
                    ///update trạng thái vị trí đã đặt
                    space.Availability = "Ðã đặt chỗ";
                    DataProvider.Ins.DB.SaveChanges();
                    var bookingID = HandleDataDB.Ins.GetBookingByparkingspace(space.SpaceNumber).BookingID;         
                    CheckInOut checkInOut = new CheckInOut()
                    {
                        CarID = car.CarID,
                        SpaceID = space.SpaceID,
                        BookingID = bookingID,
                        CheckInTime = null,
                        CheckOutTime = null,
                        TotalCost = Convert.ToDouble(txb_totalcost.Text),
                        Status = "Ðã đặt chỗ"
                    };
                    if (HandleDataDB.Ins.InsertCheckInOut(checkInOut))
                    {
                        this.Alert("Đặt chỗ thành công!!!!", Form_Alert.enmType.Success);
                        LoadParkingSpace(flp_SpaceA, 'A');
                        LoadParkingSpace(flp_SpaceB, 'B');
                        LoadParkingSpace(flp_SpaceC, 'C');
                        if ((sender as Control) != null)
                            ((sender as Control).Tag as fBooking).Close();
                    }
                    else
                    {
                        this.Alert("Đặt chỗ thành thất bại", Form_Alert.enmType.Error);
                        if ((sender as Control) != null)
                            ((sender as Control).Tag as fBooking).Close();
                    }
                };
            fBooking.ShowDialog();
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            var spaceName = (sender as Krypton.Toolkit.KryptonButton).Tag as ParkingSpace;
            if (spaceName.Availability == "Đang đỗ xe")
            {
                this.Alert("Chỗ này có chủ rồi", Form_Alert.enmType.Error);
                return;
            }
            if (spaceName.Availability == "Ðã đặt chỗ")
            {
                this.Alert("Chỗ này có có người đặt rồi", Form_Alert.enmType.Error);
                return;
            }
            BookingSpace(spaceName);
        }
    }
}
