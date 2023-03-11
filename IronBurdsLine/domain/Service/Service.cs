using System;
using System.Collections.Generic;
using IronBurdsLine.domain.Pass;
using System.Windows.Forms;
using IronBurdsLine.db;
using IronBurdsLine.domain.CompanyFlight;

namespace IronBurdsLine.domain
{
    class Service
    {
        //Оформить ввод билетов
        //Довить условие

        private static Service instance;

        private Service() { }

        public static Service getInstance()
        {
            if (instance == null)
            {
                instance = new Service();
            }
            return instance;
        }

        private bool containsDigitsOnly(string s)
        {
            int len = s.Length;
            for (int i = 0; i < len; ++i)
            {
                char c = s[i];
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        private bool containsOnlyLetters(string s)
        {//89....17
            int len = s.Length;
            for (int i = 0; i < len; ++i)
            {
                char c = s[i];
                if (c > '0' && c < '9')
                    return false;
            }
            return true;
        }

        private bool checkEmail(string str)
        {
            if(str.IndexOf('@') != -1 && str.IndexOf('.')!=-1 && str.IndexOf('.') - str.IndexOf('@') == 5)
            {
                return true;
            }
            return false;
        }

        public void  addPassenger(DateTime date_birthday, string sur_name, string name, string otchestvo, string number_pasport, string phone_number, string email, string password, out List<String> listValidat)
        {
            //List<String> list = getValidationList(passai);
            Passenger passenger;
            listValidat = getValidationList( date_birthday,  sur_name,  name,  otchestvo,  number_pasport,  phone_number,  email,  password);
            if(listValidat.Count == 0)
            {
                passenger = new Passenger(date_birthday, sur_name, name, otchestvo, number_pasport, phone_number, email, password);
                Dao db = Dao.getInstance();
                try
                {
                    db.addPassenger(passenger);
                } catch(Exception ex)
                {
                    throw new Exception("Почта уже зарегестрирована");
                }
            }
            else
            {
                return;
            }
        }

        private List<String> getValidationList(DateTime date_birthday, string sur_name, string name, string otchestvo, string number_pasport, string phone_number, string email, string password)
        {
            List<String> validationList = new List<String>();
            if (!containsOnlyLetters(name))
            {
                validationList.Add("Неверно имя пассажира" + '\n');
            }
            if (!containsOnlyLetters(sur_name))
            {
                validationList.Add("Неверная фамилия пассажира" + '\n');
            }
            if (!containsOnlyLetters(otchestvo) && otchestvo != "")
            {
                validationList.Add("Неверно отчесво пассажира" + '\n');
            }
            if (!containsDigitsOnly(phone_number) || (phone_number.Length < 2 || phone_number.Length > 11))
            {
                validationList.Add("Неверный номер телефона" + '\n');
            }
            if (!checkEmail(email))
            {
                validationList.Add("Неверно введена почта" + '\n');
            }
            if (!containsDigitsOnly(number_pasport) || (number_pasport.Length < 10 || number_pasport.Length > 10))
            {
                validationList.Add("Неверный номер паспорта" + '\n');
            }
            if (date_birthday == DateTime.Now)
            {
                validationList.Add("Измените дату" + '\n');
            }
            if (DateTime.Now.Year - date_birthday.Year < 18)
            {
                validationList.Add("Вы несовершеннолетний" + '\n');
            }
            return validationList;
        }
        public  Passenger LoginPassenger(string login, string password)
        {
            Passenger passenger = null;
            Dao dao = Dao.getInstance();
            try
            {
                passenger = dao.login(login, password);

                
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
            return passenger;
        }

        private List<String> validationListTicket (string depart, string arriv, DateTime time)
        {
            List <String> validationList = new List<String>();
            if (!containsOnlyLetters(depart))
            {
                validationList.Add("Неправилно введён город отправления");
            }
            if (!containsOnlyLetters(arriv))
            {
                validationList.Add("Неправилно введён город прибытия");
            }
            return validationList;
        }
        public List<AirFlights> showFlights(string depart, string arriv, DateTime time)
        {
            List<String> validationList = validationListTicket(depart, arriv, time);
            if (validationList.Count == 0)
            {
                Dao dao = Dao.getInstance();
                List<AirFlights> flights = dao.getFlights(depart, arriv, time);
                return flights;
            }
            else
            {
                MessageBox.Show(validationList[0]);
            }
            return null;
        }

        private List<String> validationListBuy(string str)
        {
            List<String> validationList = new List<String>();
            if (str == "")
            {
                validationList.Add("Введите значение");
            }
            if (!containsDigitsOnly(str) || str[0]=='-')
            {
                validationList.Add("Неверное значение");
            }
            return validationList;
        }

        public List<String> buyBonus(string str, Passenger pass)
        {
            List<String> validationList = validationListBuy(str);
            if(validationList.Count == 0)
            {
                Dao dao = Dao.getInstance();
                pass.Bonus = (int)pass.Bonus + Convert.ToInt32(str);
                dao.updateBonus(pass.Bonus, pass.Index);
            }
            return validationList;
        }

        public void buyTicket(Passenger pass, AirFlights fly)
        {
            if(pass==null){
                throw new Exception("Ошибка пожалуйста авторизуйтесь");
            }
            else{
                if(pass.Bonus<fly.Price){
                  throw new Exception("Недостаточно средств");  
                }
                else{
                    try{
                        pass.Bonus=pass.Bonus-fly.Price;
                        Dao dao =Dao.getInstance();
                        dao.updateAirFlight(new Ticket(pass,fly),fly);
                        dao.updateBonus(pass.Bonus, pass.Index);
                    }catch(Exception ex){
                        throw new Exception ("Уже куплен билет на данный рейс");
                    }
                }
            }
            return;
        }

        public List<AirFlights> flightPassenger(int id){
            Dao dao=Dao.getInstance();
            return dao.AirFlightPass(id);
        }
    }
}
