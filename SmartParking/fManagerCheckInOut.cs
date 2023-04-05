using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartParking.HandleLicensePlate;
using SmartParking.Model;

namespace SmartParking
{
    public partial class fManagerCheckInOut : MetroFramework.Forms.MetroForm   
    {
        [Obsolete]
        fManagerCheckInOut _this;
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

            Image temp1;
            string temp2, temp3;
            FindText = new FindTextLicensePlate();
            int CardID = DataProvider.Ins.DB.CheckInOuts.Where(x => true).Count() + 1;
            txb_CarIdIN.Text = CardID.ToString();
            Bitmap grayframe = FindText.Reconize(startupPath, out temp1, out temp2, out temp3);
            pictureBox_XeVAO.Image = temp1;
            if (temp3 == "")
                text_BiensoVAO.Text = "Cannot recognize license plate !";
            else
                text_BiensoVAO.Text = temp2;
            DateTime CheckInTime = DateTime.Now;
            pictureBox_miniIN.Image = temp1;
            txb_TimeCheckIn.Text = CheckInTime.ToString("dd/mm/yyyy hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            pictureBox_LicensePlatesIN.Image = grayframe;
            Car car = HandleDataDB.Ins.GetCarbyLicensePlate(temp2);
            if (car == null)
            {
                Car newCar = new Car()
                {
                    CarID = DataProvider.Ins.DB.Cars.Where(x => true).Count() + 1,
                    CarType = "OT",
                    CarName = "Ô tô",
                    LicensePlate = temp2
                };
                car = newCar;
                HandleDataDB.Ins.InsertCar(car);
            }
            ParkingSpace Vacancy = HandleDataDB.Ins.FindaVacancy();
            //Save checkin
            CheckInOut checkInOut = new CheckInOut()
            {
                CheckInOutID = CardID,
                CarID = car.CarID,
                SpaceID = Vacancy.SpaceID,
                CheckInTime = CheckInTime,
                CheckOutTime = null,
                TotalCost = 50000,
                Status = "Đã đỗ xe"
            };
            if (HandleDataDB.Ins.InsertCheckInOut(checkInOut))
                MessageBox.Show("Thêm xe vào bãi thành công");
            else
                MessageBox.Show("Thêm xe vào bãi thất bại");
            Vacancy.Availability = "Đang đỗ xe";
            pictureBox_LicensePlatesIN.Image.Save(@"LicensePlate\" + car.LicensePlate + ".png", ImageFormat.Png);
            DataProvider.Ins.DB.SaveChanges();
            UpdateImageBoxIN();
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
            string result = string.Format("{0:00}:{1:00}", (int)timeDiff.TotalHours, timeDiff.Minutes);
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
            OpenFileDialog dlg = new OpenFileDialog();   
            dlg.Filter = "Image (*.bmp; *.jpg; *.jpeg; *.png) |*.bmp; *.jpg; *.jpeg; *.png|All files (*.*)|*.*||";
            dlg.InitialDirectory = Application.StartupPath + "\\ImageTest";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            string startupPath = dlg.FileName;

            Image temp1;
            string temp2, temp3;
            FindText = new FindTextLicensePlate();
            Bitmap grayframe = FindText.Reconize(startupPath, out temp1, out temp2, out temp3);
            pictureBox_XERA.Image = temp1;
            if (temp3 == "")
                text_BiensoRA.Text = "Cannot recognize license plate !";
            else
                text_BiensoRA.Text = temp2;
            txb_TimeCheckOut.Text = DateTime.Now.ToString("dd/mm/yyyy hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
           
                      
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
                    pictureBox_miniOUT.Image = temp1;
                    pictureBox_LicensePlatesOUT.Image = grayframe;
                    picBox_cmpOUT.Image = grayframe;
                    picBox_cmpIN.Image = FindText.ProcessImage(Application.StartupPath + "\\LicensePlate\\" + checkInOut.Car.LicensePlate + ".png");
                    txt_cpmLicensePlateIN.Text = checkInOut.Car.LicensePlate;
                    txt_cpmLicensePlateOUT.Text = temp2;
                    txb_totalCost.Text = checkInOut.TotalCost.ToString();
                    txt_dayIN.Text = checkInOut.CheckInTime.ToString("dd/mm/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    txt_dayOUT.Text = TimeCheckOut.ToString("dd/mm/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    txt_hourIN.Text = checkInOut.CheckInTime.ToString("hh:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    txt_hourOUT.Text = TimeCheckOut.ToString("hh:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    txb_duration.Text = SubDateTime(TimeCheckOut, checkInOut.CheckInTime);
                    if (!string.Equals(checkInOut.Car.LicensePlate, temp2))
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
                            DataProvider.Ins.DB.SaveChanges();
                            MessageBox.Show("Đã xong");
                            btn_Done.Enabled = false;
                            UpdateImageBoxOUT();
                            UpdateRestCheck();
                        };
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
