using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace registration.Models
{
    public class DBModel
    {
        public MySqlConnection conn;
        private string conString;
        private string server;
        private string database;
        private string username;
        private string password;
        public DBModel()
        {
            this.server = "localhost";
            this.database = "registration";
            conString = "Server="+ this.server+
                ";Database="+this.database+
                ";Uid="+this.username+
                ";Pwd="+this.password;

            // You might have to manually add in the password field in the connection string.

            conn = new MySqlConnection(conString);

        }
                

    }

}
