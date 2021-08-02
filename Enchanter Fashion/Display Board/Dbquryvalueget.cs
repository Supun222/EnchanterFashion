using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Enchanter_Fashion.DBConnection;
using Enchanter_Fashion.Massage;
using MySql.Data.MySqlClient;

namespace Enchanter_Fashion.Display_Board
{
    class Dbquryvalueget
    {
        public string picfilename;
        private int slide = -1;
        public int totalslides;
        public int cuurentslide;
        ArrayList arrayvalues = new ArrayList();

        public void settingsvalues(string sql_qury)
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
                totalslides = arrayvalues.Count;
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
            /*
            foreach (Node item in L)
            {
               Console.WriteLine(item.Data);
            }*/
        }

        public void returnnextvalues()
        {
            try
            {
                if (slide >= arrayvalues.Count - 1)
                {
                    slide = arrayvalues.Count - 1;
                    picfilename = arrayvalues[slide].ToString();
                    //Console.WriteLine(slide);
                    //Console.WriteLine(arrayvalues[slide].ToString()); 
                }
                else
                {
                    slide = slide + 1;
                    picfilename = arrayvalues[slide].ToString();
                    //Console.WriteLine(slide);
                    //Console.WriteLine(arrayvalues[slide].ToString());           
                }
                cuurentslide = slide;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                filenotfound fillmissing = new filenotfound();
                fillmissing.Show();
            }
        }

        public void returnpreviuosvalues()
        {
            try
            {
                if (slide <= 0)
                {
                    slide = 0;
                    picfilename = arrayvalues[0].ToString();
                    //Console.WriteLine(slide);
                    //Console.WriteLine(arrayvalues[0].ToString());
                }
                else
                {
                    slide = slide - 1;
                    picfilename = arrayvalues[slide].ToString();
                    //Console.WriteLine(slide);
                    //Console.WriteLine(arrayvalues[slide].ToString());                         
                }
                cuurentslide = slide;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                filenotfound fillmissing = new filenotfound();
                fillmissing.Show();
            }           
        }

        public void claerarraylist()
        {
            arrayvalues.Clear();
            slide = -1;
        }
    }
}