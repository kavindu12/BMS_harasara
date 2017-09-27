using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS_harasara
{
    public partial class inv_AddStock : UserControl
    {
        private static inv_AddStock _instance;

        public static inv_AddStock Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new inv_AddStock();
                return _instance;
            }
        }
        public inv_AddStock()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
