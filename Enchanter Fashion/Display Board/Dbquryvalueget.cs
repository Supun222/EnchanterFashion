﻿ using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;

namespace Enchanter_Fashion.Display_Board
{
    class Dbquryvalueget
    {
        public MySqlConnection con;
        public ArrayList arrayvalues = new ArrayList();
        public string picfilename;
        public int size=0;
        
        public void getconnection()
        {
            String host = "datasource=localhost;port=3306;database=enchanterfashion;username=root;password=";
            con = new MySqlConnection(host);
        }

        public void returnvalues(string sql_qury, int counter)
        {
            //Supun
            Node temp = new Node();
            Linkedlist mylist = new Linkedlist();
            Node current = new Node();
            getconnection();
            MySqlCommand mycomnd = new MySqlCommand(sql_qury, con);          
            try
            {
                con.Open();
                MySqlDataReader dr = mycomnd.ExecuteReader();
                while (dr.Read())
                {
                    arrayvalues.Add(dr.GetString("pic_file_name").ToString());
                    if (mylist.head == null)
                    {
                        temp.picname = dr.GetString("pic_file_name").ToString();
                        temp.next = null;
                        temp.prev = null;
                        mylist.head = temp;
                    }
                    else
                    {
                        current = mylist.head;
                        while (current.next != null)
                        {
                            current = current.next;
                        }
                        temp.picname = dr.GetString("pic_file_name").ToString();
                        temp.next = null;
                        temp.prev = current.next;
                        current.next = mylist.head;
                    }
                }             
            }
            catch(MySqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            current = mylist.head;
            picfilename = current.picname;
            Console.WriteLine(current.picname);
            current = current.next;
            con.Close();
        }
    }
}
