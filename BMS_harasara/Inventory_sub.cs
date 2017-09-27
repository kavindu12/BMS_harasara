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
    }
}
