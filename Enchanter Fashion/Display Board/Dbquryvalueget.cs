 using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Enchanter_Fashion.DBConnection;
using MySql.Data.MySqlClient;

namespace Enchanter_Fashion.Display_Board
{
    class Dbquryvalueget
    {
        public ArrayList arrayvalues = new ArrayList();
        public string picfilename;
        public int lastelmnt;

        public void returnvalues(string sql_qury, int counter)
        {
            //Supun
            
            try
            {
                MySqlConnection conn = DBConection.getconnection();
                //MySqlConnection conn = new MySqlConnection();
                //LinkedList L = new LinkedList();
                //MySqlCommand mycomnd = new MySqlCommand(sql_qury, conn);
                MySqlCommand myCommand = new MySqlCommand(sql_qury, conn);
                conn.Open();
                MySqlDataReader dr = myCommand.ExecuteReader();
                //bool first = true;
                while (dr.Read())
                {
                    arrayvalues.Add(dr.GetString("pic_file_name").ToString());
                    /*
                    if (first == true)
                    {
                        L.AddFirst(dr.GetString("pic_file_name").ToString());
                        first = false;
                    }
                    else
                    {
                        L.Add(dr.GetString("pic_file_name").ToString());
                    }*/                 
                }
             
            }
            catch (MySqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (Exception exp)
            {
                //MessageBox.Show(exp.Message);
                Console.WriteLine("hello");
            }

            Console.WriteLine((String)arrayvalues[counter]);
            
            if (counter>=0 && counter < arrayvalues.Count)
            {
                picfilename = (String)arrayvalues[counter];
            }
            else if (counter < 0)
            {
                picfilename = (String)arrayvalues[0];
            }
            else if(counter>=arrayvalues.Count)
            {
                lastelmnt = arrayvalues.Count - 1;
                picfilename = (String)arrayvalues[lastelmnt];
            }
            
            /*
            foreach (Node item in L)
            {
               Console.WriteLine(item.Data);
            }*/

              
        }

        
    }
}
