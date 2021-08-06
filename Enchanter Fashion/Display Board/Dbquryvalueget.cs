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
        public string picfilename, brand,collection,itemname,description,price;
        private int slide = -6;
        public int totalslides;
        public int cuurentslide = 0;
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
                    arrayvalues.Add(dr.GetString("item_name").ToString());
                    arrayvalues.Add(dr.GetString("brand").ToString());
                    arrayvalues.Add(dr.GetString("Collection").ToString());
                    arrayvalues.Add(dr.GetFloat("price").ToString());
                    arrayvalues.Add(dr.GetString("description").ToString());
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
                totalslides = arrayvalues.Count/6;
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
                if (slide >= arrayvalues.Count - 6)
                {
                    slide = arrayvalues.Count - 6;
                    picfilename = arrayvalues[slide].ToString();
                    itemname = arrayvalues[slide + 1].ToString();
                    brand = arrayvalues[slide + 2].ToString();
                    collection = arrayvalues[slide + 3].ToString();
                    price = arrayvalues[slide + 4].ToString();
                    description = arrayvalues[slide + 5].ToString();
                    
                    //Console.WriteLine(slide);
                    //Console.WriteLine(arrayvalues[slide].ToString()); 
                }
                else
                {
                    slide = slide + 6;
                    picfilename = arrayvalues[slide].ToString();
                    itemname = arrayvalues[slide + 1].ToString();
                    brand = arrayvalues[slide + 2].ToString();
                    collection = arrayvalues[slide + 3].ToString();
                    price = arrayvalues[slide + 4].ToString();
                    description = arrayvalues[slide + 5].ToString();
                    //Console.WriteLine(slide);
                    //Console.WriteLine(arrayvalues[slide].ToString());           
                }
                //cuurentslide = (slide/6) + 1;
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
                    picfilename = arrayvalues[slide].ToString();
                    itemname = arrayvalues[slide + 1].ToString();
                    brand = arrayvalues[slide + 2].ToString();
                    collection = arrayvalues[slide + 3].ToString();
                    price = arrayvalues[slide + 4].ToString();
                    description = arrayvalues[slide + 5].ToString();
                    //Console.WriteLine(slide);
                    //Console.WriteLine(arrayvalues[0].ToString());
                }
                else
                {
                    slide = slide - 6;
                    picfilename = arrayvalues[slide].ToString();
                    itemname = arrayvalues[slide + 1].ToString();
                    brand = arrayvalues[slide + 2].ToString();
                    collection = arrayvalues[slide + 3].ToString();
                    price = arrayvalues[slide + 4].ToString();
                    description = arrayvalues[slide + 5].ToString();
                    //Console.WriteLine(slide);
                    //Console.WriteLine(arrayvalues[slide].ToString());                         
                }
                //cuurentslide = cuurentslide - 1;
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
            slide = -6;
            cuurentslide = 0;
        }
    }
}