using System;
using System.Collections.Generic;
using System.Windows.Forms;
using IronBurdsLine.domain.Pass;
using IronBurdsLine.domain;
using IronBurdsLine.domain.CompanyFlight;

namespace IronBurdsLine.ui
{
    public partial class BonusForm : Form
    {
        private Passenger passenger;
        public Passenger Passenger { get => passenger; set => passenger = value; }

        public BonusForm(Passenger pass)
        {
            InitializeComponent();
            Service service=Service.getInstance();
            List<AirFlights> flights =service.flightPassenger(pass.Index);
            this.lb_IBLbonus.Text = pass.Bonus.ToString();
            Passenger = pass;
            if(flights.Count==0){
                LB_num.Text="Not found flights";
            }
            else{
                LB_num.Text = "Номер";
                Lb_depart.Text = "Город\nОтправления";
                lb_timeDepart.Text = "Дата\nотправления";
                lb_arriv.Text = "Город\nприбытия";
                lb_timeArriv.Text = "Дата\nприбытия";
                for(int i=0;i<flights.Count;i++){
                    numb.Text = flights[i].NumberFlight + "\n\n";
                    depart.Text = flights[i].Airdepart + "\n\n";
                    timeDepart.Text = flights[i].Depart.ToShortDateString() + "\n"+ flights[i].Depart.TimeOfDay.ToString()+"\n";
                    cityArriv.Text = flights[i].AirArriv + "\n\n";
                    timeArriv.Text = flights[i].Arriv.ToShortDateString() + "\n"+ flights[i].Arriv.TimeOfDay.ToString()+"\n";
                }
            }

        }


        private void btn_IBLBonus_Click(object sender, EventArgs e)
        {
            Service service = Service.getInstance();
            List<String> validateList = null;
            validateList = service.buyBonus(this.tbMoney.Text, Passenger);
            lb_IBLbonus.Text = Passenger.Bonus.ToString();
            tbMoney.Text = "";
        }
    }
}
