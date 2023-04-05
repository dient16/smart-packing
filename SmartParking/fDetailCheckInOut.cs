using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartParking.Model
{
    public partial class fDetailCheckInOut : MetroFramework.Forms.MetroForm
    {
        public fDetailCheckInOut()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            var List = HandleDataDB.Ins.GetListCheckInOut();
            Grid_CheckInOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_CheckInOut.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (var item in List)
            {
                string status = item.Status;
                if (item.Status == "Ðã d? xe")
                    status = "Đã đỗ xe";
                Grid_CheckInOut.Rows.Add(item.CardID, item.LicensePlate, item.SpaceName, item.CheckInTime, item.CheckOUTTime, item.TotalCost, status);
            }
            
        }
    }
}
