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
//using Harasara;

namespace HarasaraIndustries
{
    public partial class AdminMain : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");

        public AdminMain()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //if (!panel3.Controls.Contains(Machines.Instance))
            //{
               // panel3.Controls.Add(Machines.Instance);
               // Machines.Instance.Dock = DockStyle.Fill;
               // Machines.Instance.BringToFront();
            //}
           // else

                //Machines.Instance.BringToFront();

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

       
       
        
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            mainGUI m1 = new mainGUI();
            m1.ShowDialog();

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
             if (!panel3.Controls.Contains(SystemAdmins.Instance))
            {
                panel3.Controls.Add(SystemAdmins.Instance);
                SystemAdmins.Instance.Dock = DockStyle.Fill;
                SystemAdmins.Instance.BringToFront();
            } 
            else

                SystemAdmins.Instance.BringToFront();

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(promotions.Instance))
            {
                panel3.Controls.Add(promotions.Instance);
                promotions.Instance.Dock = DockStyle.Fill;
                promotions.Instance.BringToFront();
            }
            else

                promotions.Instance.BringToFront();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        }
    }

