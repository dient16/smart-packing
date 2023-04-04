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
            Grid_CheckInOut.DataSource = HandleDataDB.Ins.GetListCheckInOut();
        }
    }
}
