using SmartParking.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartParking.GUI.UserControls
{
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard()
        {
            InitializeComponent();
            var refreshData = LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData == true)
            {
                chartGrossRevenue.DataSource = GrossRevenueList;
                chartGrossRevenue.Series[0].XValueMember = "Date";
                chartGrossRevenue.Series[0].YValueMembers = "TotalAmount";
                chartGrossRevenue.DataBind();
            }
        }

        private void lblTotalProfit_Click(object sender, EventArgs e)
        {

        }
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int NumOrders { get; set; }
        public decimal TotalRevenue { get; set; }
        public struct RevenueByDate
        {
            public string Date { get; set; }
            public decimal TotalAmount { get; set; }
        }
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;
                GeCheckInOutrAnalysis();
                return true;
            }
            else
            {
                return false;
            }
        }
        private void GeCheckInOutrAnalysis()
        {
            GrossRevenueList = new List<RevenueByDate>();
            TotalRevenue = 0;

            var context = DataProvider.Ins.DB;
            var checkInsOuts = context.CheckInOuts
            .Where(c => c.CheckInTime >= startDate && c.CheckInTime <= endDate)
            .GroupBy(c => c.CheckInTime.Value)
            .Select(g => new
            {
                CheckInTime = g.Key,
                TotalCost = g.Sum(c => c.TotalCost)
            })
            .ToList();

            var resultTable = checkInsOuts.Select(c => new KeyValuePair<DateTime, decimal>(c.CheckInTime, (decimal)c.TotalCost)).ToList();

            TotalRevenue = resultTable.Sum(r => r.Value);
            if (numberDays <= 1)
            {
                GrossRevenueList = resultTable
                    .GroupBy(r => r.Key.ToString("hh tt"))
                    .Select(g => new RevenueByDate
                    {
                        Date = g.Key,
                        TotalAmount = g.Sum(r => r.Value)
                    })
                    .ToList();
            }
            else if (numberDays <= 30)
            {
                GrossRevenueList = resultTable
                    .GroupBy(r => r.Key.ToString("dd MMM"))
                    .Select(g => new RevenueByDate
                    {
                        Date = g.Key,
                        TotalAmount = g.Sum(r => r.Value)
                    })
                    .ToList();
            }
            else if (numberDays <= 92)
            {
                GrossRevenueList = resultTable
                    .GroupBy(r => CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(r.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday))
                    .Select(g => new RevenueByDate
                    {
                        Date = "Week " + g.Key.ToString(),
                        TotalAmount = g.Sum(r => r.Value)
                    })
                    .ToList();
            }
            else if (numberDays <= (365 * 2))
            {
                bool isYear = numberDays <= 365;
                GrossRevenueList = resultTable
                    .GroupBy(r => r.Key.ToString("MMM yyyy"))
                    .Select(g => new RevenueByDate
                    {
                        Date = isYear ? g.Key.Substring(0, g.Key.IndexOf(" ")) : g.Key,
                        TotalAmount = g.Sum(r => r.Value)
                    })
                    .ToList();
            }
            else
            {
                GrossRevenueList = resultTable
                    .GroupBy(r => r.Key.ToString("yyyy"))
                    .Select(g => new RevenueByDate
                    {
                        Date = g.Key,
                        TotalAmount = g.Sum(r => r.Value)
                    })
                    .ToList();
            }
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            var refreshData = LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData == true)
            {

                chartGrossRevenue.DataSource = GrossRevenueList;
                chartGrossRevenue.Series[0].XValueMember = "Date";
                chartGrossRevenue.Series[0].YValueMembers = "TotalAmount";
                chartGrossRevenue.DataBind();
            }
        }
    }
}
