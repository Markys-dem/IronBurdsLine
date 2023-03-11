using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using IronBurdsLine.domain.Pass;
using IronBurdsLine.domain.CompanyFlight;
using IronBurdsLine.domain;

namespace IronBurdsLine.ui
{
    public partial class BuyForm : Form
    {
        private Passenger pass;
        private MainForm form;

        public Passenger Pass { get => pass; set => pass = value; }
        public MainForm Form { get => form; set => form = value; }

        public BuyForm(Passenger passenger, MainForm owner)
        {
            InitializeComponent();
            Pass = passenger;
            Form = owner;

        }

        private void BuyForm_Load(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(tbxDepart.Text == "" || tbxArrive.Text == "")
            {
                if (tbxDepart.Text == "")
                {
                    tbxDepart.ForeColor = Color.Red;
                    tbxDepart.Text = "Заполните поле";
                    tbxDepart.ForeColor = Color.Black;
                }
                if (tbxArrive.Text == "")
                {
                    tbxArrive.ForeColor = Color.Red;
                    tbxArrive.Text = "Заполните поле";
                    tbxArrive.ForeColor = Color.Black;
                }
                return;
            }

            Service service = Service.getInstance();
            List<AirFlights> flights = service.showFlights(tbxDepart.Text, tbxArrive.Text, dtpDatePicker.Value.Date);
            if(flights == null || flights.Count == 0)
            {
                MessageBox.Show("Билеты не были найдены");
                return;
            }
            else
            {
                form.panelForm.Controls.Clear();
                ShowTicketForm infoForm = new ShowTicketForm(flights,pass) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                infoForm.FormBorderStyle = FormBorderStyle.None;
                form.panelForm.Controls.Add(infoForm);
                infoForm.Show();
            }
        }
    }
}
