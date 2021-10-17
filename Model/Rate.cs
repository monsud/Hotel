using System;

namespace Hotel.Model
{
    public class Rate
    {
        private TypeRoomRate _type;
        private TypeTreat _treat;
        private double _roomprice;
        public enum TypeRoomRate
        {
            Single,
            Double
        }
        public enum TypeTreat
        {
            Half,
            Full,
            BB
        }
        public Rate(TypeRoomRate type, TypeTreat treat, double price) 
        {
            this._type = type;
            this._treat = treat;
            this._roomprice = price;
        }
        public TypeRoomRate RoomType
        {
            get => _type;
            set => _type = value;
        }
        public TypeTreat TreatType
        {
            get => _treat;
            set => _treat = value;
        }
        public double RoomPrice
        {
            get => _roomprice;
            set => _roomprice = value;
        }
        public override string ToString()
        {
            return " RATE ==> " + " TypeRoom: " + RoomType + " TypeTreat: " + TreatType  + " RoomPrice: " + RoomPrice;
        }
    }
}
