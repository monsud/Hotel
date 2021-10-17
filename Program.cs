using System;
using System.Globalization;
using Hotel.Model;
using static Hotel.Model.Rate;
using static Hotel.Model.Room;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            CHotel myHotel = new CHotel();
            bool room1 = myHotel.CreateRoom("123", "Venere", TypeRoom.Single);
            bool room2 = myHotel.CreateRoom("243", "Saturno", TypeRoom.Double);
            bool room3 = myHotel.CreateRoom("244", "Plutone", TypeRoom.Double);
            bool room4 = myHotel.CreateRoom("859", "Giove", TypeRoom.Double);
            bool room5 = myHotel.CreateRoom("364", "Luna", TypeRoom.Single);

            Rate rate1 = new Rate(TypeRoomRate.Single, TypeTreat.Full, 50);
            Rate rate2 = new Rate(TypeRoomRate.Double, TypeTreat.Half, 30);

            bool user1 = myHotel.CreateUser("ppb", "pippo", "baudo", "roma", "roma", "pippogmail", "0287", "3456");
            bool user2 = myHotel.CreateUser("srn", "serena", "gnossi", "bari", "bari", "serelive", "0875", "9875");
            bool user3 = myHotel.CreateUser("lcr", "lucio", "russi", "napoli", "napoli", "lurussi", "0814", "3678");
            bool user4 = myHotel.CreateUser("vln", "viola", "napoli", "marano", "napoli", "violalib", "0819", "6874");
            bool user5 = myHotel.CreateUser("lud", "luigi", "destro", "ro", "milano", "destrolui", "0587", "6489");

            bool res1 = myHotel.CreateReservation(DateTime.Parse("24/10/2020 12:00:00", CultureInfo.CurrentCulture), DateTime.Parse("27/10/2020 12:00:00", CultureInfo.CurrentCulture), 100, "ppb", "123", rate1);
            bool res2 = myHotel.CreateReservation(DateTime.Parse("28/10/2020 12:00:00", CultureInfo.CurrentCulture), DateTime.Parse("30/10/2020 12:00:00", CultureInfo.CurrentCulture), 150, "srn", "123", rate1);
            bool res3 = myHotel.CreateReservation(DateTime.Parse("26/10/2020 12:00:00", CultureInfo.CurrentCulture), DateTime.Parse("29/10/2020 12:00:00", CultureInfo.CurrentCulture), 150, "lud", "123", rate2);
            bool res4 = myHotel.CreateReservation(DateTime.Parse("26/10/2020 12:00:00", CultureInfo.CurrentCulture), DateTime.Parse("29/10/2020 12:00:00", CultureInfo.CurrentCulture), 150, "lcr", "364", rate1);
            bool serv1 = myHotel.AddServiceInReservation("123", Service.TypeService.Minibar, 10, 2);
            bool serv2 = myHotel.AddServiceInReservation("123", Service.TypeService.Internet, 5, 6);
            double tot = myHotel.TotPriceListOfService();
        }
    }
}
