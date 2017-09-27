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
    public partial class notification : UserControl
    {


        private static notification _instance;

        public static notification Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new notification();
                return _instance;
            }
        }
        public notification()
        {
            InitializeComponent();
        }

        private void notification_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




    }



}
