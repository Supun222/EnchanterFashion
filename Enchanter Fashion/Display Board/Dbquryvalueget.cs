 using System;
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
            
            Linkedlist mylist = new Linkedlist();
            Node current = new Node();
            Node curent = new Node();
            getconnection();
            MySqlCommand mycomnd = new MySqlCommand(sql_qury, con);
            try
            {
                con.Open();
                MySqlDataReader dr = mycomnd.ExecuteReader();

                while (dr.Read())
                {
                    ///*
                    if (mylist.head == null)
                    {
                        Node temp = new Node();
                        temp.picname = dr.GetString("pic_file_name").ToString();
                        temp.next = null;
                        temp.prev = null;
                        mylist.head = temp;
                    }
                    else
                    {
                        current = mylist.head;                  
                        Node temp = new Node();
                        temp.picname = dr.GetString("pic_file_name").ToString();
                        temp.next = null;
                        temp.prev = current.next;
                        current = current.next;
                        //rrent.next = mylist.head.prev;
                    }//*/
                }
                
            }
            catch (MySqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            curent = mylist.head;
            
            Console.WriteLine(curent.picname);
            curent = curent.next;
            
            //de ct = new Node();
            // = mylist.head;
            //picfilename = current.picname;
            //Console.WriteLine(mylist.head.picname);
            //nsole.WriteLine(ct.next.picname);
            // = ct.next;
            con.Close();
        }
    }
}
