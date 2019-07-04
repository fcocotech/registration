using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace registration.Models
{
    public class UserModel
    {
        public int id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string st_addr { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public string tel { get; set; }
        public string email { get; set; }

        private DBModel dbconn;

        public void AddUserEF()
        {
            using(CMSContext cntxt = new CMSContext())
            {
                cntxt.Database.EnsureCreated();
                cntxt.User.Add(new UserModel
                {
                    fname = this.fname,
                    lname = this.lname,
                    username = this.username,
                    password = this.password,
                    st_addr = this.st_addr,
                    city = this.city,
                    zip = this.zip,
                    tel = this.tel,
                    email = this.email
                });

                cntxt.SaveChanges();
            }
        }
        public void AddUser()
        {
            this.dbconn = new DBModel();
            this.dbconn.conn.Open();
            MySqlCommand cmd;
            try
            {
                cmd = this.dbconn.conn.CreateCommand();
                cmd.CommandText = "INSERT INTO tbluser VALUES ('" + this.fname + "','" + this.lname + "','" + 
                    this.username + "',SHA1('" + this.password + "'),'" + this.st_addr + "','" + this.city + 
                    "','" + this.zip + "','" + this.tel + "','" + this.email + "')";
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                this.dbconn.conn.Close();
            }
        }
    }
}
