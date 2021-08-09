using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enchanter_Fashion.DBConnection;

namespace Enchanter_Fashion.Display_Board
{
    public partial class addarrivals : Form
    {
        public addarrivals()
        {
            InitializeComponent();
            dataview_Click(null, null);
        }

        public addarrivals(string username, string password)
        {
            InitializeComponent();
            dataview_Click(null, null);
            this.username = username;
            this.password = password;
        }

        string picturefilepath, username, password;
        private void upload_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg: *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                displaypicture.Image = new Bitmap(open.FileName);
                Console.WriteLine(Path.GetFileName(open.FileName));
                filename.Text = Path.GetFileName(open.FileName);
                picturefilepath = open.FileName;
            }

        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (item_name.Text == "")
            {
                if (MessageBox.Show("Please insert an item name.", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else if (descrption_txt.Text == "")
            {
                if (MessageBox.Show("Please inset a description which contains lower than 600 characters.", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else if (filename.Text == "")
            {
                if (MessageBox.Show("Please inset a picture with a size 1000 x 1500.", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                if(item_name.TextLength > 25)
                {
                    if (MessageBox.Show("Please inset an item name which contains lower than 15 characters.", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (descrption_txt.TextLength > 1000)
                {
                    if (MessageBox.Show("Please inset a description which contains lower than 600 characters.", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else
                {
                    addnewarriavles addingdetails = new addnewarriavles();
                    if(addingdetails.checkitemnameininventory(item_name.Text) == true)
                    {
                        if (addingdetails.checkitemnameindisplay(item_name.Text) ==  false)
                        {
                            displaypanel display = new displaypanel();
                            string itmname, flname, dsptn;
                            itmname = item_name.Text;
                            flname = filename.Text;
                            dsptn = descrption_txt.Text;
                            addingdetails.updatingdisplay(itmname, flname, dsptn);
                            File.Copy(picturefilepath, Path.Combine( display.filedirectory , Path.GetFileName(picturefilepath)), true);
                            display.Close();
                            item_name.Text = "";
                            descrption_txt.Text = "";
                            displaypicture.Image = null;
                            if (MessageBox.Show("New item has added successfuly to the display.", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.Yes)
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Item is already exits in the display.", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.Yes)
                            {
                                this.Close();
                            }
                        }                     
                    }
                    else
                    {
                        if (MessageBox.Show("Item does not already exits in the inventory.", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.Yes)
                        {
                            this.Close();
                        }
                    }                  
                }
            }
        }

        private void addarrivals_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = DBConection.getconnection();
                string query = "SELECT item_name FROM contain_items";
                Console.WriteLine(query);
                MySqlCommand mycmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader dr = mycmd.ExecuteReader();
                AutoCompleteStringCollection autotext = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    autotext.Add(dr.GetString("item_name"));
                }
                item_name.AutoCompleteMode = AutoCompleteMode.Suggest;
                item_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
                item_name.AutoCompleteCustomSource = autotext;
                con.Close();
            }
            catch (MySqlException exp)
            {

            }
        }

        private void dataview_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = DBConection.getconnection();
                string query = "SELECT* FROM display";
                Console.WriteLine(query);
                MySqlCommand mycmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataAdapter myadpter = new MySqlDataAdapter();
                myadpter.SelectCommand = mycmd;
                DataTable dTable = new DataTable();
                myadpter.Fill(dTable);
                displaytable.DataSource = dTable;
                con.Close();
            }
            catch (MySqlException exp)
            {

            }
        }

        private void datadelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to delete the item?", "Enchanter Fashion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string picnumber, filename, filepath;
                displaypanel display = new displaypanel();
                int rowindex = displaytable.CurrentCell.RowIndex;
                DataGridViewRow row = displaytable.Rows[rowindex];
                picnumber = row.Cells[0].Value.ToString();
                filename = row.Cells[1].Value.ToString();
                Console.WriteLine(filename);
                displaytable.Rows.RemoveAt(rowindex);
                int number = Int16.Parse(picnumber);
                deletingpic(number);
                filepath = display.filedirectory + filename;
                Console.WriteLine(filepath);
                try
                {
                    if (File.Exists(filepath))
                    {
                        File.Delete(filepath);
                        MessageBox.Show("File Deleted");
                    }
                    else
                    {
                        MessageBox.Show("File Not Exists");
                    }
                }
                catch (IOException)
                {

                }
                
            }

        }

        private void deletingpic(int pic_num)
        {
            try
            {
                MySqlConnection con = DBConection.getconnection();
                string query = "delete from display where pic_num =" + pic_num ;
                Console.WriteLine(query);
                MySqlCommand mycmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader dr = mycmd.ExecuteReader();
                while (dr.Read())
                {
                }
                con.Close();
            }
            catch (MySqlException exp)
            {

            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Enchanter Fashion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                displaypanel ds = new displaypanel(this.username, this.password);
                this.Closed += (s, args) => this.Close();
                ds.Show();
            }
        }
    }
}
