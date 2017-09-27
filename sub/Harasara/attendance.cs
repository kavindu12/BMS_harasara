using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harasara
{
    public partial class attendance : UserControl
    {


        private static attendance _instance;

        public static attendance Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new attendance();
                return _instance; 
            }
        }
        public attendance()
        {
            InitializeComponent();
        }

        private void attendance_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
