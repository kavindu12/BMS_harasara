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
    public partial class ProfitLossUC_Main : UserControl
    {
        private static ProfitLossUC_Main _instance_pf_main;
        public static ProfitLossUC_Main Instance_pf_main
        {
            get
            {
                if (_instance_pf_main == null)
                {
                    _instance_pf_main = new ProfitLossUC_Main();
                }
                return _instance_pf_main;
            }
        }
        public ProfitLossUC_Main()
        {
            InitializeComponent();
        }

        private void ProfitLossUC_Main_Load(object sender, EventArgs e)
        {

        }
    }
}
