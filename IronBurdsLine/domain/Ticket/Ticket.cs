using IronBurdsLine.domain.Pass;
using IronBurdsLine.domain.CompanyFlight;
using System;

namespace IronBurdsLine.domain
{
    class Ticket
    {
        private int indexPass;
        private int indexFlight;
        private string number="";
        private int id;

        public Ticket(Passenger pass, AirFlights fly){
            this.indexFlight=fly.Id;
            this.indexPass=pass.Index;
            this.number=createNumTicket();
            this.id=-1;
        }

        public Ticket(int idPass, int idAirFlight,int id, string num){
        this.indexFlight=idAirFlight;
        this.indexPass=idAirFlight;
        this.number=num;
        this.id=id;
        }

        private  string createNumTicket(){
            Random rnd = new Random();
            int value = rnd.Next(0, 9999);
            int value1=rnd.Next(0,9999);
            return value.ToString()+value1.ToString();
        }

        public int IndexPass { get => indexPass; set => indexPass = value; }
        public int IndexFlight { get => indexFlight; set => indexFlight = value; }
        public string Number { get => number; set => number = value; }
    }
}
