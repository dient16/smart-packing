using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartParking.GUI;
using SmartParking.HandleLicensePlate;
using SmartParking.Model;

namespace SmartParking
{
    public partial class fManagerCheckInOut : MetroFramework.Forms.MetroForm   
    {
        
        fManagerCheckInOut _this;
        [Obsolete]
        public fManagerCheckInOut()
        {
            _this = this;
            InitializeComponent();

        }
        FindTextLicensePlate FindText;
        private void fManagerCheckInOut_Load(object sender, EventArgs e)
        {
            UpdateImageBoxIN();
            UpdateImageBoxCMP();
            UpdateImageBoxOUT();
            UpdateRestCheck();
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type, _this.Location.X + _this.Size.Width, _this.Location.Y+_this.Size.Height);
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
        [Obsolete]
        private void kryptonButton1_Click(object sender, EventArgs e)
        {            
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image (*.bmp; *.jpg; *.jpeg; *.png) |*.bmp; *.jpg; *.jpeg; *.png|All files (*.*)|*.*||";
            dlg.InitialDirectory = Application.StartupPath + "\\ImageTest";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            string startupPath = dlg.FileName;

            Image ImgLicensePlate;
            string TextLicensePlate, temp3;
            FindText = new FindTextLicensePlate();
            //int CardID = DataProvider.Ins.DB.CheckInOuts.Where(x => true).Count() + 1;
            
            Bitmap grayframe = FindText.Reconize(startupPath, out ImgLicensePlate, out TextLicensePlate, out temp3);
            pictureBox_XeVAO.Image = ImgLicensePlate;
            if (temp3 == "")
            {
                text_BiensoVAO.Text = "Cannot recognize license plate !";
                return;
            }    
            else
            {
                text_BiensoVAO.Text = TextLicensePlate;
            }
            /**
             * Kiểm tra xe có đặt chỗ không
             * */
            var isBooking = HandleDataDB.Ins.GetBookingBylicensePlate(TextLicensePlate);
            if (isBooking != null)
            {
                MessageBox.Show("Xe đã đặt chỗ");
                this.Alert("Xe đã đặt chỗ", Form_Alert.enmType.Success);
                DateTime CheckInTime = DateTime.Now;          
                try
                {
                    pictureBox_miniIN.Image = ImgLicensePlate;
                    txb_TimeCheckIn.Text = CheckInTime.ToString("dd/MM/yyyy hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    pictureBox_LicensePlatesIN.Image = grayframe;
                    var checkInout = HandleDataDB.Ins.GetCheckByBookingId(isBooking.BookingID);


                    //update status
                    checkInout.Status = "Đang đỗ xe";
                    checkInout.CheckInTime = CheckInTime;               
                    isBooking.ParkingSpace.Availability = "Đang đỗ xe";
                    pictureBox_LicensePlatesIN.Image.Save(@"LicensePlate\" + TextLicensePlate + ".png", ImageFormat.Png);
                    DataProvider.Ins.DB.SaveChanges();
                    txb_CarIdIN.Text = checkInout.CheckInOutID.ToString();
                    MessageBox.Show("Thêm xe vào bãi thành công");
                    this.Alert("Thêm xe vào bãi thành công", Form_Alert.enmType.Success);
                }
                catch (Exception)
                {
                    this.Alert("Thêm xe vào bãi thất bại", Form_Alert.enmType.Error);
                }
               
                UpdateImageBoxIN();
            }
            else {//// xe không đặt chỗ
                
                DateTime CheckInTime = DateTime.Now;
                pictureBox_miniIN.Image = ImgLicensePlate;
                txb_TimeCheckIn.Text = CheckInTime.ToString("dd/MM/yyyy hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                pictureBox_LicensePlatesIN.Image = grayframe;
                Car car = HandleDataDB.Ins.GetCarbyLicensePlate(TextLicensePlate);
                if (car == null)
                {
                    Car newCar = new Car()
                    {
                        CarType = "OT",
                        CarName = "Ô tô",
                        LicensePlate = TextLicensePlate
                    };
                    car = newCar;
                    HandleDataDB.Ins.InsertCar(car);
                }
                ParkingSpace Vacancy = HandleDataDB.Ins.FindaVacancy();
                //Save checkin
                CheckInOut checkInOut = new CheckInOut()
                {
                    CarID = car.CarID,
                    SpaceID = Vacancy.SpaceID,
                    CheckInTime = CheckInTime,
                    CheckOutTime = null,
                    TotalCost = 50000,
                    Status = "Đang đỗ xe"
                };
                Vacancy.Availability = "Đang đỗ xe";
                pictureBox_LicensePlatesIN.Image.Save(@"LicensePlate\" + car.LicensePlate + ".png", ImageFormat.Png);
                DataProvider.Ins.DB.SaveChanges();
                txb_CarIdIN.Text = checkInOut.CheckInOutID.ToString();
                if (HandleDataDB.Ins.InsertCheckInOut(checkInOut))
                {
                    MessageBox.Show("Thêm xe vào bãi thành công");
                    this.Alert("Thêm xe vào bãi thành công", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("Thêm xe vào bãi thất bại", Form_Alert.enmType.Error);
                }
                UpdateImageBoxIN();
            }
            
        }
        private void UpdateImageBoxIN()
        {
            pictureBox_XeVAO.Image = null;
            pictureBox_miniIN.Image = null;
            pictureBox_LicensePlatesIN.Image = null;
            txb_TimeCheckIn.Text = "";
            text_BiensoVAO.Text = "";
            txb_CarIdIN.Text = "";
        }
        private void UpdateImageBoxOUT()
        {
            pictureBox_miniOUT.Image = null;
            pictureBox_XERA.Image = null;
            pictureBox_LicensePlatesOUT.Image = null;
            text_BiensoRA.Text = "";
            txb_TimeCheckOut.Text = "";
            txb_CarIdOUT.Text = "";
        }
        private void UpdateImageBoxCMP()
        {
            picBox_cmpIN.Image = null;
            picBox_cmpOUT.Image = null;
            /*pictureBox_LicensePlatesIN.Image = null;
            txb_TimeCheckIn.Text = "";
            text_BiensoVAO.Text = "";
            txb_CarId.Text = "";*/
        }
        string SubDateTime(DateTime time1, DateTime time2)
        {
            TimeSpan timeDiff = time1 - time2;
            string result = string.Format("{0:00} giờ {1:00} phút", (int)timeDiff.TotalHours, timeDiff.Minutes);
            return result;
        }
        [Obsolete]
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            fInputCardID fInputCardID = new fInputCardID();
            var txb_SelectcardID = GetChildrenControl("txb_SelectcardID", fInputCardID);
            GetChildrenControl("btn_Ok", fInputCardID).Click += (senders, ev) => fInputCardID.Close();          
            fInputCardID.ShowDialog();
            if (string.IsNullOrEmpty(txb_SelectcardID.Text))
            {
                MessageBox.Show("ID thẻ không hợp lệ");
                return;
            }
           
            if (string.IsNullOrEmpty(txb_SelectcardID.Text))
            {
                MessageBox.Show("ID thẻ không hợp lệ");
                return;
            }
            else
            {

                txb_CarIdOUT.Text = txb_SelectcardID.Text;
                var checkInOut = HandleDataDB.Ins.GetCheckInOut(Convert.ToInt32(txb_SelectcardID.Text));
                var TimeCheckOut = DateTime.Now;
                if (checkInOut != null)
                {
                    if(checkInOut.Status == "Ðã đặt chỗ")
                    {
                        MessageBox.Show("Không thể cho ra xe mới đặt chỗ");
                        return ;
                    }
                    OpenFileDialog dlg = new OpenFileDialog();
                    dlg.Filter = "Image (*.bmp; *.jpg; *.jpeg; *.png) |*.bmp; *.jpg; *.jpeg; *.png|All files (*.*)|*.*||";
                    dlg.InitialDirectory = Application.StartupPath + "\\ImageTest";
                    if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    {
                        return;
                    }
                    string startupPath = dlg.FileName;

                    Image ImgLicensePlate;
                    string TextLicensePlate, temp3;
                    FindText = new FindTextLicensePlate();
                    Bitmap grayframe = FindText.Reconize(startupPath, out ImgLicensePlate, out TextLicensePlate, out temp3);
                    pictureBox_XERA.Image = ImgLicensePlate;
                    if (temp3 == "")
                    {
                        text_BiensoRA.Text = "Cannot recognize license plate !"; 
                        return ;
                    }
                    else             
                    {
                        text_BiensoRA.Text = TextLicensePlate;
                        txb_TimeCheckOut.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                        pictureBox_miniOUT.Image = ImgLicensePlate;
                        pictureBox_LicensePlatesOUT.Image = grayframe;
                        picBox_cmpOUT.Image = grayframe;
                        picBox_cmpIN.Image = FindText.ProcessImage(Application.StartupPath + "\\LicensePlate\\" + checkInOut.Car.LicensePlate + ".png");
                        txt_cpmLicensePlateIN.Text = checkInOut.Car.LicensePlate;
                        txt_cpmLicensePlateOUT.Text = TextLicensePlate;
                        txb_totalCost.Text = checkInOut.TotalCost.ToString();
                        txt_dayIN.Text = checkInOut.CheckInTime?.ToString("dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                        txt_dayOUT.Text = TimeCheckOut.ToString("dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                        txt_hourIN.Text = checkInOut.CheckInTime?.ToString("hh:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                        txt_hourOUT.Text = TimeCheckOut.ToString("hh:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                        txb_duration.Text = SubDateTime(TimeCheckOut, (DateTime)checkInOut.CheckInTime);
                        if (!string.Equals(checkInOut.Car.LicensePlate, TextLicensePlate))
                        {
                            txb_message.Text = "BIỂN SỐ KHÁC";
                            txb_message.StateCommon.Back.Color1 = System.Drawing.Color.LightCoral;
                            pc_Statusicon.Image = Resource.closeIcon;
                            btn_Done.Enabled = false;
                        }
                        else
                        {
                            txb_message.Text = "BIỂN SỐ GIỐNG";
                            txb_message.StateCommon.Back.Color1 = System.Drawing.Color.LightGreen;
                            pc_Statusicon.Image = Resource.checkIcon;
                            btn_Done.Enabled = true;
                            btn_Done.Click += (senderr, args) =>
                            {
                                checkInOut.Status = "Đã xong";
                                checkInOut.CheckOutTime = TimeCheckOut;
                                checkInOut.ParkingSpace.Availability = "Trống";
                                DataProvider.Ins.DB.SaveChanges();
                                this.Alert("Cho ra thành công", Form_Alert.enmType.Success);
                                btn_Done.Enabled = false;
                                UpdateImageBoxOUT();
                                UpdateRestCheck();
                            };
                        }
                    }
                        
                }
            }
        }
        private void UpdateRestCheck()
        {
            txb_message.Text = "";
            txb_message.StateCommon.Back.Color1 = System.Drawing.Color.White;
            pc_Statusicon.Image = null;
            picBox_cmpOUT.Image = null;
            picBox_cmpIN.Image = null;
            txt_cpmLicensePlateIN.Text = "";
            txt_cpmLicensePlateOUT.Text = "";
            txb_totalCost.Text = "";
            txt_dayIN.Text = "";
            txt_dayOUT.Text = "";
            txt_dayOUT.Text = "";
            txt_hourIN.Text = "";
            txt_hourOUT.Text = "";
            txb_duration.Text = "";
        }
        private void btn_detail_Click(object sender, EventArgs e)
        {
            fDetailCheckInOut fDetailCheckInOut = new fDetailCheckInOut();
            fDetailCheckInOut.ShowDialog();
        }
    }
}
