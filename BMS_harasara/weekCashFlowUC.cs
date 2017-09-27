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
    public partial class weekCashFlowUC : UserControl
    {
        private static weekCashFlowUC _instance_wkf;
        public static weekCashFlowUC Instance_wcf
        {
            get
            {
                if(_instance_wkf==null)
                {
                    _instance_wkf = new weekCashFlowUC();
                }
                return _instance_wkf;
            }

        }
        public weekCashFlowUC()
        {
            InitializeComponent();
        }

        private void weekCashFlowUC_Load(object sender, EventArgs e)
        {

        }
    }
}
