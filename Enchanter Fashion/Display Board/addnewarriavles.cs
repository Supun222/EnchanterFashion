using Enchanter_Fashion.DBConnection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enchanter_Fashion.Display_Board
{
    class addnewarriavles
    {

        public bool checkitemnameininventory(string itemname)
        {
            int count = 0;
            try
            {
                MySqlConnection con = DBConection.getconnection();
                string query = "SELECT COUNT(item_name) AS count FROM contain_items WHERE item_name = '" + itemname + "'";
                Console.WriteLine(query);
                MySqlCommand mycmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader dr = mycmd.ExecuteReader();
                while (dr.Read())
                {
                    count = dr.GetInt32("count");
                }
                con.Close();
            }
            catch (MySqlException exp)
            {

            }

            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void updatingdisplay(string itemname, string filename, string description)
        {
            try
            {
                MySqlConnection con = DBConection.getconnection();
                string query = "insert into display(pic_file_name,item_name,description) values('" + filename + "','" + itemname + "','" + description + "')";
                Console.WriteLine(query);
                MySqlCommand mycmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader dr = mycmd.ExecuteReader();
                while (dr.Read())
                {
                }
                con.Close();
            }
            catch (MySqlException exp)
            {

            }
        }

        public bool checkitemnameindisplay(string itemname)
        {
            int count = 0;
            try
            {
                MySqlConnection con = DBConection.getconnection();
                string query = "SELECT COUNT(item_name) AS count FROM display WHERE item_name = '" + itemname + "'";
                Console.WriteLine(query);
                MySqlCommand mycmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader dr = mycmd.ExecuteReader();
                while (dr.Read())
                {
                    count = dr.GetInt32("count");
                }
                con.Close();
            }
            catch (MySqlException exp)
            {

            }

            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
