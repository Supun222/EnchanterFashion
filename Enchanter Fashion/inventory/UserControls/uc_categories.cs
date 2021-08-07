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
using System.Data.SqlClient;

namespace Enchanter_Fashion.inventory.UserControls
{
    public partial class uc_categories : UserControl
    {


        MySqlConnection conn = DBConection.getconnection();
       

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

                conn.Open();

                String str = "Select * From contain_items";

                MySqlCommand cmd = new MySqlCommand(str, conn);

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();

               MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                dgvUser.DataSource = dt;

                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }



        }





    }
}
