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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* Leave_Request openform = new Leave_Request();
            openform.Show();
            Visible = false;*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* login openform = new login();
            openform.Show();
            Visible = false;*/
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Leave_Request openform = new Leave_Request();
            openform.Show();
            Visible = false;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            login openform = new login();
            openform.Show();
            Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized; 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
