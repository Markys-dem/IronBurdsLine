using System;
using System.Collections.Generic;
using System.Windows.Forms;
using IronBurdsLine.domain.CompanyFlight;
using IronBurdsLine.domain.Pass;
using IronBurdsLine.domain;

namespace IronBurdsLine.ui
{
    public partial class ShowTicketForm : Form
    {
        private List<AirFlights> airs;
        private Passenger passenger;
        private Dictionary<AirFlights, Button> mapbtn;
        public List<AirFlights> Airs { get => airs; set => airs = value; }
        public Passenger Passenger { get => passenger; set => passenger = value; }
        public Dictionary<AirFlights, Button> Mapbtn { get => mapbtn; set => mapbtn = value; }

        public ShowTicketForm(List<AirFlights> flights, Passenger pass)
        {
            InitializeComponent();
            Passenger = pass;
            Airs = flights;
            List<Panel> listControl = new List<Panel>();
            mapbtn = new Dictionary<AirFlights, Button>();
            foreach (Control x in this.Controls)
            {
                if (x is Panel)
                {
                    x.Visible = false;
                }
            }
            for (int i=0; i<flights.Count; i++)
            {
                if (i == 0)
                {
                    Flights1.Visible = true;
                    depart1.Text = flights[i].Airdepart;
                    arriv1.Text = flights[i].AirArriv;
                    timeDep1.Text = flights[i].Depart.ToString("HH:mm");
                    timeArriv1.Text = flights[i].Arriv.ToString("HH:mm");
                    timeFly1.Text = (flights[i].Arriv - flights[0].Depart).Hours.ToString();
                    numFlights1.Text = flights[i].NumberFlight;
                    price1.Text = flights[i].Price.ToString() + " IBL Bonus";
                    mapbtn.Add(flights[i], btnbuy1);
                }
                else if (i==1)
                {
                    Flights2.Visible = true;
                    depart2.Text = flights[i].Airdepart;
                    arriv2.Text = flights[i].AirArriv;
                    timeDep2.Text = flights[i].Depart.ToString("HH:mm");
                    timeArriv2.Text = flights[i].Arriv.ToString("HH:mm");
                    timeFly2.Text = (flights[i].Arriv - flights[i].Depart).Hours.ToString();
                    numFlights2.Text = flights[i].NumberFlight;
                    price2.Text = flights[i].Price.ToString() + " IBL Bonus";
                    mapbtn.Add(flights[i], btnbuy2);
                }
                else if (i == 2)
                {
                    Flights3.Visible = true;
                    depart3.Text = flights[i].Airdepart;
                    arriv3.Text = flights[i].AirArriv;
                    timeDep3.Text = flights[i].Depart.ToString("HH:mm");
                    timeArriv3.Text = flights[i].Arriv.ToString("HH:mm");
                    timeFly3.Text = (flights[i].Arriv - flights[i].Depart).Hours.ToString();
                    numFlights3.Text = flights[i].NumberFlight;
                    price3.Text = flights[i].Price.ToString() + " IBL Bonus";
                    mapbtn.Add(flights[i], btnbuy3);
                }
                else if (i == 3)
                {
                    Flights4.Visible = true;
                    depart4.Text = flights[i].Airdepart;
                    arriv4.Text = flights[i].AirArriv;
                    timeDep4.Text = flights[i].Depart.ToString("HH:mm");
                    timeArriv4.Text = flights[i].Arriv.ToString("HH:mm");
                    timeFly4.Text = (flights[i].Arriv - flights[i].Depart).Hours.ToString();
                    numFlights4.Text = flights[i].NumberFlight;
                    price4.Text = flights[i].Price.ToString() + " IBL Bonus";
                    mapbtn.Add(flights[i], btnbuy4);
                }
                else if (i == 4)
                {
                    Flights5.Visible = true;
                    depart5.Text = flights[i].Airdepart;
                    arriv5.Text = flights[i].AirArriv;
                    timeDep5.Text = flights[i].Depart.ToString("HH:mm");
                    timeArriv5.Text = flights[i].Arriv.ToString("HH:mm");
                    timeFly5.Text = (flights[i].Arriv - flights[i].Depart).Hours.ToString();
                    numFlights5.Text = flights[i].NumberFlight;
                    price5.Text = flights[i].Price.ToString()+" IBL Bonus";
                    mapbtn.Add(flights[i], btnbuy5);
                }
            }
        }

        private void btnbuy1_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            foreach (var x in Mapbtn)
            {
                if (x.Value == btn)
                {
                    try
                    {
                        Service service = Service.getInstance();
                        service.buyTicket(passenger,x.Key);
                        MessageBox.Show("Успешно куплен билет на рейс " + x.Key.NumberFlight + "\n" + "Со счёта списано: " + x.Key.Price);
                    }
                    catch (System.Exception ex)
                    {
                        
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void ShowTicketForm_Load(object sender, EventArgs e)
        {
          
        }
    }
}
