using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HarasaraIndustries
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");

        public Form1()
        {
            InitializeComponent();
            
            
           
        }
      
       

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(SalesOrders.Instance))
            {
                panel3.Controls.Add(SalesOrders.Instance);
                SalesOrders.Instance.Dock = DockStyle.Fill;
                SalesOrders.Instance.BringToFront();
            }
            else

                SalesOrders.Instance.BringToFront();

        }
        
        

        private void closeWindow_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void minimizeWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(payments.Instance))
            {
                panel3.Controls.Add(payments.Instance);
                payments.Instance.Dock = DockStyle.Fill;
                payments.Instance.BringToFront();
            }
            else

                payments.Instance.BringToFront();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(PurchasingOrders.Instance))
            {
                panel3.Controls.Add(PurchasingOrders.Instance);
                PurchasingOrders.Instance.Dock = DockStyle.Fill;
                PurchasingOrders.Instance.BringToFront();
            }
            else

                PurchasingOrders.Instance.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(Reports.Instance))
            {
                panel3.Controls.Add(Reports.Instance);
                Reports.Instance.Dock = DockStyle.Fill;
                Reports.Instance.BringToFront();
            }
            else

                Reports.Instance.BringToFront();
        
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(setting.Instance))
            {
                panel3.Controls.Add(setting.Instance);
                setting.Instance.Dock = DockStyle.Fill;
                setting.Instance.BringToFront();
            }
            else

                setting.Instance.BringToFront();
            }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            mainGUI m1 = new mainGUI();
            m1.ShowDialog();

        }
        }
    }

