using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enchanter_Fashion
{
    public partial class Termsandpolycies : Form
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

        public Termsandpolycies()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(20, 20, Width, Height, 40, 40));
        }

        private void tmsnplycback_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to go back?", "Enchater Fashion - Registation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.IntPtr ptr = CreateRoundRectRgn(0, 0, this.Width, this.Height, 50, 50); // _BoarderRaduis can be adjusted to your needs, try 15 to start.
            this.Region = System.Drawing.Region.FromHrgn(ptr);
            DeleteObject(ptr);
        }

        private void tmsnplycsgnup_btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
