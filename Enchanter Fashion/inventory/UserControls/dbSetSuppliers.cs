﻿using System;
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

        public void insertData(string name, string address, string phone)
        {
            string supplierId = autoGenerateId();
            //sql_query = "INSERT into suppliers(sup_id,sup_name,sup_city,sup_mobile)  values('" + supId + "','" + name + "','" + address + "','" + phone + "')";
            try
            {
                MySqlConnection conn = DBConection.getconnection();
                sql_query = "INSERT into suppliers(sup_id,sup_name,sup_city,sup_mobile)  values('" + supplierId + "','" + name + "','" + address + "','"+phone+"')";

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
    }
        
    
}