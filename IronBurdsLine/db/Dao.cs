using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using IronBurdsLine.domain.Pass;
using IronBurdsLine.domain.CompanyFlight;
using System.Data;
using MySql.Data.MySqlClient;
using IronBurdsLine.domain;

namespace IronBurdsLine.db
{
    class Dao
    {
        
        private String connectionString = "server=localhost;database=ironburdsline;user=root;password=1234;";//
        //private String tableNameMain = "Passenger";

        private static Dao instance;//

        private Dao() { }

        public static Dao getInstance()
        {
            if (instance == null)
            {
                instance = new Dao();
            }
            return instance;
        }
        public void addPassenger(Passenger passenger)
        {
            try
            {
                MySqlConnection connection = getConnection();
                MySqlCommand command = new MySqlCommand("insert into Passenger (birthday,name,surname,otchestvo, namePasport, phone, email, password,bonus)" +
                    " values(@birthday, @name, @surname, @otchestvo, @numberPasport, @phone, @mail, @password,@bonus)", connection);
                command.Parameters.AddWithValue("@birthday", passenger.dateBirth);
                command.Parameters.AddWithValue("@surname", passenger.surnam);
                command.Parameters.AddWithValue("@name", passenger.nam);
                command.Parameters.AddWithValue("@otchestvo", passenger.otches);
                command.Parameters.AddWithValue("@numberPasport", passenger.numAndSer);
                command.Parameters.AddWithValue("@phone", passenger.phone);
                command.Parameters.AddWithValue("@mail", passenger.mail);
                command.Parameters.AddWithValue("@password", passenger.pass);
                command.Parameters.AddWithValue("@bonus", 0);
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Dispose();
                command.Dispose();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public Passenger login(string login, string password)
        {
            Passenger obj = null;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlConnection connection = getConnection();
            MySqlCommand command = new MySqlCommand($"select *from Passenger as pass where pass.email = '{login}'  and pass.password = '{password}'; ", connection);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                obj = new Passenger((int)table.Rows[0][0], Convert.ToDateTime(table.Rows[0][1].ToString()), table.Rows[0][2].ToString(), table.Rows[0][3].ToString(),
                    table.Rows[0][4].ToString(), table.Rows[0][5].ToString(), table.Rows[0][6].ToString(), table.Rows[0][7].ToString(), table.Rows[0][8].ToString(), (int)table.Rows[0][9]);
            }
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Dispose();
            command.Dispose();
            return obj;

        }
        private MySqlConnection getConnection()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                return connection;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AirFlights> getFlights(string depart, string arriv, DateTime timeDepart)
        {
            
            List<AirFlights> flights = new List<AirFlights>();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlConnection connection = getConnection();
            MySqlCommand command = new MySqlCommand($"select * from airflight as AF where AF.depart LIKE '{timeDepart.ToString("yyyy-MM-dd")}%' and AF.airdepart = '{depart}'" +
                $" and AF.airArrive = '{arriv}';", connection);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    AirFlights obj = new AirFlights((int)table.Rows[i][0], (int)table.Rows[i][1], table.Rows[i][2].ToString() ,(int)table.Rows[i][3],
                    (int)table.Rows[i][4],Convert.ToDateTime(table.Rows[i][5].ToString()),Convert.ToDateTime(table.Rows[i][6].ToString()),table.Rows[i][7].ToString(),
                    table.Rows[i][8].ToString(),table.Rows[i][9].ToString());

                    flights.Add(obj);
                }
            }
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Dispose();
            command.Dispose();
            return flights;
        }

        public void updateBonus(int score, int i)
        {
            MySqlConnection connection = getConnection();
            MySqlCommand command = new MySqlCommand($"update Passenger set bonus ={score} where Passenger.id={i}", connection);
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Dispose();
            command.Dispose();
            
        }

        public void updateAirFlight(Ticket ticket, AirFlights fly){
            try{
                MySqlConnection connection = getConnection();
                MySqlCommand command = new MySqlCommand($"update airflight set passengerFree ={fly.PassengerFree-1} where id={fly.Id} ;\n"+
                $"insert into ticket(idAirFlight,idPassenger,`number`)"+
                $"values({ticket.IndexFlight},{ticket.IndexPass},{ticket.Number});" , connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Dispose();
                command.Dispose();
            }
            catch (Exception ex){
                throw new Exception(ex.Message);
            }
        }

        public List<AirFlights> AirFlightPass(int id){
            List<AirFlights> flights = new List<AirFlights>();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
             MySqlConnection connection = getConnection();
            MySqlCommand command = new MySqlCommand("select AF.* " +
                                                    "from Airflight as AF "+
                                                    "inner join ticket as tic "+ 
                                                    "on AF.id=tic.idAirFlight "+
                                                    $"where tic.idPassenger={id};", connection);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    AirFlights obj = new AirFlights((int)table.Rows[i][0], (int)table.Rows[i][1], table.Rows[i][2].ToString() ,(int)table.Rows[i][3],
                    (int)table.Rows[i][4],Convert.ToDateTime(table.Rows[i][5].ToString()),Convert.ToDateTime(table.Rows[i][6].ToString()),table.Rows[i][7].ToString(),
                    table.Rows[i][8].ToString(),table.Rows[i][9].ToString());

                    flights.Add(obj);
                }
            }
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Dispose();
            command.Dispose();
            return flights;
        }
    }
}