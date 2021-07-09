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
            getconnection();
            MySqlCommand mycomnd = new MySqlCommand(sql_qury, con);          
            try
            {
                con.Open();
                MySqlDataReader dr = mycomnd.ExecuteReader();
                while (dr.Read())
                {
                    arrayvalues.Add(dr.GetString("pic_file_name").ToString());           
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

            if (counter<=0)
            {
                picfilename = arrayvalues[0].ToString();
                arrayvalues.Clear();
                counter = 0;
            }
            else if (0< counter && counter < arrayvalues.Count)
            {
                picfilename = arrayvalues[counter].ToString();
                Console.WriteLine(size);
                arrayvalues.Clear();
            }
            else // counter>size
            {
                picfilename = arrayvalues[arrayvalues.Count-1].ToString();
                arrayvalues.Clear();
                counter = arrayvalues.Count + 1;
            }
        con.Close();
        }
    }
}
