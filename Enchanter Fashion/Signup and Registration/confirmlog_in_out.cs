using Enchanter_Fashion.Display_Board;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enchanter_Fashion.Signup_and_Registration
{
    public partial class confirmlog_in_out : Form
    {
        public confirmlog_in_out()
        {
            InitializeComponent();
        }

        public confirmlog_in_out(string username, string password)
        {
            InitializeComponent();
            username_lbl.Text = "Hello " + username + " Please enter the password.";
            paswd_txt.Text = "";
            // The password character is an asterisk.
            paswd_txt.PasswordChar = '*';
            this.username = username;
            this.password = password;
        }

        string username, password;

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            
            if (this.password == paswd_txt.Text)
            {
                this.Hide();
                addarrivals adnewitms = new addarrivals(this.username, this.password);
                this.Closed += (s, args) => this.Close();
                adnewitms.Show();
            }
            else
            {
                if (MessageBox.Show("Password is not correct", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                {
                }
            }
        }
    }
}
