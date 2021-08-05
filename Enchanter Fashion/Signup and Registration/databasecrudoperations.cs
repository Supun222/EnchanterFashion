using Enchanter_Fashion.DBConnection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enchanter_Fashion.Signup_and_Registration
{
    public class databasecrudoperations
    {
        public string username, newusername, email, name, phonenumber, gender, bookname, schoolname, password;

        public databasecrudoperations()
        {

        }

        databasecrudoperations(string newusername, string email, string password)
        {
            this.newusername = newusername;
            this.email = email;
            this.password = password;
        }

        databasecrudoperations(string name, string phonenumber, string bookname, string schoolname, string gender)
        {
            //this
        }


        public bool checklogin(string username, string password)
        {
            try
            {
                int withuser__count=0, Withemial_count=0;
                MySqlConnection con = DBConection.getconnection();
                string query = "SELECT COUNT(username) AS count FROM registration WHERE username = '" + username + "' AND password ='" + password + "';";
                Console.WriteLine(query);
                MySqlCommand mycmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader dr = mycmd.ExecuteReader();
                while (dr.Read())
                {
                    withuser__count = dr.GetInt32("count");
                }
                con.Close();

                query = "SELECT COUNT(email) AS count FROM registration WHERE email = '" + username + "' AND password ='" + password + "';";
                mycmd = new MySqlCommand(query, con);
                con.Open();
                dr = mycmd.ExecuteReader();
                while (dr.Read())
                {
                    Withemial_count = dr.GetInt32("count");
                }
                con.Close();

                if(withuser__count == 1 || Withemial_count == 1)
                {
                    if(withuser__count == 1)
                    {
                        query = "SELECT name FROM registration WHERE username = '" + username + "';";
                    }
                    else
                    {
                        query = "SELECT name FROM registration WHERE email = '" + username + "';";
                    }
                    mycmd = new MySqlCommand(query, con);
                    con.Open();
                    dr = mycmd.ExecuteReader();
                    while (dr.Read())
                    {
                        this.username = dr.GetString("name").ToString();
                    }
                    con.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException exp)
            {

            }
            return false;
        }
    }
}
