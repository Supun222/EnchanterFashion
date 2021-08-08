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
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Enchanter_Fashion.inventory.UserControls
{
    public partial class uc_suppliers : UserControl
    {
        public uc_suppliers()
        {
            InitializeComponent();
            display(null, null);
        }

        private bool validateEmail(string email){
            Regex regx = new Regex (@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
            Match match = regx.Match(email);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(companyNameTb.Text == "")
            {
                MessageBox.Show("Please enter the supplier name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(emailTb.Text == "")
            {
                MessageBox.Show("Please Enter the e-mail address");
            }
            else if(addressTb.Text == "")
            {
                MessageBox.Show("Please Enter the address");
            }
            else if(telephoneTb.Text == "")
            {
                MessageBox.Show("Please enter the telephone number");
            }
            else
            { 
               if (validateEmail(emailTb.Text) == true)
               {
                  if (telephoneTb.Text.Length == 10)
                  {
                    dbSetSuppliers saveItems = new dbSetSuppliers();
                    saveItems.insertData(companyNameTb.Text, addressTb.Text, telephoneTb.Text, emailTb.Text);
                  }
                  else
                  {
                     MessageBox.Show("Please enter the correct phone number", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }
               }
                else
                {
                    MessageBox.Show("Please enter the correct e-mail address", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                  
            }
            /*if(companyNameTb.Text != "")
            {
                if(telephoneTb.Text.Length == 10)
                {
                    dbSetSuppliers saveItems = new dbSetSuppliers();
                    saveItems.insertData(companyNameTb.Text, addressTb.Text, telephoneTb.Text);
                }
                else
                {
                    MessageBox.Show("Please enter a correct phone number", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter the supplier name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

            display(null, null);
            supplierIdTb.Text = "";
            companyNameTb.Text = "";
            addressTb.Text = "";
            telephoneTb.Text = "";
            emailTb.Text = "";
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (supplierIdTb.Text == "")
            {
                MessageBox.Show("Please Enter the suplier id", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(companyNameTb.Text == "")
            {
                MessageBox.Show("Please Enter the suplier name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(emailTb.Text == "")
            {
                MessageBox.Show("Please Enter the e-mailaddress", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (addressTb.Text == "")
            {
                MessageBox.Show("Please Enter the suplier adderess", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(telephoneTb.Text == "")
            {
                MessageBox.Show("Please Enter the suplier telephone number", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(telephoneTb.Text.Length == 10)
                {
                    dbSetSuppliers edit = new dbSetSuppliers();
                    if (edit.checkItem(supplierIdTb.Text) == true)
                    {
                        edit.editData(supplierIdTb.Text, companyNameTb.Text, addressTb.Text, telephoneTb.Text,emailTb.Text);
                    }
                    else
                    {
                        MessageBox.Show("Please Enter the correct supplier id.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            display(null, null);
            supplierIdTb.Text = "";
            companyNameTb.Text = "";
            addressTb.Text = "";
            telephoneTb.Text = "";
            emailTb.Text = "";
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (supplierIdTb.Text == "")
            {
                MessageBox.Show("Enter supplier id ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                dbSetSuppliers remove = new dbSetSuppliers();
                if (remove.checkItem(supplierIdTb.Text) == true)
                {
                    remove.deleteData(supplierIdTb.Text, companyNameTb.Text, addressTb.Text, telephoneTb.Text,emailTb.Text);
                }
                else
                {
                    MessageBox.Show("Please enter correct supplier id.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            display(null, null);
            supplierIdTb.Text = "";
            companyNameTb.Text = "";
            addressTb.Text = "";
            telephoneTb.Text = "";
            emailTb.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = DBConection.getconnection();
                string query = "SELECT * FROM suppliers WHERE sup_id LIKE '%" + supplierIdTb.Text + "%'";
                Console.WriteLine(query);
                MySqlCommand mycmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataAdapter myadpter = new MySqlDataAdapter();
                myadpter.SelectCommand = mycmd;
                DataTable dTable = new DataTable();
                myadpter.Fill(dTable);
                table.DataSource = dTable;
                con.Close();
            }
            catch (MySqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = DBConection.getconnection();
                string query = "SELECT * FROM suppliers WHERE sup_name LIKE '%" + companyNameTb.Text + "%'";
                Console.WriteLine(query);
                MySqlCommand mycmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataAdapter myadpter = new MySqlDataAdapter();
                myadpter.SelectCommand = mycmd;
                DataTable dTable = new DataTable();
                myadpter.Fill(dTable);
                table.DataSource = dTable;
                con.Close();
            }
            catch (MySqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void display(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = DBConection.getconnection();
                string query = "SELECT* FROM suppliers";
                Console.WriteLine(query);
                MySqlCommand mycmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataAdapter myadpter = new MySqlDataAdapter();
                myadpter.SelectCommand = mycmd;
                DataTable dTable = new DataTable();
                myadpter.Fill(dTable);
                table.DataSource = dTable;  
                con.Close();
            }
            catch (MySqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
