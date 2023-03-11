using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IronBurdsLine.domain.Pass
{
    public class Passenger
    {
        private int index;
        public int Index { get => index; set => index = value; }

        private DateTime birthday;
        public DateTime dateBirth
        {
            get { return birthday; }
            set { birthday = value; }
        }
        
        private string surname;
        public string surnam
        {
            get { return surname; }
            set { surname = value; }
        }
        
        private string name;
        public string nam
        {
            get { return name; }
            set { name = value; }
        }
        private string otchestvo;
        public string otches
        {
            get { return otchestvo; }
            set { otchestvo = value; }
        }
        
        private string numberAndSeries;
        public string numAndSer
        {
            get { return numberAndSeries; }
            set { numberAndSeries = value; }
        }
        
        private string numberPhone;
        public string phone
        {
            get { return numberPhone; }
            set { numberPhone = value; }
        }
        //login
        private string email;
        public string mail
        {
            get { return email; }
            set { email = value; }
        }

        private string password;
        public string pass
        {
            get { return password; }
            set { password = value; }
        }


        private  int bonus;
        public int Bonus { get => bonus; set => bonus = value; }



        public Passenger() { }
        public Passenger(int i, DateTime birth, string surn, string nam, string otches, string numSer,
            string phone, string mail, string pass, int IBLbonus)
        {
            index = i;
            birthday = birth;
            surname = surn;
            name = nam;
            otchestvo = otches;
            numberAndSeries = numSer;
            numberPhone = phone;
            email = mail;
            password = pass;
            bonus = IBLbonus;
        }

        public Passenger(DateTime birth, string surn, string nam, string otches, string numSer,
            string phone, string mail, string pass)
        {
            index = -1;
            birthday = birth;
            surname = surn;
            name = nam;
            otchestvo = otches;
            numberAndSeries = numSer;
            numberPhone = phone;
            email = mail;
            password = pass;

        }
    }
}
