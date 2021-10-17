using System.Globalization;

namespace Hotel.Model
{
    public class Room
    {
        private string _id;
        private string _descr;
        private TypeRoom _type;
        public enum TypeRoom
        {
            Single,
            Double
        }
        public Room() {}
        public string ID
        {
            get => _id;
            set => _id = value;
        }
        public string Descr
        {
            get => _descr;
            set => _descr = value;
        }
        public TypeRoom RoomType
        {
            get => _type;
            set => _type = value;
        }
        public override string ToString()
        {
            return " ROOM ==> " + " ID: " + ID + " Description: " + Descr + " TypeRoom: " + RoomType;
        }
    }
}
