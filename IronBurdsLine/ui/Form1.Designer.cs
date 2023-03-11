
namespace IronBurdsLine
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelNavigator = new System.Windows.Forms.Panel();
            this.btnBonus = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.picturBoxProfile = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.AutoSize = true;
            this.panelMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.panelMenu.Controls.Add(this.panelNavigator);
            this.panelMenu.Controls.Add(this.btnBonus);
            this.panelMenu.Controls.Add(this.btnBuy);
            this.panelMenu.Controls.Add(this.btnInfo);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(208, 616);
            this.panelMenu.TabIndex = 0;
            // 
            // panelNavigator
            // 
            this.panelNavigator.AutoScroll = true;
            this.panelNavigator.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelNavigator.Location = new System.Drawing.Point(0, 185);
            this.panelNavigator.Name = "panelNavigator";
            this.panelNavigator.Size = new System.Drawing.Size(5, 60);
            this.panelNavigator.TabIndex = 0;
            // 
            // btnBonus
            // 
            this.btnBonus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBonus.AutoSize = true;
            this.btnBonus.FlatAppearance.BorderSize = 0;
            this.btnBonus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBonus.Location = new System.Drawing.Point(7, 185);
            this.btnBonus.Name = "btnBonus";
            this.btnBonus.Size = new System.Drawing.Size(205, 66);
            this.btnBonus.TabIndex = 4;
            this.btnBonus.Text = "IBL Бонус";
            this.btnBonus.UseVisualStyleBackColor = true;
            this.btnBonus.Click += new System.EventHandler(this.btnBonus_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuy.AutoSize = true;
            this.btnBuy.FlatAppearance.BorderSize = 0;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Location = new System.Drawing.Point(0, 137);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(205, 60);
            this.btnBuy.TabIndex = 2;
            this.btnBuy.Text = "Покупка билета";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInfo.AutoSize = true;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(0, 77);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(205, 60);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Информация";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.CompanyLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 77);
            this.panel1.TabIndex = 0;
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Font = new System.Drawing.Font("Snap ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyLabel.Location = new System.Drawing.Point(3, 36);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(186, 24);
            this.CompanyLabel.TabIndex = 0;
            this.CompanyLabel.Text = "Iron Burds Line";
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.BackColor = System.Drawing.Color.SkyBlue;
            this.panelInfo.Controls.Add(this.btnProfile);
            this.panelInfo.Controls.Add(this.nameLabel);
            this.panelInfo.Controls.Add(this.surnameLabel);
            this.panelInfo.Controls.Add(this.picturBoxProfile);
            this.panelInfo.Location = new System.Drawing.Point(208, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(908, 77);
            this.panelInfo.TabIndex = 1;
            // 
            // btnProfile
            // 
            this.btnProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Location = new System.Drawing.Point(745, 12);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(95, 41);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Вход";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(794, 44);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 16);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "label3";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(794, 9);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(44, 16);
            this.surnameLabel.TabIndex = 0;
            this.surnameLabel.Text = "label2";
            // 
            // picturBoxProfile
            // 
            this.picturBoxProfile.Image = ((System.Drawing.Image)(resources.GetObject("picturBoxProfile.Image")));
            this.picturBoxProfile.Location = new System.Drawing.Point(738, 12);
            this.picturBoxProfile.Name = "picturBoxProfile";
            this.picturBoxProfile.Size = new System.Drawing.Size(50, 50);
            this.picturBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturBoxProfile.TabIndex = 3;
            this.picturBoxProfile.TabStop = false;
            this.picturBoxProfile.Click += new System.EventHandler(this.picturBoxProfile_Click);
            // 
            // panelForm
            // 
            this.panelForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForm.Location = new System.Drawing.Point(208, 77);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(908, 539);
            this.panelForm.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 616);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1134, 663);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IronBurdsLine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelInfo;
        public System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CompanyLabel;
        public System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Button btnBonus;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel panelNavigator;
        public System.Windows.Forms.PictureBox picturBoxProfile;
        public System.Windows.Forms.Button btnProfile;
    }
}

