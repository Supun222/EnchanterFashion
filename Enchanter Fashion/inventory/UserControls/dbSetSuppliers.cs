using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;
using Enchanter_Fashion.DBConnection;
using MySql.Data.MySqlClient;

namespace Enchanter_Fashion.inventory.UserControls
{
    class dbSetSuppliers
    {
        string sql_query;
        string supId = "sup";

        public bool checkItem(string id)
        {
            int count = 0;

            try
            {
                MySqlConnection conn = DBConection.getconnection();
                sql_query = "SELECT COUNT(sup_id) AS count FROM suppliers WHERE sup_id = '" + id + "'";
                Console.WriteLine(sql_query);
                MySqlCommand mycommand = new MySqlCommand(sql_query, conn);
                conn.Open();
                MySqlDataReader myreader = mycommand.ExecuteReader();
                while (myreader.Read())
                {
                    count = myreader.GetInt32("count");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        public string autoGenerateId()
        {
            try
            {
                MySqlConnection conn = DBConection.getconnection();
                conn.Open();
                sql_query = ("SELECT COUNT(sup_id) FROM enchanterfashion.suppliers");
                //conn.Open();
                MySqlCommand myCommand = new MySqlCommand(sql_query, conn);
                int i = Convert.ToInt32(myCommand.ExecuteScalar());
                conn.Close();
                i++;
                supId = supId + i.ToString();
                return supId;

                //MySqlDataReader myReader;
                //myReader = myCommand.ExecuteReader();

                //string sup_id = 
            }
            catch (Exception ex)
            {
                throw new Exception( ex.Message);
            }
        }

        public void insertData(string name, string address, string phone,string email)
        {
            string supplierId = autoGenerateId();
            //sql_query = "INSERT into suppliers(sup_id,sup_name,sup_city,sup_mobile)  values('" + supId + "','" + name + "','" + address + "','" + phone + "')";
            try
            {
                MySqlConnection conn = DBConection.getconnection();
                sql_query = "INSERT into suppliers(sup_id,sup_name,sup_email,sup_city,sup_mobile)  values('" + supplierId + "','" + name + "','"+email+"','" + address + "','"+phone+"')";

                MySqlCommand myCommand = new MySqlCommand(sql_query, conn);
                MySqlDataReader MyReader2;
                conn.Open();
                MyReader2 = myCommand.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Data Saved");
                while (MyReader2.Read())
                {
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void editData(string id,string name, string address, string phone,string email)
        {
            //sql_query = "UPDATE suppliers SET sup_name = '" + name + "',sup_city = '" + address + "',sup_mobile = '" + phone + "' WHERE sup_id = '" + id + "' ;";
            try
            {
                MySqlConnection conn = DBConection.getconnection();
                sql_query = "UPDATE suppliers SET sup_name = '" + name + "',sup_city = '" + address + "',sup_mobile = '" + phone + "',sup_email='"+email+"' WHERE sup_id = '"+id+"' ;";

                MySqlCommand myCommand = new MySqlCommand(sql_query,conn);
                MySqlDataReader myReader;
                conn.Open();
                myReader = myCommand.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (myReader.Read())
                {

                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteData(string id, string name, string address, string phone, string email)
        {
            try
            {
                MySqlConnection conn = DBConection.getconnection();
                sql_query = "DELETE from suppliers where sup_id='" +id+ "';";

                MySqlCommand myCommand = new MySqlCommand(sql_query, conn);
                MySqlDataReader MyReader;
                conn.Open();
                MyReader = myCommand.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Data Deleted");
                while (MyReader.Read())
                {
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

     
    }
        
    
}
