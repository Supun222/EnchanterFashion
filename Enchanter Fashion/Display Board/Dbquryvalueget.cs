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
        
        public string picfilename;
        public int lastelmnt;
        public void returnvalues(string sql_qury, int counter)
        {
            //Supun
            ArrayList arrayvalues = new ArrayList();
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
                conn.Close(); 
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

            //Console.WriteLine(arrayvalues[counter]);
            
            if (counter>=0 && counter < arrayvalues.Count)
            {
                picfilename = arrayvalues[counter].ToString();
            }
            else if (counter < 0)
            {
                picfilename = arrayvalues[0].ToString();
            }
            else if(counter>=arrayvalues.Count)
            {
                lastelmnt = arrayvalues.Count - 1;
                picfilename = arrayvalues[lastelmnt].ToString();
            }
            arrayvalues.Clear();
            
            /*
            foreach (Node item in L)
            {
               Console.WriteLine(item.Data);
            }*/

              
        }

        
    }
}
