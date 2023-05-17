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
    public partial class UC_BookingHistory : UserControl
    {
        public UC_BookingHistory()
        {
            InitializeComponent();
            GetBooking();
        }
        private void GetBooking()
        {
            Grid_BookingHistory.Rows.Clear();
            var List = HandleDataDB.Ins.GetBookingByUserId(HandleDataDB.Ins.Accconut.UserID);
            Grid_BookingHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_BookingHistory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (var item in List)
            {
                Grid_BookingHistory.Rows.Add(item.BookingID,item.BookingTime, item.Status);
            }
        }
    }
}
