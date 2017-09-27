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
    public partial class FinancialForecastUC : UserControl
    {
        private static FinancialForecastUC _instancef;
        public static FinancialForecastUC Instancef
        {
            get
            {
                if (_instancef == null)
                {
                    _instancef = new FinancialForecastUC();
                }
                return _instancef;
            }
        }
        public FinancialForecastUC()
        {
            InitializeComponent();
        }

        private void FinancialForecastUC_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(weekCashFlowUC.Instance_wcf))
            {
                panel1.Controls.Add(weekCashFlowUC.Instance_wcf);
                weekCashFlowUC.Instance_wcf.Dock = DockStyle.Fill;
                weekCashFlowUC.Instance_wcf.BringToFront();
            }
            else
            {
                weekCashFlowUC.Instance_wcf.BringToFront();
            }
        }
    }
}
