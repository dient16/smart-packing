using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartParking.Model
{
    public class DetailCheckInOut
    {
        public DetailCheckInOut(int _CardID, string _LicensePlate, string _SpaceName, DateTime _CheckInTime, DateTime? _CheckOUTTime, decimal _TotalCost, string _Status)
        {
            this.CardID = _CardID;
            this.LicensePlate = _LicensePlate;
            this.SpaceName = _SpaceName;
            this.CheckInTime = _CheckInTime;
            this.CheckOUTTime = _CheckOUTTime;
            this.TotalCost = _TotalCost;
            this.Status = _Status;
        }

        private int _CardID;

        public int CardID
        {
            get { return _CardID; }
            set { _CardID = value; }
        }

        private string _LicensePlate;

        public string LicensePlate
        {
            get { return _LicensePlate; }
            set { _LicensePlate = value; }
        }

        private string _SpaceName;

        public string SpaceName
        {
            get { return _SpaceName; }
            set { _SpaceName = value; }
        }

        private DateTime _CheckInTime;

        public DateTime CheckInTime
        {
            get { return _CheckInTime; }
            set { _CheckInTime = value; }
        }
        private DateTime? _CheckOUTTime;

        public DateTime? CheckOUTTime
        {
            get { return _CheckOUTTime; }
            set { _CheckOUTTime = value; }
        }
        private decimal _TotalCost;
        public decimal TotalCost
        {
            get { return _TotalCost; }
            set { _TotalCost = value; }
        }
        private string _Status;

        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
    }
}
