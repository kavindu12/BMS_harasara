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
    public partial class main : Form
    {

        int pw;
        bool hided;

        public main()
        {
            InitializeComponent();
            pw = drawer.Width;
            hided = false;
        }
        private void main_Load(object sender,EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       private void mnbtn_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void drawer_Paint(object sender, PaintEventArgs e)
        {

        }


        /*private void timer2_Tick(object sender, EventArgs e)
        {
            if(hided)
            {
                drawer.Width = drawer.Width + 20;
                if(drawer.Width>=pw)
                {
                    timer2.Stop();
                    hided = false;
                    this.Refresh();
                }
            }
            else
            {
                drawer.Width = drawer.Width - 20;
                if(drawer.Width<=0)
                {
                    timer2.Stop();
                    hided = true;
                    this.Refresh();
                }
            }
        }*/

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

           

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(emp_details.Instance))
            {
                panel3.Controls.Add(emp_details.Instance);
                emp_details.Instance.Dock = DockStyle.Fill;
                emp_details.Instance.BringToFront();

            }

            else
                emp_details.Instance.BringToFront();
        }

        private void btn6_Click(object sender, EventArgs e)
        {

            if (!panel3.Controls.Contains(search.Instance))
            {
                panel3.Controls.Add(search.Instance);
                search.Instance.Dock = DockStyle.Fill;
                search.Instance.BringToFront();
            }

            else
                search.Instance.BringToFront();


        }

        private void btn4_Click(object sender, EventArgs e)
        {

            if (!panel3.Controls.Contains(payrolls.Instance))
            {
                panel3.Controls.Add(payrolls.Instance);
                payrolls.Instance.Dock = DockStyle.Fill;
                payrolls.Instance.BringToFront();
            }

            else
                payrolls.Instance.BringToFront();


        }

        private void btn3_Click(object sender, EventArgs e)
        {


            if (!panel3.Controls.Contains(leaves.Instance))
            {
                panel3.Controls.Add(leaves.Instance);
                leaves.Instance.Dock = DockStyle.Fill;
                leaves.Instance.BringToFront();
            }

            else
                leaves.Instance.BringToFront();



        }

        private void btn5_Click(object sender, EventArgs e)
        {
             if (!panel3.Controls.Contains(notification.Instance))
            {
                panel3.Controls.Add(notification.Instance);
                notification.Instance.Dock = DockStyle.Fill;
                notification.Instance.BringToFront();
            }

            else
                notification.Instance.BringToFront();





        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(attendance.Instance))
            {
                panel3.Controls.Add(attendance.Instance);
                attendance.Instance.Dock = DockStyle.Fill;
                attendance.Instance.BringToFront();
            }

            else
                attendance.Instance.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            welcome reload = new welcome();
            reload.Show();
            Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start(); 
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start(); 
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (hided)
            {
                drawer.Width = drawer.Width + 20;
                if (drawer.Width >= pw)
                {
                    timer2.Stop();
                    hided = false;
                    this.Refresh();
                }
            }
            else
            {
                drawer.Width = drawer.Width - 20;
                if (drawer.Width <= 0)
                {
                    timer2.Stop();
                    hided = true;
                    this.Refresh();
                }
            }

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
