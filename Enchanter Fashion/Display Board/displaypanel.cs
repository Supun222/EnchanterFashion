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
using BunifuAnimatorNS;
using Enchanter_Fashion.Display_Board;
using Enchanter_Fashion.Massage;

namespace Enchanter_Fashion
{
    public partial class displaypanel : Form
    {
        public displaypanel()
        {
            InitializeComponent();
            //sideunderline_bar.Height = all_btn.Height;
            button1_Click(null, null);
        }

        Dbquryset setqury = new Dbquryset();
        Dbquryvalueget getvalue = new Dbquryvalueget();
        bool isallbtnclicked = true; bool ismenbutnclicked = true; bool iskidsbtnclicked = true;
        bool iswomanbtnclicked = true; bool isshoesbutnclicked = true;
        string filedirectory = @"D:\Projrct\Enchanter Fashion\Display Board\Images\";
        //theruni

        private void button1_Click(object sender, EventArgs e)
        {
            //Supun
            if (sideunderline_bar.Height == all_btn.Height)
            {
                ismenbutnclicked = true; iswomanbtnclicked = true;
                isshoesbutnclicked = true; iskidsbtnclicked = true;
                if (isallbtnclicked == true)
                {
                    getvalue.claerarraylist();
                    getvalue.settingsvalues(setqury.get_query("all"));
                    getvalue.returnnextvalues();
                    isallbtnclicked = false;
                    if (getvalue.totalslides < 10)
                    {
                        totllbl.Text = "0" + getvalue.totalslides.ToString();
                    }
                    else
                    {
                        totllbl.Text = getvalue.totalslides.ToString();
                    }
                }
                else
                {
                    getvalue.returnnextvalues();
                    
                }

            }
            else if (sideunderline_bar.Height == men_btn.Height)
            {
                isallbtnclicked = true; iswomanbtnclicked = true;
                isshoesbutnclicked = true; iskidsbtnclicked = true;
                if (ismenbutnclicked == true)
                {
                    getvalue.claerarraylist();
                    getvalue.settingsvalues(setqury.get_query("men"));
                    getvalue.returnnextvalues();
                    ismenbutnclicked = false;
                    if (getvalue.totalslides < 10)
                    {
                        totllbl.Text = "0" + getvalue.totalslides.ToString();
                    }
                    else
                    {
                        totllbl.Text = getvalue.totalslides.ToString();
                    }
                }
                else
                {
                    getvalue.returnnextvalues();
                    
                }

            }
            else if (sideunderline_bar.Height == women_btn.Height)
            {
                isallbtnclicked = true; ismenbutnclicked = true;
                isshoesbutnclicked = true; iskidsbtnclicked = true;
                if (iswomanbtnclicked == true)
                {
                    getvalue.claerarraylist();
                    getvalue.settingsvalues(setqury.get_query("women"));
                    getvalue.returnnextvalues();
                    iswomanbtnclicked = false;
                    if (getvalue.totalslides < 10)
                    {
                        totllbl.Text = "0" + getvalue.totalslides.ToString();
                    }
                    else
                    {
                        totllbl.Text = getvalue.totalslides.ToString();
                    }
                }
                else
                {
                    getvalue.returnnextvalues();
                    
                }

            }
            else if (sideunderline_bar.Height == kids_btn.Height)
            {
                isallbtnclicked = true; ismenbutnclicked = true; iswomanbtnclicked = true;
                isshoesbutnclicked = true;
                if (iskidsbtnclicked == true)
                {
                    getvalue.claerarraylist();
                    getvalue.settingsvalues(setqury.get_query("kids"));
                    getvalue.returnnextvalues();
                    iskidsbtnclicked = false;
                    if (getvalue.totalslides < 10)
                    {
                        totllbl.Text = "0" + getvalue.totalslides.ToString();
                    }
                    else
                    {
                        totllbl.Text = getvalue.totalslides.ToString();
                    }
                }
                else
                {
                    getvalue.returnnextvalues();
                    
                }

            }
            else
            {
                isallbtnclicked = true; ismenbutnclicked = true; iswomanbtnclicked = true;
                iskidsbtnclicked = true;
                if (isshoesbutnclicked == true)
                {
                    getvalue.claerarraylist();
                    getvalue.settingsvalues(setqury.get_query("shoes"));
                    getvalue.returnnextvalues();
                    isshoesbutnclicked = false;
                    if (getvalue.totalslides < 10)
                    {
                        totllbl.Text = "0" + getvalue.totalslides.ToString();
                    }
                    else
                    {
                        totllbl.Text = getvalue.totalslides.ToString();
                    }
                }
                else
                {
                    getvalue.returnnextvalues();
                    
                }
            }
            try
            {
                if ((getvalue.cuurentslide + 1) < 10)
                {
                    currntlbl.Text = "0" + (getvalue.cuurentslide + 1).ToString();
                }
                else
                {
                    currntlbl.Text = (getvalue.cuurentslide + 1).ToString();
                }
                if (currntlbl.Text == totllbl.Text)
                {
                    button1.Hide();
                    button2.Show();
                }
                else
                {
                    button1.Show();
                    button2.Show();
                }
                background2.Image = Image.FromFile(filedirectory + getvalue.picfilename);
                
            }
            catch(FileNotFoundException ex)
            {
                filenotfound fillmissing = new filenotfound();
                fillmissing.Show();
            }       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sideunderline_bar.Height == all_btn.Height)
            {
                ismenbutnclicked = true; iswomanbtnclicked = true;
                isshoesbutnclicked = true; iskidsbtnclicked = true;
                if (isallbtnclicked == true)
                {
                    getvalue.claerarraylist();
                    getvalue.settingsvalues(setqury.get_query("all"));
                    getvalue.returnpreviuosvalues();
                    isallbtnclicked = false;
                    if (getvalue.totalslides < 10)
                    {
                        totllbl.Text = "0" + getvalue.totalslides.ToString();
                    }
                    else
                    {
                        totllbl.Text = getvalue.totalslides.ToString();
                    }
                }
                else
                {
                    getvalue.returnpreviuosvalues();
                    
                }
            }
            else if (sideunderline_bar.Height == men_btn.Height)
            {
                isallbtnclicked = true; iswomanbtnclicked = true;
                isshoesbutnclicked = true; iskidsbtnclicked = true;
                if (ismenbutnclicked == true)
                {
                    getvalue.claerarraylist();
                    getvalue.settingsvalues(setqury.get_query("men"));
                    getvalue.returnpreviuosvalues();
                    ismenbutnclicked = false;
                    if (getvalue.totalslides < 10)
                    {
                        totllbl.Text = "0" + getvalue.totalslides.ToString();
                    }
                    else
                    {
                        totllbl.Text = getvalue.totalslides.ToString();
                    }
                }
                else
                {
                    getvalue.returnpreviuosvalues();
                    
                }
            }
            else if (sideunderline_bar.Height == women_btn.Height)
            {
                isallbtnclicked = true; ismenbutnclicked = true;
                isshoesbutnclicked = true; iskidsbtnclicked = true;
                if (iswomanbtnclicked == true)
                {
                    getvalue.claerarraylist();
                    getvalue.settingsvalues(setqury.get_query("women"));
                    getvalue.returnpreviuosvalues();
                    iswomanbtnclicked = false;
                    if (getvalue.totalslides < 10)
                    {
                        totllbl.Text = "0" + getvalue.totalslides.ToString();
                    }
                    else
                    {
                        totllbl.Text = getvalue.totalslides.ToString();
                    }
                }
                else
                {
                    getvalue.returnpreviuosvalues();
                    
                }
            }
            else if (sideunderline_bar.Height == kids_btn.Height)
            {
                isallbtnclicked = true; ismenbutnclicked = true; iswomanbtnclicked = true;
                isshoesbutnclicked = true;
                if (iskidsbtnclicked == true)
                {
                    getvalue.claerarraylist();
                    getvalue.settingsvalues(setqury.get_query("kids"));
                    getvalue.returnpreviuosvalues();
                    iskidsbtnclicked = false;
                    if (getvalue.totalslides < 10)
                    {
                        totllbl.Text = "0" + getvalue.totalslides.ToString();
                    }
                    else
                    {
                        totllbl.Text = getvalue.totalslides.ToString();
                    }
                }
                else
                {
                    getvalue.returnpreviuosvalues();
                    
                }
            }
            else
            {
                isallbtnclicked = true; ismenbutnclicked = true; iswomanbtnclicked = true;
                iskidsbtnclicked = true;
                if (isshoesbutnclicked == true)
                {
                    getvalue.claerarraylist();
                    getvalue.settingsvalues(setqury.get_query("shoes"));
                    getvalue.returnpreviuosvalues();
                    isshoesbutnclicked = false;
                    if (getvalue.totalslides < 10)
                    {
                        totllbl.Text = "0" + getvalue.totalslides.ToString();
                    }
                    else
                    {
                        totllbl.Text = getvalue.totalslides.ToString();
                    }
                }
                else
                {
                    getvalue.returnpreviuosvalues();
                    
                }
            }
            try
            {
                if ((getvalue.cuurentslide + 1) < 10)
                {
                    currntlbl.Text = "0" + (getvalue.cuurentslide + 1).ToString();
                }
                else
                {
                    currntlbl.Text = (getvalue.cuurentslide + 1).ToString();
                }
                if (currntlbl.Text == "01")
                {
                    button1.Show();
                    button2.Hide();
                }
                else
                {
                    button1.Show();
                    button2.Show();
                }
                background2.Image = Image.FromFile(filedirectory + getvalue.picfilename);
            }
            catch (FileNotFoundException ex)
            {
                filenotfound fillmissing = new filenotfound();
                fillmissing.Show();
            }
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Enter(object sender, EventArgs e)
        {

        }

        private void all_btn_Enter(object sender, EventArgs e)
        {

        }

        private void men_btn_MouseEnter(object sender, EventArgs e)
        {

        }

        private void all_btn_MouseEnter(object sender, EventArgs e)
        {

        }

        private void all_btn_Click(object sender, EventArgs e)
        {
            sideunderline_bar.Height = all_btn.Height;
            sideunderline_bar.Top = all_btn.Top;
            button1_Click(null, null);
        }

        private void men_btn_Click(object sender, EventArgs e)
        {
            sideunderline_bar.Height = men_btn.Height;
            sideunderline_bar.Top = men_btn.Top;
            
        }

        private void shoes_btn_Click(object sender, EventArgs e)
        {
            sideunderline_bar.Height = shoes_btn.Height;
            sideunderline_bar.Top = shoes_btn.Top;
        }

        private void women_btn_Click(object sender, EventArgs e)
        {
            sideunderline_bar.Height = women_btn.Height;
            sideunderline_bar.Top = women_btn.Top;
            button1_Click(null, null);
            
        }

        private void kids_btn_Click(object sender, EventArgs e)
        {
            sideunderline_bar.Height = kids_btn.Height;
            sideunderline_bar.Top = kids_btn.Top;
            button1_Click(null, null);
        }

        private void displaylogout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 sgn = new Form1();
            this.Closed += (s, args) => this.Close();
            sgn.Show();
        }
    }
}