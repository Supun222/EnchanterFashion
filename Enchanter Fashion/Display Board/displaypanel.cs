﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BunifuAnimatorNS;
using Enchanter_Fashion.Display_Board;

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
        int slidecounter = 0;    
        bool isallbtnclicked = true; bool ismenbutnclicked = true; bool iskidsbtnclicked = true;
        bool iswomanbtnclicked = true; bool isshoesbutnclicked = true;
        string filedirectory = @"D:\UOK\2nd YEAR\1st sem\Interactive Application Development\Project\project\Enchanter Fashion\Display Board\Images\";
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
                    slidecounter = 0;
                    isallbtnclicked = false;
                    getvalue.returnvalues(setqury.get_query("all"), slidecounter);
                }
                else
                {
                    slidecounter = slidecounter + 1;
                }
                
            }
            else if (sideunderline_bar.Height == men_btn.Height)
            {
                isallbtnclicked = true; iswomanbtnclicked = true;
                isshoesbutnclicked = true; iskidsbtnclicked = true;
                if (ismenbutnclicked == true)
                {
                    slidecounter = 0;
                    ismenbutnclicked = false;
                    getvalue.returnvalues(setqury.get_query("men"), slidecounter);
                }
                else
                {
                    slidecounter = slidecounter + 1;
                }
                
            }
            else if (sideunderline_bar.Height == women_btn.Height)
            { 
                isallbtnclicked = true; ismenbutnclicked = true;
                isshoesbutnclicked = true; iskidsbtnclicked = true;
                if (iswomanbtnclicked == true)
                {
                    slidecounter = 0;
                    iswomanbtnclicked = false;
                    getvalue.returnvalues(setqury.get_query("women"), slidecounter);
                }
                else
                {
                    slidecounter = slidecounter + 1;
                    
                }
                
            }
            else if (sideunderline_bar.Height == kids_btn.Height)
            {
                isallbtnclicked = true; ismenbutnclicked = true; iswomanbtnclicked = true;
                isshoesbutnclicked = true;
                if (iskidsbtnclicked == true)
                {
                    slidecounter = 0;
                    iskidsbtnclicked = false;
                    getvalue.returnvalues(setqury.get_query("kids"), slidecounter);
                }
                else
                {
                    slidecounter = slidecounter + 1;
                }
                
            }
            else
            {
                isallbtnclicked = true; ismenbutnclicked = true; iswomanbtnclicked = true;
                iskidsbtnclicked = true;
                if (isshoesbutnclicked == true)
                {
                    slidecounter = 0;
                    isshoesbutnclicked = false;
                    getvalue.returnvalues(setqury.get_query("shoes"), slidecounter);
                }
                else
                {
                    slidecounter = slidecounter + 1;
                }
                
            }
            //nsole.WriteLine(getvalue.picfilename);
            //ckground2.Image = Image.FromFile(filedirectory + getvalue.picfilename);
            BunifuTransition transition1 = new BunifuTransition();
            //transition1.ShowSync(background1, false, BunifuAnimatorNS.Animation.HorizSlide);
            // transition1.HideSync(background1, false, BunifuAnimatorNS.Animation.HorizSlide);
            BunifuTransition transition2 = new BunifuTransition();
            
            //transition2.HideSync(background2, false, BunifuAnimatorNS.Animation.HorizBlind);
            //transition2.ShowSync(background2, false, BunifuAnimatorNS.Animation.HorizBlind);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sideunderline_bar.Height == all_btn.Height)
            {
                ismenbutnclicked = true; iswomanbtnclicked = true;
                isshoesbutnclicked = true; iskidsbtnclicked = true;
                if (isallbtnclicked == true)
                {
                    slidecounter = 0;
                    isallbtnclicked = false;
                }
                else
                {
                    slidecounter = slidecounter - 1;
                }
                getvalue.returnvalues(setqury.get_query("all"), slidecounter);
            }
            else if (sideunderline_bar.Height == men_btn.Height)
            {
                isallbtnclicked = true; iswomanbtnclicked = true;
                isshoesbutnclicked = true; iskidsbtnclicked = true;
                if (ismenbutnclicked == true)
                {
                    slidecounter = 0;
                    ismenbutnclicked = false;
                }
                else
                {
                    slidecounter = slidecounter - 1;
                }
                getvalue.returnvalues(setqury.get_query("men"), slidecounter);
            }
            else if (sideunderline_bar.Height == women_btn.Height)
            {
                isallbtnclicked = true; ismenbutnclicked = true;
                isshoesbutnclicked = true; iskidsbtnclicked = true;
                if (iswomanbtnclicked == true)
                {
                    slidecounter = 0;
                    iswomanbtnclicked = false;
                }
                else
                {
                    slidecounter = slidecounter - 1;
                }
                getvalue.returnvalues(setqury.get_query("women"), slidecounter);
            }
            else if (sideunderline_bar.Height == kids_btn.Height)
            {
                isallbtnclicked = true; ismenbutnclicked = true; iswomanbtnclicked = true;
                isshoesbutnclicked = true;
                if (iskidsbtnclicked == true)
                {
                    slidecounter = 0;
                    iskidsbtnclicked = false;
                }
                else
                {
                    slidecounter = slidecounter - 1;
                }
                getvalue.returnvalues(setqury.get_query("kids"), slidecounter);
            }
            else
            {
                isallbtnclicked = true; ismenbutnclicked = true; iswomanbtnclicked = true;
                iskidsbtnclicked = true;
                if (isshoesbutnclicked == true)
                {
                    slidecounter = 0;
                    isshoesbutnclicked = false;
                }
                else
                {
                    slidecounter = slidecounter - 1;
                }
                getvalue.returnvalues(setqury.get_query("shoes"), slidecounter);
            }
            BunifuTransition transition1 = new BunifuTransition();
            BunifuTransition transition2 = new BunifuTransition();
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
            //BunifuTransition transition = new BunifuTransition();
            //transition.ShowSync(menbackground1, false, BunifuAnimatorNS.Animation.HorizBlind);
            //transition.HideSync(womanbackground11, false, BunifuAnimatorNS.Animation.HorizBlind);
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
            //BunifuTransition transition = new BunifuTransition();
            //transition.ShowSync(womanbackground11, false, BunifuAnimatorNS.Animation.HorizBlind);
            //transition.HideSync(menbackground1, false, BunifuAnimatorNS.Animation.HorizBlind);
        }

        private void kids_btn_Click(object sender, EventArgs e)
        {
            sideunderline_bar.Height = kids_btn.Height;
            sideunderline_bar.Top = kids_btn.Top;
            button1_Click(null, null);
        }
    }
}
