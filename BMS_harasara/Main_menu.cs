using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS_harasara
{
    public partial class main_menu : Form
    {
        //Timer timer1 = new Timer();
        public main_menu()
        {
            InitializeComponent();
            this.label2.Text = DateTime.Now.ToString();
            timer1.Tick += new EventHandler(timer1_Tick);
            this.timer1.Interval = 1000;
            this.timer1.Enabled = true;
        }

        private void timer1_Tick(object sender,EventArgs e)
        {
            this.label2.Text=DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    

        void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            //Machines
            string x = "Adminstration";
            login logfrm = new login(x);
            //this.Hide();
            logfrm.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //Employees
            string x = "Employee";
            login logfrm = new login(x);
            //this.Hide();
            logfrm.Show();
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //Inventory
            string x = "Inventory";
            login logfrm = new login(x);
            //this.Hide();
            logfrm.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            //Production
            string x = "Products";
            login logfrm = new login(x);
            //this.Hide();
            logfrm.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            //Financial
            string x = "Finance";
            login logfrm = new login(x);
            //this.Hide();
            logfrm.Show();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            //Transport
            string x = "Transport";
            login logfrm = new login(x);
            //this.Hide();
            logfrm.Show();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            //Sales and purchases
            string x = "Sales";
            login logfrm = new login(x);
            //this.Hide();
            logfrm.Show();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            //System Admin
            string x = "Adminstration";
            login logfrm = new login(x);
            //this.Hide();
            logfrm.Show();
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            Harasara.Leave_Request lvreq = new Harasara.Leave_Request();
            lvreq.Show();
        }
    
    }

    
}
