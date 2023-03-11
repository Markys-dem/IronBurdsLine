using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using IronBurdsLine.domain.Pass;
using IronBurdsLine.domain;

namespace IronBurdsLine.ui
{
    public partial class RegistrForm : Form
    {
        private MainForm form;
        public RegistrForm(MainForm owner)
        {

            InitializeComponent();
            form = owner;
            this.ValidationList.Text = "";
        }

        private void checked_empty()
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    if ((x as TextBox).Name == "txb_Otchestvo")
                        continue;
                    if ((x as TextBox).Text == string.Empty)
                    {
                        x.ForeColor = Color.Red;
                        x.Text = "Заполните данное поле";
                    }
                }
            }
        }

        private void registr_btn_Click(object sender, EventArgs e)
        {
            List<String> listValidat;
            checked_empty();
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    if ((x as TextBox).Text == "Заполните данное поле")
                    {
                        return;
                    }
                }
            }


            var name = this.tx_name.Text;
            var sur_name = this.txb_surname.Text;
            var otchestvo = this.txb_Otchestvo.Text;
            var date_birthday = this.txb_birthday.Value;
            var number_pasport = this.Number_passport.Text;
            var email = this.tb_mail.Text;
            var phone_number = this.number_phone.Text;
            var password = this.txb_password.Text;

            Passenger passai = new Passenger();
            //setters

            Service service = Service.getInstance();
            
            try
            {
                //
                //service.addPassanger(passi);
                service.addPassenger(date_birthday, sur_name, name, otchestvo, number_pasport, phone_number, email, password, out listValidat);
                if (listValidat.Count > 0)
                {
                    this.ValidationList.Text = listValidat[0];

                }
                else if (listValidat.Count == 0)
                {
                    this.ValidationList.Text = "";
                    form.panelForm.Controls.Clear();
                    ProfileForm profileForm = new ProfileForm(form) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    profileForm.FormBorderStyle = FormBorderStyle.None;
                    form.panelForm.Controls.Add(profileForm);
                    profileForm.Show();
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Clear_pole(object sender, MouseEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.ForeColor == Color.Red)
            {
                tb.Clear();
                tb.ForeColor = Color.Black;
            }
        }
    }
}
