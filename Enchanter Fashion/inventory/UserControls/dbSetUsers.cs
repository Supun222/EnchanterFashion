﻿using System;
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
    class dbSetUser
    {
        //uc_users : UserControl 
        string sql_query;
        //uc_users user = new uc_users(); 



        public void userInsert_value(string nic, string userName, string pw)
        {
            sql_query = "INSERT into users (nic,userName,password) values('" + nic + "','" + userName + "','" + pw + "')";

            try
            {
                MySqlConnection conn = DBConection.getconnection();

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
        public void userDelete_value(string id, string uname, string pword)
        {
            try
            {
                MySqlConnection conn = DBConection.getconnection();
                sql_query = "DELETE from users where nic='" + id + "';";

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
        /*public void displayTable()
        {
            try
            {
                MySqlConnection conn = DBConection.getconnection();
                sql_query = "SELECT * FROM enchanterfashion.users";

                MySqlCommand myCommand = new MySqlCommand(sql_query, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                myAdapter.SelectCommand = myCommand;
                DataTable dtable = new DataTable();
                myAdapter.Fill(dtable);
                
               // conn.Close();

            }
            catch(Exception ex)
            {

            }
        }*/

    }
}