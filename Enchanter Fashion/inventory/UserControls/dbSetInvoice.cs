using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Enchanter_Fashion.DBConnection;
using MySql.Data.MySqlClient;

namespace Enchanter_Fashion.inventory.UserControls
{
    class dbSetInvoice
    {
        string sql_query;
        

        public bool checkItem(string billNo)
        {
            int count = 0;

            try
            {
                MySqlConnection conn = DBConection.getconnection();
                sql_query = "SELECT COUNT(bill_no) AS count FROM inventory WHERE bill_no = '" + billNo + "'";
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

      

        public void insertData(string billNo, int itemId, string supId, string itemName, int quantity,float price)
        {
            try
            {
                MySqlConnection conn = DBConection.getconnection();
                sql_query = "INSERT into inventory(bill_no,item_id,sup_id,item_name,quantity,unit_price)  values('" + billNo + "','" + itemId + "','" + supId + "','" + itemName + "','" + quantity + "','"+price+"')";

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

        public void editData(string billNo, int itemId, string supId, string itemName, int quantity, float price)
        {
            
            try
            {
                MySqlConnection conn = DBConection.getconnection();
                sql_query = "UPDATE inventory SET item_id = '" + itemId + "',sup_id = '" + supId + "',item_name = '" + itemName + "',quantity='" + quantity + "',unit_price='"+price+"' WHERE bill_no = '" + billNo + "' ;";

                MySqlCommand myCommand = new MySqlCommand(sql_query, conn);
                MySqlDataReader myReader;
                conn.Open();
                myReader = myCommand.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (myReader.Read())
                {

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteData(string billNo)
        {
            try
            {
                MySqlConnection conn = DBConection.getconnection();
                sql_query = "DELETE from inventory where inventory.bill_no='" + billNo + "';";

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



