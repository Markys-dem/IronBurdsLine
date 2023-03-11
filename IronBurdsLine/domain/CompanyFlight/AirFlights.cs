using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronBurdsLine.domain.CompanyFlight
{
    public class AirFlights
    {
        private int id;
        private int price;
        private string nameCompany;
        private int passengerAll;
        private int passengerFree;
        private DateTime depart;
        private DateTime arriv;
        private string airdepart;
        private string airArriv;
        private string numberFlight;

        public int Id { get => id; set => id = value; }
        public int Price { get => price; set => price = value; }
        public string NameCompany { get => nameCompany; set => nameCompany = value; }
        public int PassengerAll { get => passengerAll; set => passengerAll = value; }
        public int PassengerFree { get => passengerFree; set => passengerFree = value; }
        public DateTime Depart { get => depart; set => depart = value; }
        public DateTime Arriv { get => arriv; set => arriv = value; }
        public string Airdepart { get => airdepart; set => airdepart = value; }
        public string AirArriv { get => airArriv; set => airArriv = value; }
        public string NumberFlight { get => numberFlight; set => numberFlight = value; }

        public AirFlights( int id, int price, string nameCompany, int passengerAll, int passengerFree, DateTime depart, DateTime arriv, string airdepart, string airArriv,string numberFlights)
        {
            Id = id;
            Price = price;
            NameCompany = nameCompany;
            PassengerAll = passengerAll;
            PassengerFree = passengerFree;
            Depart = depart;
            Arriv = arriv;
            Airdepart = airdepart;
            AirArriv = airArriv;
            NumberFlight = numberFlights;
        }
    }
}
