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
        public MySqlConnection con;
        public ArrayList arrayvalues = new ArrayList();
        public string picfilename;
        public int size = 0;

        public void returnvalues(string sql_qury, int counter)
        {
            //Supun
            MySqlConnection conn = DBConection.getconnection();
            
            //LinkedList L = new LinkedList();
            MySqlCommand mycomnd = new MySqlCommand(sql_qury, conn);
            try
            {
               
                    
                MySqlDataReader dr = mycomnd.ExecuteReader();
                //bool first = true;
                while (dr.Read())
                {
                    
                    
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
                MessageBox.Show(exp.Message);
            }

            
            /*
            foreach (Node item in L)
            {
               Console.WriteLine(item.Data);
            }*/

            con.Close();          
        }

        
    }
}
