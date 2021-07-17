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
        }
        
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
            regpanel2.BringToFront();
        }

        private void reg2nxt_btn_click(object sender, EventArgs e)
        {
            new Termsandpolycies().Visible = true;
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

        string regmailtxt="", lgnmailtxt="";

        public void setregemailvalue(string text)
        {
            regmailtxt = text;
        }

        public void setlgnemailvalue(string text)
        {
            lgnmailtxt = text;
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
            this.Hide();
            DIMassage msg = new DIMassage();
            this.Closed += (s, args) => this.Close();
            msg.Show();          
        }
    }


}
