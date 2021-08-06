using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Enchanter_Fashion.Massage;
using Enchanter_Fashion.Signup_and_Registration;
using System.Text.RegularExpressions;

namespace Enchanter_Fashion
{
    public partial class Form1 : Form
    {
        
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern System.IntPtr CreateRoundRectRgn
        (
             int nLeftRect, // x-coordinate of upper-left corner
             int nTopRect, // y-coordinate of upper-left corner
             int nRightRect, // x-coordinate of lower-right corner
             int nBottomRect, // y-coordinate of lower-right corner
             int nWidthEllipse, // height of ellipse
             int nHeightEllipse // width of ellipse
        );

        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(System.IntPtr hObject);
        
        public Form1()
        {
            InitializeComponent();
            
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));

            //set all usercontrolls appearance at the begining 
            login.BringToFront();
            regpanel1.SendToBack();
            regpanel2.SendToBack();
            //assigning methods of login usercontrol 
            login.lgsnup_btn.Click += login_DisplayButtonClicked;
            //assigning methods of register panel 1 usercontrol
            regpanel1.reg1sgn_lbl.Click += lgsnup_lbl_Click;
            regpanel1.reg1nxt_btn.Click += reg1nxt_btn_click;
            //assigning methods of register panel 2 usercontrol
            regpanel2.reg2next_btn.Click += reg2nxt_btn_click;
            regpanel2.reg2back_btn.Click += reg2back_btn_click;
            regpanel2.reg2sgn_lbl.Click += reg2sgn_lbl_click;

            login.Loginbtn.Click += login_Click;
            login.forgotpswd_lbl.Click += forgot_pswd_btn_Click;

            terms.tmsnplycsgnup_btn.Click += termsandpolicies_btn_click;
        }


        Termsandpolycies terms = new Termsandpolycies();
        databasecrudoperations dbset = new databasecrudoperations();
        public string newusername, email, name, phonenumber, gender, bookname, schoolname, password;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.IntPtr ptr = CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20); // _BoarderRaduis can be adjusted to your needs, try 15 to start.
            this.Region = System.Drawing.Region.FromHrgn(ptr);
            DeleteObject(ptr);
        }
        
        private void login_DisplayButtonClicked(object sender, EventArgs e)
        {      
            regpanel1.BringToFront();         
        }

        private void lgsnup_lbl_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancle the registration", "Enchanter Fashion - Registaion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                login.BringToFront();
            }
        }

        //tmsnplycback_btn tmsnplycprnt_btn  tmsnplycsgnup_btn

        private void reg1nxt_btn_click(object sender, EventArgs e)
        {
            if (regpanel1.reg1_username_txt.Text == "")
            {
                if (MessageBox.Show("Please enter a username", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                {

                }
            }
            else if (regpanel1.reg1_email_txt.Text == "")
            {
                if (MessageBox.Show("Please enter an email", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                {

                }
            }
            else if (regpanel1.reg1_paswd_txt.Text == "")
            {
                if (MessageBox.Show("Please enter the username or email", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                {

                }
            }
            else
            {
                if (Regex.IsMatch(regpanel1.reg1_username_txt.Text, @"^[!#$%%^&*()?/<>.,'""]+$") == true || Regex.IsMatch(regpanel1.reg1_email_txt.Text, @"^[!#$%%^&*()?/<>.,'""]+$") == true || Regex.IsMatch(regpanel1.reg1_paswd_txt.Text, @"^[()?/<>.,'""]+$") == true)
                {
                    if (MessageBox.Show("Please use only letters without numbers of any spcial charactors", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                    {

                    }
                }
                else
                {
                    if (IsValidEmail(regpanel1.reg1_email_txt.Text) == false)
                    {
                        if (MessageBox.Show("Please insert a correct email address.", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                        {

                        }
                    }
                    else
                    {
                        if (regpanel1.reg1_paswd_txt.Text == regpanel1.reg1_cmpaswd_txt.Text)
                        {
                            this.newusername = regpanel1.reg1_username_txt.Text;
                            this.email = regpanel1.reg1_email_txt.Text;
                            this.password = regpanel1.reg1_paswd_txt.Text;
                            regpanel2.BringToFront();
                        }
                        else
                        {
                            if (MessageBox.Show("Password and confirm passwords are not matching. Please try again.", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                            {

                            }
                        }
                    }
                }
                
            }
            
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void reg2nxt_btn_click(object sender, EventArgs e)
        {
            if (regpanel2.fullname_txt.Text == "")
            {
                if (MessageBox.Show("Please enter a username", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                {
                }
            }
            else if (regpanel2.phonnumber_txt.Text == "")
            {
                if (MessageBox.Show("Please enter a username", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                {
                }
            }
            else if (regpanel2.bookname.Text == "" || regpanel2.schoolname.Text == "")
            {
                if (MessageBox.Show("Please answer to the questions", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                {
                }
            }          
            else
            {
                if (Regex.IsMatch(regpanel2.fullname_txt.Text, @"^[!#$%%^&*()?/<>.,'""]+$") == true || Regex.IsMatch(regpanel2.bookname.Text, @"^[!#$%%^&*()?/<>.,'""]+$") == true || Regex.IsMatch(regpanel2.schoolname.Text, @"^[()?/<>.,'""]+$") == true)
                {
                    if (MessageBox.Show("Please use only letters without numbers of any spcial charactors", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                    {

                    }
                }
                else
                {
                    if (Regex.IsMatch(regpanel2.phonnumber_txt.Text, @"[^0-9]"))
                    {
                        if (MessageBox.Show("Please insert correct phone number", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                        }
                    }
                    else
                    {
                        this.name = regpanel2.fullname_txt.Text;
                        this.phonenumber = regpanel2.phonnumber_txt.Text;
                        this.bookname = regpanel2.bookname.Text;
                        this.schoolname = regpanel2.schoolname.Text;
                        if (regpanel2.male_radio.Checked == true)
                        {
                            this.gender = "male";
                        }
                        else if (regpanel2.female_radio.Checked == true)
                        {
                            this.gender = "female";
                        }

                        if (dbset.checkusername(newusername) == true)
                        {
                            if (MessageBox.Show("This username has aleady taken. Please insert a different one.", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                            {
                            }
                        }
                        else if (dbset.checkemail(email) == true)
                        {
                            if (MessageBox.Show("This email has aleady taken. Please insert a different one.", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                            {
                            }
                        }
                        else
                        {
                            terms.Show();
                        }

                    }
  
                }
            }
            
        }

        private void reg2back_btn_click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to go back?", "Enchater Fashion - Registation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                regpanel1.BringToFront();
            }
        }

        private void reg2sgn_lbl_click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to cancle the registation", "Enchater Fashion - Registation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                login.BringToFront();
            }
        }

        private const int CS_DropShadows = 0x00030000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadows;
                return cp;
            }
        }      

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Enchanter Fashion", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Close(); 
            } 
        }

        private void login_Click(object sender, EventArgs e)
        {
            string username, password;
            username = login.lgnemail.Text;
            password = login.lgnpswd.Text;

            if (username == "")
            {
                if (MessageBox.Show("Please enter the username or email", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    
                }
            }
            else if( password == "")
            {
                if (MessageBox.Show("Please enter the password", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    
                }
            }
            else
            {
                databasecrudoperations dbset = new databasecrudoperations();
                if(dbset.checklogin(username, password) == true) 
                {
                    this.Hide();
                    DIMassage msg = new DIMassage(username);
                    this.Closed += (s, args) => this.Close();
                    msg.displayandInventorymsg1.topic_lbl.Text = "Hello..!!  " + dbset.username + ". Please select an option.";
                    msg.Show();
                }
                else
                {
                    if (MessageBox.Show("Username or password is incorrect. please try again", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                    {
  
                    }
                }
            }         
        }

        private void termsandpolicies_btn_click(object sender, EventArgs e)
        {
            if (terms.accepted_check.Checked == true)
            {
                int ph_numb = Int32.Parse(phonenumber);
                dbset.registeringcompleting(this.newusername, this.email, this.name, ph_numb, this.password, this.gender, this.bookname, this.schoolname);
                if (MessageBox.Show("Registration is successful.", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                {
                }
                terms.Hide();
                login.BringToFront();
                regpanel1.SendToBack();
                regpanel2.SendToBack();
            }
            else
            {
                if (MessageBox.Show("Please accept the terms and conditions.", "Enchanter Fashion", MessageBoxButtons.OK) == DialogResult.OK)
                {
                }
            }
        }

        private void forgot_pswd_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to recovery password?", "Enchanter Fashion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                passwordrecovery fogtpswd = new passwordrecovery();
                this.Closed += (s, args) => this.Close();
                fogtpswd.Show();
            } 
        }
    }
}
