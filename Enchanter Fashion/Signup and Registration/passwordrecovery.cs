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
    public partial class passwordrecovery : Form
    {
        public passwordrecovery()
        {
            InitializeComponent();

            first_recovery.recovery1_next.Click += firstrcvy_next_btn_Click;
            first_recovery.back_btn.Click += firstrcvy_back_butn_Click;
            second_recovery.recovery2_next.Click += secondtrcvy_next_btn_Click;
            third_recovery.submit_btn.Click += thirdtrcvy_next_btn_Click;
        }

        public string username, password;
        databasecrudoperations dbset;

        private void firstrcvy_back_butn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Enchanter Fashion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                Form1 signup = new Form1();
                this.Closed += (s, args) => this.Close();
                signup.Show();
            }  
        }

        private void firstrcvy_next_btn_Click(object sender, EventArgs e)
        {
            
            if (first_recovery.email_or_username.Text == "")
            {
                if (MessageBox.Show("Please enter a username or email", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                {
                }
            }
            else
            {
                dbset = new databasecrudoperations();
                if (dbset.checkemail(first_recovery.email_or_username.Text) == true || dbset.checkusername(first_recovery.email_or_username.Text) == true)
                {
                    this.username = first_recovery.email_or_username.Text;
                    dbset = new databasecrudoperations(this.username);
                    first_recovery.SendToBack();
                    third_recovery.SendToBack();
                    second_recovery.BringToFront();
                }
                else
                {
                    if (MessageBox.Show("Username or email is not found.", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                    }
                }
            }

        }

        private void secondtrcvy_next_btn_Click(object sender, EventArgs e)
        {
            if(second_recovery.book_name.Text == "")
            {
                if (MessageBox.Show("Enetr the name of your favorite book.", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                {
                }
            }
            else if(second_recovery.school_name.Text == "")
            {
                if (MessageBox.Show("Enter your first school name", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                {
                }
            }
            else
            {
                if(dbset.check_answers(second_recovery.school_name.Text, second_recovery.book_name.Text) == true)
                {

                    if (MessageBox.Show("Answers are correct.", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        first_recovery.SendToBack();
                        second_recovery.SendToBack();
                        third_recovery.BringToFront();
                    }
                }
                else
                {
                    if (MessageBox.Show("Answers are not matching", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                    }
                }
            }
        }

        private void thirdtrcvy_next_btn_Click(object sender, EventArgs e)
        {
            if( dbset.ValidatePassword(third_recovery.new_pswd.Text) == true)
            {
                if(third_recovery.new_pswd.Text == third_recovery.confirm_pswd.Text)
                {
                    this.password = third_recovery.new_pswd.Text;
                    dbset.updatepassword(this.password);
                }
                if (MessageBox.Show("Hello.. " + dbset.username + ". your new password has successfully updated.", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Hide();
                    Form1 signup = new Form1();
                    this.Closed += (s, args) => this.Close();
                    signup.Show();
                }
                this.Hide();
            }
            else
            {
                if (MessageBox.Show(dbset.errormaages, "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                {
                }
            }
        }
    }
}
