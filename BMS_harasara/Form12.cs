using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarasaraIndustries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //panel3.Visible = true;
            if (!panel3.Controls.Contains(ExpenditureManager.Instance))
            {
                panel3.Controls.Add(ExpenditureManager.Instance);
                ExpenditureManager.Instance.Dock = DockStyle.Fill;
                ExpenditureManager.Instance.BringToFront();
            }
            else
            {
                ExpenditureManager.Instance.BringToFront();
            }
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

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }
    }
}
