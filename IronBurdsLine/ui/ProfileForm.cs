using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronBurdsLine.domain;

namespace IronBurdsLine.ui
{
    public partial class ProfileForm : Form
    {
        private MainForm form;
        public ProfileForm(MainForm owner)
        {
            InitializeComponent();
            form = owner;
            this.label1.Text = "";
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (this.login.Text == "" || this.password.Text == "")
            {
                if (this.login.Text == "")
                {
                    this.login.ForeColor = Color.Red;
                    this.login.Text = "Введите логин";
                }
                if (this.password.Text.Length == 0)
                {
                    this.password.UseSystemPasswordChar = false;
                    this.password.ForeColor = Color.Red;
                    this.password.Text = "Введите пароль";
                }
                return;
            }

            Service service = Service.getInstance();
            if (service.LoginPassenger(login.Text, password.Text) != null)
            {
                    form.Pass = service.LoginPassenger(login.Text, password.Text);
                    form.btnProfile.Visible = false;
                    form.nameLabel.Visible = true;
                    form.surnameLabel.Visible = true;
                    form.picturBoxProfile.Visible = true;
                    form.nameLabel.Text = form.Pass.nam;
                    form.surnameLabel.Text = form.Pass.surnam;
                    form.panelForm.Controls.Clear();
                    form.panelForm.Controls.Clear();
                BonusForm bonusForm = new BonusForm(form.Pass) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                bonusForm.FormBorderStyle = FormBorderStyle.None;
                form.panelForm.Controls.Add(bonusForm);
                bonusForm.Show();
            }
            else
            {

                label1.ForeColor = Color.Red;
                label1.Text = "Пользователь не был найден";
            }
        }

        private void regist_akk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Controls.Clear();
            RegistrForm registr = new RegistrForm(form) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            registr.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(registr);
            registr.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.password.UseSystemPasswordChar == true)
            {
                this.password.UseSystemPasswordChar = false;
            }
            else
            {
                this.password.UseSystemPasswordChar = true;
            }
        }

        private void login_TextChanged(object sender, EventArgs e)
        {
            if (this.login.ForeColor == Color.Red)
            {
                this.login.Text = "";
                this.login.ForeColor = Color.Black;
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            this.password.UseSystemPasswordChar = true;
            if (this.password.ForeColor == Color.Red)
            {
                this.password.Text = "";
                this.password.ForeColor = Color.Black;
            }
        }
    }
}
