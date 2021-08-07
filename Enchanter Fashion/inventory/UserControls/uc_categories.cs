using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enchanter_Fashion.DBConnection;

namespace Enchanter_Fashion.inventory.UserControls
{
    public partial class uc_categories : UserControl
    {


        //MySqlConnection con = DBConnection.getconnection();
        // SqlCommand cm = new SqlCommand();
        // SqlDataReader dr;

        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader dr;
        MySqlConnection conn = DBConection.getconnection();
        //conn.Open();


        //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
        public uc_categories()
        {
            InitializeComponent();
            LoadUser();
        }

        public void LoadUser()
        {
            try
            {

                int i = 0;
                dgvUser.Rows.Clear();
                cm = new MySqlCommand("SELECT * FROM contain_items", conn);
                conn.Open();
                dr = cm.ExecuteReader();

                AutoCompleteStringCollection autotext = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    //i++;
                    //dgvUser.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                    autotext.Add(dr.GetString("item_name"));
                }




               // dr.Close();
               // conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }





    }
}
