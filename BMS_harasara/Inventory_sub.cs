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
    public partial class inv_sub : Form
    {
        public inv_sub()
        {
            InitializeComponent();
            this.label1.Text = DateTime.Now.ToString();
            timer1.Tick += new EventHandler(timer1_Tick);
            this.timer1.Interval = 1000;
            this.timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void boardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void rawMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void partsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(inv_AddNewItem.Instance))
            {
                panel1.Controls.Add(inv_AddNewItem.Instance);
                inv_AddNewItem.Instance.Dock = DockStyle.Fill;
                inv_AddNewItem.Instance.BringToFront();
            }
            else
                inv_AddNewItem.Instance.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(inv_AddStock.Instance))
            {
                panel1.Controls.Add(inv_AddStock.Instance);
                inv_AddStock.Instance.Dock = DockStyle.Fill;
                inv_AddStock.Instance.BringToFront();
            }
            else
                inv_AddStock.Instance.BringToFront();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            main_menu mainm=new main_menu();
            this.Hide();
            mainm.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(inv_IssueStock.Instance))
            {
                panel1.Controls.Add(inv_IssueStock.Instance);
                inv_IssueStock.Instance.Dock = DockStyle.Fill;
                inv_IssueStock.Instance.BringToFront();
            }
            else
                inv_IssueStock.Instance.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(inv_CheckLevel.Instance))
            {
                panel1.Controls.Add(inv_CheckLevel.Instance);
                inv_CheckLevel.Instance.Dock = DockStyle.Fill;
                inv_CheckLevel.Instance.BringToFront();
            }
            else
                inv_CheckLevel.Instance.BringToFront();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(inv_FinishStock.Instance))
            {
                panel1.Controls.Add(inv_FinishStock.Instance);
                inv_FinishStock.Instance.Dock = DockStyle.Fill;
                inv_FinishStock.Instance.BringToFront();
            }
            else
                inv_FinishStock.Instance.BringToFront();
        
        }

        private void inv_sub_Load(object sender, EventArgs e)
        {

        }
    }
}
