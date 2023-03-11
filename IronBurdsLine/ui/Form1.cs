using System;
using System.Windows.Forms;
using IronBurdsLine.domain.Pass;
using IronBurdsLine.ui;

namespace IronBurdsLine
{
    public partial class MainForm : Form
    {
        static private Passenger passenger;

        public MainForm()
        {
            passenger = null;
            InitializeComponent();
            this.nameLabel.Text = "";
            this.surnameLabel.Text = "";
            this.picturBoxProfile.Visible = false;
            this.panelNavigator.Visible = false;

        }

        public Passenger Pass
        {
            get { return passenger; }
            set { passenger = value; }
        }
        //Выставление чёрной полосы навигации
        private void panelNavigatorEnable(int height, int top, int left)
        {
            this.panelNavigator.Height = height;
            this.panelNavigator.Top = top;
            this.panelNavigator.Left = left;
            this.panelNavigator.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.panelForm.Controls.Clear();
            BootScreen bootScrean = new BootScreen() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            bootScrean.FormBorderStyle = FormBorderStyle.None;
            this.panelForm.Controls.Add(bootScrean);
            bootScrean.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            this.panelNavigatorEnable(btn.Height, btn.Top, btn.Left);

            this.panelForm.Controls.Clear();
            InfoForm infoForm = new InfoForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            infoForm.FormBorderStyle = FormBorderStyle.None;
            this.panelForm.Controls.Add(infoForm);
            infoForm.Show();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            this.panelNavigatorEnable(btn.Height, btn.Top, btn.Left);

            this.panelForm.Controls.Clear();
            BuyForm buyForm = new BuyForm(passenger, this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            buyForm.FormBorderStyle = FormBorderStyle.None;
            this.panelForm.Controls.Add(buyForm);
            buyForm.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            this.panelNavigatorEnable(btn.Height, btn.Top, btn.Left);

            this.panelForm.Controls.Clear();
            ReturnForm returnForm = new ReturnForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            returnForm.FormBorderStyle = FormBorderStyle.None;
            this.panelForm.Controls.Add(returnForm);
            returnForm.Show();
        }

        private void btnBonus_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            this.panelNavigatorEnable(btn.Height, btn.Top, btn.Left);

            if(passenger == null)
            {
                this.panelForm.Controls.Clear();
                ProfileForm profileForm = new ProfileForm(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                profileForm.FormBorderStyle = FormBorderStyle.None;
                this.panelForm.Controls.Add(profileForm);
                profileForm.Show();
                MessageBox.Show("Войдите в аккаунт, для просмотра бонусов");
            }
            else
            {
                this.panelForm.Controls.Clear();
                BonusForm bonusForm = new BonusForm(this.Pass) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                bonusForm.FormBorderStyle = FormBorderStyle.None;
                this.panelForm.Controls.Add(bonusForm);
                bonusForm.Show();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.panelForm.Controls.Clear();
            ProfileForm profileForm = new ProfileForm(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            profileForm.FormBorderStyle = FormBorderStyle.None;
            this.panelForm.Controls.Add(profileForm);
            profileForm.Show();
        }

        private void picturBoxProfile_Click(object sender, EventArgs e)
        {
            this.panelForm.Controls.Clear();
            BonusForm bonusForm = new BonusForm(Pass) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            bonusForm.FormBorderStyle = FormBorderStyle.None;
            this.panelForm.Controls.Add(bonusForm);
            bonusForm.Show();
        }
    }
}
