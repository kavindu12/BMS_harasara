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
    public partial class FinanceSub : Form
    {
        public FinanceSub()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(ExpenditureManagerUC.Instance))
            {
                panel3.Controls.Add(ExpenditureManagerUC.Instance);
                ExpenditureManagerUC.Instance.Dock = DockStyle.Fill;
                ExpenditureManagerUC.Instance.BringToFront();
            }
            else
            {
                ExpenditureManagerUC.Instance.BringToFront();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(FinancialForecastUC.Instancef))
            {
                panel3.Controls.Add(FinancialForecastUC.Instancef);
                FinancialForecastUC.Instancef.Dock = DockStyle.Fill;
                FinancialForecastUC.Instancef.BringToFront();
            }
            else
            {
                FinancialForecastUC.Instancef.BringToFront();
            }
        }

        private void FinanceSub_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(AccountsUC.Instance_auc))
            {
                panel3.Controls.Add(AccountsUC.Instance_auc);
                AccountsUC.Instance_auc.Dock = DockStyle.Fill;
                AccountsUC.Instance_auc.BringToFront();
            }
            else
            {
                AccountsUC.Instance_auc.BringToFront();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
           /* if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }*/
        }
    }
}
