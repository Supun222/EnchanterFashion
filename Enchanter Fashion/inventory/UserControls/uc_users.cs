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

namespace Enchanter_Fashion.inventory.UserControls
{
    public partial class uc_users : UserControl
    {
        public uc_users()
        {
            InitializeComponent();
            viewBtn_Click(null, null);
        }
        public static string encodePwToBase64 (string password){
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch(Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
            
        }

        public string decodeFromBase64(string encoded)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder decode = encoder.GetDecoder();
            byte[] toDecode_byte = Convert.FromBase64String(encoded);
            int count = decode.GetCharCount(toDecode_byte, 0, toDecode_byte.Length);
            char[] decodedChar = new char[count];
            decode.GetChars(toDecode_byte, 0, toDecode_byte.Length, decodedChar, 0);
            string result = new String(decodedChar);
            return result;
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {
            pwTb.PasswordChar = '*';
        }

        private void confirmPwTb_TextChanged(object sender, EventArgs e)
        {
            confirmPwTb.PasswordChar = '*';
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            string encodedPw = encodePwToBase64(pwTb.Text);
            string decodedPw = decodeFromBase64(encodedPw);
            string encodedConfirmPw = encodePwToBase64(confirmPwTb.Text);
            string decodedConfirmPw = decodeFromBase64(encodedConfirmPw);

            if(nicTb.Text == "")
            {
                MessageBox.Show("Please enter the NIC number", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (userNameTb.Text == "")
            {
                MessageBox.Show("Please enter the user name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pwTb.Text == "")
            {
                MessageBox.Show("Please enter the Password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (confirmPwTb.Text == "")
            {
                MessageBox.Show("Please confirm the password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (nicTb.Text.Length == 10 || nicTb.Text.Length == 11)
                {
                    if (decodedPw == decodedConfirmPw)
                    {
                        dbSetUser add = new dbSetUser();
                        add.userInsert_value(nicTb.Text, userNameTb.Text, encodedPw);
                    }
                    else
                    {
                        MessageBox.Show("Password does not match", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Id number", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            /*if (nicTb.Text.Length == 10 || nicTb.Text.Length == 11)
            {
                if (decodedPw == decodedConfirmPw)
                {
                    dbSetUser add = new dbSetUser();
                    add.userInsert_value(nicTb.Text, userNameTb.Text, encodedPw);
                }
                else
                {
                    MessageBox.Show("Password does not match", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Id number", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            nicTb.Text = "";
            userNameTb.Text = "";
            pwTb.Text = "";
            confirmPwTb.Text = "";
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (nicTb.Text == "")
            {
                MessageBox.Show("Enter NIC number", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                dbSetUser remove = new dbSetUser();
                if (remove.checkItem(nicTb.Text) == true)
                {
                    remove.userDelete_value(nicTb.Text, userNameTb.Text, pwTb.Text);
                }
                else
                {
                    MessageBox.Show("Please enter correct NIC number",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }    

             nicTb.Text = "";
             userNameTb.Text = "";
             pwTb.Text = "";
             confirmPwTb.Text = "";
            
        }

 
    

        private void viewBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = DBConection.getconnection();
                string query = "SELECT* FROM users";
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

            }
        }
    }
}