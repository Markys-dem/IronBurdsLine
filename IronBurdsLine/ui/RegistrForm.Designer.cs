
namespace IronBurdsLine.ui
{
    partial class RegistrForm
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
            this.ValidationList = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Number_passport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.number_phone = new System.Windows.Forms.TextBox();
            this.titel_phone = new System.Windows.Forms.Label();
            this.registr_btn = new System.Windows.Forms.Button();
            this.txb_birthday = new System.Windows.Forms.DateTimePicker();
            this.titel_birthday = new System.Windows.Forms.Label();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.titel_pass = new System.Windows.Forms.Label();
            this.txb_Otchestvo = new System.Windows.Forms.TextBox();
            this.txb_surname = new System.Windows.Forms.TextBox();
            this.titel_surname = new System.Windows.Forms.Label();
            this.titel_otchestvo = new System.Windows.Forms.Label();
            this.tx_name = new System.Windows.Forms.TextBox();
            this.titel_name = new System.Windows.Forms.Label();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.label_mail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ValidationList
            // 
            this.ValidationList.AutoSize = true;
            this.ValidationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValidationList.ForeColor = System.Drawing.Color.Maroon;
            this.ValidationList.Location = new System.Drawing.Point(290, 348);
            this.ValidationList.Name = "ValidationList";
            this.ValidationList.Size = new System.Drawing.Size(53, 20);
            this.ValidationList.TabIndex = 41;
            this.ValidationList.Text = "label4";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(114, 261);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(465, 28);
            this.checkBox1.TabIndex = 40;
            this.checkBox1.Text = "Подтверждаю обработку персанальных данных";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Number_passport
            // 
            this.Number_passport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number_passport.Location = new System.Drawing.Point(330, 211);
            this.Number_passport.Name = "Number_passport";
            this.Number_passport.Size = new System.Drawing.Size(272, 27);
            this.Number_passport.TabIndex = 35;
            this.Number_passport.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Clear_pole);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(326, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Номер и серия паспорта";
            // 
            // number_phone
            // 
            this.number_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_phone.Location = new System.Drawing.Point(22, 211);
            this.number_phone.Name = "number_phone";
            this.number_phone.Size = new System.Drawing.Size(272, 27);
            this.number_phone.TabIndex = 33;
            this.number_phone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Clear_pole);
            // 
            // titel_phone
            // 
            this.titel_phone.AutoSize = true;
            this.titel_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titel_phone.Location = new System.Drawing.Point(22, 184);
            this.titel_phone.Name = "titel_phone";
            this.titel_phone.Size = new System.Drawing.Size(162, 24);
            this.titel_phone.TabIndex = 32;
            this.titel_phone.Text = "Номер телефона";
            // 
            // registr_btn
            // 
            this.registr_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registr_btn.Location = new System.Drawing.Point(209, 295);
            this.registr_btn.Name = "registr_btn";
            this.registr_btn.Size = new System.Drawing.Size(228, 50);
            this.registr_btn.TabIndex = 31;
            this.registr_btn.Text = "Зарегистрироваться";
            this.registr_btn.UseVisualStyleBackColor = true;
            this.registr_btn.Click += new System.EventHandler(this.registr_btn_Click);
            // 
            // txb_birthday
            // 
            this.txb_birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txb_birthday.Location = new System.Drawing.Point(330, 154);
            this.txb_birthday.Name = "txb_birthday";
            this.txb_birthday.Size = new System.Drawing.Size(272, 27);
            this.txb_birthday.TabIndex = 29;
            // 
            // titel_birthday
            // 
            this.titel_birthday.AutoSize = true;
            this.titel_birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titel_birthday.Location = new System.Drawing.Point(326, 127);
            this.titel_birthday.Name = "titel_birthday";
            this.titel_birthday.Size = new System.Drawing.Size(150, 24);
            this.titel_birthday.TabIndex = 30;
            this.titel_birthday.Text = "Дата рождения";
            // 
            // txb_password
            // 
            this.txb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txb_password.Location = new System.Drawing.Point(330, 97);
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(272, 27);
            this.txb_password.TabIndex = 28;
            this.txb_password.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Clear_pole);
            // 
            // titel_pass
            // 
            this.titel_pass.AutoSize = true;
            this.titel_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titel_pass.Location = new System.Drawing.Point(326, 70);
            this.titel_pass.Name = "titel_pass";
            this.titel_pass.Size = new System.Drawing.Size(76, 24);
            this.titel_pass.TabIndex = 27;
            this.titel_pass.Text = "Пароль";
            // 
            // txb_Otchestvo
            // 
            this.txb_Otchestvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txb_Otchestvo.Location = new System.Drawing.Point(22, 154);
            this.txb_Otchestvo.Name = "txb_Otchestvo";
            this.txb_Otchestvo.Size = new System.Drawing.Size(272, 27);
            this.txb_Otchestvo.TabIndex = 26;
            this.txb_Otchestvo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Clear_pole);
            // 
            // txb_surname
            // 
            this.txb_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txb_surname.Location = new System.Drawing.Point(22, 97);
            this.txb_surname.Name = "txb_surname";
            this.txb_surname.Size = new System.Drawing.Size(272, 27);
            this.txb_surname.TabIndex = 24;
            this.txb_surname.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Clear_pole);
            // 
            // titel_surname
            // 
            this.titel_surname.AutoSize = true;
            this.titel_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titel_surname.Location = new System.Drawing.Point(18, 70);
            this.titel_surname.Name = "titel_surname";
            this.titel_surname.Size = new System.Drawing.Size(91, 24);
            this.titel_surname.TabIndex = 23;
            this.titel_surname.Text = "Фамилия";
            // 
            // titel_otchestvo
            // 
            this.titel_otchestvo.AutoSize = true;
            this.titel_otchestvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titel_otchestvo.Location = new System.Drawing.Point(18, 127);
            this.titel_otchestvo.Name = "titel_otchestvo";
            this.titel_otchestvo.Size = new System.Drawing.Size(98, 24);
            this.titel_otchestvo.TabIndex = 25;
            this.titel_otchestvo.Text = "Отчество";
            // 
            // tx_name
            // 
            this.tx_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tx_name.Location = new System.Drawing.Point(22, 40);
            this.tx_name.Name = "tx_name";
            this.tx_name.Size = new System.Drawing.Size(272, 27);
            this.tx_name.TabIndex = 22;
            this.tx_name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Clear_pole);
            // 
            // titel_name
            // 
            this.titel_name.AutoSize = true;
            this.titel_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titel_name.Location = new System.Drawing.Point(22, 13);
            this.titel_name.Name = "titel_name";
            this.titel_name.Size = new System.Drawing.Size(46, 24);
            this.titel_name.TabIndex = 21;
            this.titel_name.Text = "Имя";
            // 
            // tb_mail
            // 
            this.tb_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_mail.Location = new System.Drawing.Point(330, 40);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(272, 27);
            this.tb_mail.TabIndex = 42;
            this.tb_mail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Clear_pole);
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_mail.Location = new System.Drawing.Point(326, 9);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(64, 24);
            this.label_mail.TabIndex = 43;
            this.label_mail.Text = "Почта";
            // 
            // RegistrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_mail);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.ValidationList);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Number_passport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number_phone);
            this.Controls.Add(this.titel_phone);
            this.Controls.Add(this.registr_btn);
            this.Controls.Add(this.txb_birthday);
            this.Controls.Add(this.titel_birthday);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.titel_pass);
            this.Controls.Add(this.txb_Otchestvo);
            this.Controls.Add(this.txb_surname);
            this.Controls.Add(this.titel_surname);
            this.Controls.Add(this.titel_otchestvo);
            this.Controls.Add(this.tx_name);
            this.Controls.Add(this.titel_name);
            this.Name = "RegistrForm";
            this.Text = "RegistrForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ValidationList;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox Number_passport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox number_phone;
        private System.Windows.Forms.Label titel_phone;
        private System.Windows.Forms.Button registr_btn;
        private System.Windows.Forms.DateTimePicker txb_birthday;
        private System.Windows.Forms.Label titel_birthday;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.Label titel_pass;
        private System.Windows.Forms.TextBox txb_Otchestvo;
        private System.Windows.Forms.TextBox txb_surname;
        private System.Windows.Forms.Label titel_surname;
        private System.Windows.Forms.Label titel_otchestvo;
        private System.Windows.Forms.TextBox tx_name;
        private System.Windows.Forms.Label titel_name;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.Label label_mail;
    }
}