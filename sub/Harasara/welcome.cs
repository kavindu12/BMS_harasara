using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harasara
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }
        int counter = 0;
        int len = 0;
        string txt;
        private void welcome_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            txt = label1.Text;
            len = txt.Length;
            label1.Text = "";
            timer1.Start(); 



        }

        private void button2_Click(object sender, EventArgs e)
        {
            login openform = new login();
            openform.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Leave_Request openform = new Leave_Request();
            openform.Show();
            Visible = false;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            counter++;

            if(counter>len)
            {
                counter = 0;
                label1.Text = "";
            }

            else
            {
                label1.Text = txt.Substring(0, counter);
                //if (label1.ForeColor == Color.Black)
                   // label1.ForeColor = Color.MediumSeaGreen;

               // else
                   // label1.ForeColor = Color.Black;
            }
           
        }
    }
}
