using System;

namespace Hotel.Model
{
    public class Service
    {
        private TypeService _typeserv;
        private DateTime _date;
        private int _quantity;
        private double _price;
        public Service(TypeService type, DateTime date, double price, int quantity) 
        {
            this._typeserv = type;
            this._date = date;
            this._price = price;
            this._quantity = quantity;
        }
        public enum TypeService
        {
            RoomBreakfast,
            Minibar,
            Internet,
            AdditionalBed,
            BabyCot
        }
        public TypeService ServiceType
        {
            get => _typeserv;
            set => _typeserv = value;
        }
        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }
        public int Quantity
        {
            get => _quantity;
            set => _quantity = value;
        }
        public double Price
        {
            get => _price;
            set => _price = value;
        }
        public override string ToString()
        {
            return " SERVICE ==> " + " Type: " + ServiceType + " Date: " + Date + " Quantity: " + Quantity + " Price: " + Price;
        }
    }
}
