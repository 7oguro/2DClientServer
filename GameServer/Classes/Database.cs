using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.Classes
{
    public class Database
    {

        public gameserverDataSet _gameserverDS;
        private SqlConnection _sqlConnection;
        private SqlDataAdapter _sqlDataAdapter;

        public Database()
        {
            Console.WriteLine("Iniciando Base de Dados!");
            _gameserverDS = new gameserverDataSet();
            _sqlDataAdapter = new SqlDataAdapter();

            string connString = ConfigurationManager.ConnectionStrings["GameServer.Properties.Settings.gameserverConnectionString"].ToString();

            using (_sqlConnection = new SqlConnection(connString))
            {
                _sqlConnection.Open();
                if (_sqlConnection.State == ConnectionState.Open)
                    Console.WriteLine("Base de Dados Online!");

                UpdateRecords();               
            }
        }

        public void UpdateRecords()
        {
            SqlCommand usersCommand = new SqlCommand("SELECT * FROM users", _sqlConnection);
            _sqlDataAdapter.SelectCommand = usersCommand;
            _sqlDataAdapter.Fill(_gameserverDS.users);
        }
    }
}
