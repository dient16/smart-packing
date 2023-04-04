using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartParking.Model
{
    public class HandleDataDB
    {
        private static HandleDataDB _ins;
        public static HandleDataDB Ins
        {
            get
            {
                if (_ins == null)_ins = new HandleDataDB(); return _ins; }set {_ins = value;
            }
        }
        public User Accconut { get; set; }
        public void SetAccount(User acc)
        {
            Accconut = acc;
        }
        private HandleDataDB() { SetAccount(null); }
        public bool Login(string UserName, string Password, Form p)
        {
            bool IsLogin = false;
            var accCount = DataProvider.Ins.DB.Users.Where(x => x.Username == UserName && x.Password == Password).Count();

            if (accCount > 0)
            {
                IsLogin = true;
                p.Hide();
            }
            else
            {
                IsLogin = false;
            }
            return IsLogin;
        }
        public User GetUserByUsername(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                return DataProvider.Ins.DB.Users.FirstOrDefault(x => x.Username == name);
            }
            else return null;
        }
        public Car GetCarbyLicensePlate(string LicensePlate)
        {
            if(!string.IsNullOrEmpty(LicensePlate))
            {
                return DataProvider.Ins.DB.Cars.FirstOrDefault(x => x.LicensePlate == LicensePlate);
            }    
            else { return null; }
        }
        public ParkingSpace FindaVacancy()
        {
            return DataProvider.Ins.DB.ParkingSpaces.FirstOrDefault(x => x.Availability == "Trống");
        }
        public bool InsertCheckInOut(CheckInOut inOut)
        {
            try
            {
                if (inOut == null)
                    return false;
                DataProvider.Ins.DB.CheckInOuts.Add(inOut);
                DataProvider.Ins.DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool InsertCar(Car car)
        {
            try
            {
                if (car == null)
                    return false;
                DataProvider.Ins.DB.Cars.Add(car);
                DataProvider.Ins.DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public ObservableCollection<ParkingSpace> GetListParkingSpace()
        {
            ObservableCollection<ParkingSpace> LS = new ObservableCollection<ParkingSpace>();
            var ConutSpace = DataProvider.Ins.DB.ParkingSpaces.Where(x => true).Count();
            for (int i = 1; i <= ConutSpace; i++)
            {
                var space = DataProvider.Ins.DB.ParkingSpaces.FirstOrDefault(x => x.SpaceID == i);
                LS.Add(space);
            }
            return LS;
        }
        public int GetCountBooking()
        {
            return DataProvider.Ins.DB.Bookings.Where(x => true).Count();
        }
    }
}
