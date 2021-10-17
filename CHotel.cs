using System;
using System.Collections.Generic;
using System.Linq;
using Hotel.Model;
using static Hotel.Model.Room;
using static Hotel.Model.Service;

namespace Hotel
{
    public class CHotel
    {
        private List<User> _userList;
        private List<Room> _roomList;
        private List<Reservation> _resList;
        public CHotel()
        {
            _userList = new List<User>();
            _roomList = new List<Room>();
            _resList = new List<Reservation>();
        }
        private static int num = 1;
        static int GenerateNum()
        {
            return num++;
        }
        public bool IsCFUnique(string cf)
        {
            if (_userList.Count > 0)
                return  _userList.Any(x => x.FiscalCode == cf);
            else
                return false;
        }
        public bool IsIDUnique(string id)
        {
            if (_roomList.Count > 0)
                return _roomList.Any(x => x.ID == id);
            else
                return false;
        }
        public bool IsCorrectDate (DateTime date)
        {
            DateTime today = DateTime.Today;
            return date.Date >= today;
        }
        public bool IsRoomJustBooked(string id)
        {
            if (_resList.Count > 0)
                return _resList.Any(x => x.RoomID == id);
            else
                return false;
        }
        public bool IsBusyInCalendar (DateTime startDate, DateTime endDate, string room)
        {
            if (_resList.Count > 0)
            {
                foreach (Reservation res in _resList.Where(x => x.StartDate >= startDate))
                {
                    for (var day = startDate.Date; day.Date <= endDate; day.AddDays(1))
                    {
                        if (res.IsInTheSamePeriod(day, room))
                        {
                            return true;
                        }
                        else
                            return false;
                    }
                }              
            }            
            return false;
        }
        public bool CreateUser(string cf, string name, string surname, string city, string province, string mail, string phone, string mobile)
        {
            try
            {
                User user = new User();
                if (!IsCFUnique(cf))
                {
                    user.FiscalCode = cf;
                    user.Name = name;
                    user.Surname = surname;
                    user.City = city;
                    user.Province = province;
                    user.Mail = mail;
                    user.Phone = phone;
                    user.Mobile = mobile;
                    _userList.Add(user);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool CreateRoom(string id, string descr, TypeRoom typeRoom)
        {
            try
            {
                Room room = new Room();
                if (!IsIDUnique(id))
                {
                    room.ID = id;
                    room.Descr = descr;
                    room.RoomType = typeRoom;
                    _roomList.Add(room);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool CreateReservation(DateTime startDate, DateTime endDate, double deposit, string usercf, string roomid, Rate newRate)
        {
            try
            {
                Reservation res = new Reservation();
                if (IsCorrectDate(startDate) && !IsBusyInCalendar(startDate, endDate, roomid))
                {
                    res.StartDate = startDate;
                    res.EndDate = endDate;
                    res.Number = GenerateNum();
                    res.Deposit = deposit;
                    res.UserCF = usercf;
                    res.RoomID = roomid;
                    res.myRate = newRate;
                    _resList.Add(res);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool AddServiceInReservation (string room, TypeService type, double price, int quantity)
        {
            try
            {
                if (_resList.Count > 0)
                {
                    foreach (Reservation res in _resList.Where(x => x.RoomID == room))
                    {
                        if (res.AddService(type, price, quantity))
                            return true;
                    }
                }
                return false;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public double TotPriceListOfService()
        {
            try
            {
                if (_resList.Count > 0)
                {
                    foreach (Reservation res in _resList)
                    {
                        return res.GetTotal();
                    }
                }
                return 0;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
        public IEnumerable<Reservation> GetReservationByNumberAndYear (int number, int year)
        {
            try
            {
                var query =
                    from Reservation res in _resList
                    where res.Number == number && res.StartDate.Year == year
                    select res;
                if (query != null)
                    return query;
                else
                    return null;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public IEnumerable<Reservation> GetReservationByNameOrSurname(string name, string surname)
        {
            try
            {
                var query =
                    from Reservation res in _resList
                    join user in _userList on res.UserCF equals user.FiscalCode
                    where user.Name == name || user.Surname == surname
                    select res;
                if (query != null)
                    return query;
                else
                    return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public IEnumerable<Reservation> GetReservationByDate(DateTime start)
        {
            try
            {
                var query =
                    from Reservation res in _resList
                    where res.StartDate == start
                    select res;
                if (query != null)
                    return query;
                else
                    return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
