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
        public User GetUserById(int id)
        {
             return DataProvider.Ins.DB.Users.FirstOrDefault(x => x.UserID == id);

        }
        public bool UpdateUser(User user)
        {
            var result = DataProvider.Ins.DB.Users.SingleOrDefault(b => b.UserID == user.UserID);
            if (result != null)
            {
                result.Username = user.Username;
                result.DisplayName = user.DisplayName;
                result.Email = user.Email;
                DataProvider.Ins.DB.SaveChanges();
                return true;
            }
            else { return false; }
        }
        public bool InsertUser(User user)
        {
            try
            {
                if (user == null)
                    return false;
                DataProvider.Ins.DB.Users.Add(user);
                DataProvider.Ins.DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteUserById(int id)
        {
            try
            {
                var itemToRemove = DataProvider.Ins.DB.Users.SingleOrDefault(x => x.UserID == id);
                if (itemToRemove != null)
                {
                    DataProvider.Ins.DB.Users.Remove(itemToRemove);
                    DataProvider.Ins.DB.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
        public ObservableCollection<Booking> GetBookingByUserId(int id)
        {
            List<Booking> result = DataProvider.Ins.DB.Bookings.Where(x => x.UserID == id).ToList();
            return new ObservableCollection<Booking>(result);
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
        //public bool FindLicensePlateFromBooking(string text)
        //{
        //    return DataProvider.Ins.DB.Bookings.FirstOrDefault(x => x.CheckInOuts. == "Trống");
        //}
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
        public int GetCountCar()
        {
            return DataProvider.Ins.DB.Cars.Where(x => true).Count();
        }
        public int GetCountCheckInOut()
        {
            return DataProvider.Ins.DB.CheckInOuts.Where(x => true).Count();
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
        public bool InsertBooking(Booking booking)
        {
            try
            {
                if (booking == null)
                    return false;
                DataProvider.Ins.DB.Bookings.Add(booking);
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
        public Booking GetBookingByparkingspace(string s)
        {
            return DataProvider.Ins.DB.Bookings.FirstOrDefault(x => x.ParkingSpace.SpaceNumber == s);
        }
        public Booking GetBookingBylicensePlate(string s)
        {
            return DataProvider.Ins.DB.Bookings.FirstOrDefault(x => x.Car.LicensePlate == s);
        }
        public CheckInOut GetCheckInOut(int idCard)
        {
            return DataProvider.Ins.DB.CheckInOuts.FirstOrDefault(x => x.CheckInOutID == idCard);
        }
        public CheckInOut GetCheckByBookingId(int id)
        {
            return DataProvider.Ins.DB.CheckInOuts.FirstOrDefault(x => x.BookingID == id);
        }
        public ObservableCollection<DetailCheckInOut> GetListCheckInOut()
        {
            List<CheckInOut> LSCheckinOut = new List<CheckInOut>();
            LSCheckinOut = DataProvider.Ins.DB.CheckInOuts.Select(x => x).ToList();
            ObservableCollection <DetailCheckInOut> LS = new ObservableCollection<DetailCheckInOut>();
            foreach (var item in LSCheckinOut)
            {
                LS.Add(new DetailCheckInOut(item.CheckInOutID, item.Car.LicensePlate, item.ParkingSpace.SpaceNumber,
                    item.CheckInTime, item.CheckOutTime, item.TotalCost, item.Status));
            }    
            return LS;
        }
        public ObservableCollection<User> GetAllUsers(string role = "ALL")
        {
            if(role == "ALL")
            {
                List<User> listUser = DataProvider.Ins.DB.Users.Select(x => x).ToList();
                return new ObservableCollection<User>(listUser);
            }
            else if (role == "2")
            {
                List<User> listUser = DataProvider.Ins.DB.Users.Where(x => x.RoleID == 2).ToList();
                return new ObservableCollection<User>(listUser);
            }
            else if (role == "3")
            {
                List<User> listUser = DataProvider.Ins.DB.Users.Where(x => x.RoleID == 3).ToList();
                return new ObservableCollection<User>(listUser);
            }
            else
            return null;
        }
    }
}
