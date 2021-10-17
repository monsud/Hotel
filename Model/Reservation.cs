using System;
using System.Collections.Generic;
using static Hotel.Model.Service;

namespace Hotel.Model
{
    public class Reservation
    {
        private DateTime _startdate;
        private DateTime _enddate;
        private int _num;
        private double _deposit;
        private Rate _rate;
        private string _usercf;
        private string _roomid;
        private List<Service> _servicelist;
        public Reservation()
        {
            _servicelist = new List<Service>();
        }
        public DateTime StartDate
        {
            get => _startdate;
            set => _startdate = value;
        }
        public DateTime EndDate
        {
            get => _enddate;
            set => _enddate = value;
        }
        public int Number
        {
            get => _num;
            set => _num = value;
        }
        public double Deposit
        {
            get => _deposit;
            set => _deposit = value;
        }
        public Rate myRate
        {
            get => _rate;
            set => _rate = value;
        }
        public string UserCF
        {
            get => _usercf;
            set => _usercf = value;
        }
        public string RoomID
        {
            get => _roomid;
            set => _roomid = value;
        }
        public List<Service> Services
        {
            get => _servicelist;
        }
        public bool IsInTheSamePeriod(DateTime date, string room)
        {
            bool resultDateRes = date >= StartDate && date <= EndDate;
            if (!resultDateRes)
            {
                return this.RoomID == room;
            }
            return resultDateRes;
        }
        public double GetTotal()
        {
            double total = 0;
            if (_servicelist.Count > 0)
            {
                foreach (Service serv in _servicelist)
                {
                    total += serv.Price * serv.Quantity;
                }
                return total;
            }
            else
                return 0;
        }
        public bool AddService(TypeService type, double price, int quantity)
        {
            try
            {
                Service serv = new Service(type, StartDate, price, quantity);
                if (serv != null)
                {
                    _servicelist.Add(serv);
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
        public override string ToString()
        {
            return " RESERVATION ==> " + " StartDate: " + StartDate + " EndDate: " + EndDate + " Number: " + Number + " Deposit: " + Deposit + " Rate: " + myRate + " UserCF: " + UserCF + " RoomID: " + RoomID;
        }
    }
}
