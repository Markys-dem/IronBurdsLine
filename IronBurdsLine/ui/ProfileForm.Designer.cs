
namespace IronBurdsLine.ui
{
    partial class ProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.Error = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.icon = new System.Windows.Forms.PictureBox();
            this.regist_akk = new System.Windows.Forms.LinkLabel();
            this.btn_enter = new System.Windows.Forms.Button();
            this.name_pass = new System.Windows.Forms.Label();
            this.name_login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Error.Location = new System.Drawing.Point(405, 410);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(0, 25);
            this.Error.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(637, 262);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // icon
            // 
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(326, 16);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(197, 127);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 15;
            this.icon.TabStop = false;
            // 
            // regist_akk
            // 
            this.regist_akk.AutoSize = true;
            this.regist_akk.Location = new System.Drawing.Point(353, 373);
            this.regist_akk.Name = "regist_akk";
            this.regist_akk.Size = new System.Drawing.Size(156, 17);
            this.regist_akk.TabIndex = 14;
            this.regist_akk.TabStop = true;
            this.regist_akk.Text = "Регистрация аккаунта";
            this.regist_akk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.regist_akk_LinkClicked);
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(353, 328);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(156, 42);
            this.btn_enter.TabIndex = 13;
            this.btn_enter.Text = "Вход";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // name_pass
            // 
            this.name_pass.AutoSize = true;
            this.name_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_pass.Location = new System.Drawing.Point(130, 267);
            this.name_pass.Name = "name_pass";
            this.name_pass.Size = new System.Drawing.Size(98, 25);
            this.name_pass.TabIndex = 12;
            this.name_pass.Text = "Password";
            // 
            // name_login
            // 
            this.name_login.AutoSize = true;
            this.name_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_login.Location = new System.Drawing.Point(130, 194);
            this.name_login.Name = "name_login";
            this.name_login.Size = new System.Drawing.Size(60, 25);
            this.name_login.TabIndex = 11;
            this.name_login.Text = "Login";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(258, 262);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(372, 30);
            this.password.TabIndex = 10;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(258, 189);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(372, 30);
            this.login.TabIndex = 9;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(353, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.regist_akk);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.name_pass);
            this.Controls.Add(this.name_login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.LinkLabel regist_akk;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Label name_pass;
        private System.Windows.Forms.Label name_login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label1;
    }
}