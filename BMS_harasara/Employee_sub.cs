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
    public partial class emp_sub : Form
    {
        public emp_sub()
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
    }
}
