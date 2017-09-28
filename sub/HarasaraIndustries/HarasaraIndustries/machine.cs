using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Harasara;
namespace HarasaraIndustries
{
    public partial class machine : Form
    {
        public machine()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
             if (!panel3.Controls.Contains(Machines.Instance))
            {
                panel3.Controls.Add(Machines.Instance);
                Machines.Instance.Dock = DockStyle.Fill;
                Machines.Instance.BringToFront();
            }
            else

                Machines.Instance.BringToFront();

        }
       
        
    }
}
