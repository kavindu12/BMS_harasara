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
    public partial class Production_Sub_User : Form
    {
        public Production_Sub_User()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Progress puc = new Progress();


            panel1.Controls.Add(puc);
            puc.Dock = DockStyle.Fill;
            puc.BringToFront();
        }
    }
}
