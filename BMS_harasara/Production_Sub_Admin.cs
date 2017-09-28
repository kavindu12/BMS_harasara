using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS_harasara
{
    public partial class Production_Sub_Admin : Form
    {
        public Production_Sub_Admin()
        {
            InitializeComponent();
            timer1.Start();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                const int resizeArea = 10;
                Point cursorPosition = PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                if (cursorPosition.X >= ClientSize.Width - resizeArea && cursorPosition.Y >= ClientSize.Height - resizeArea)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }

            base.WndProc(ref m);
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ProductsUC puc = new ProductsUC();
            
            
            panel1.Controls.Add(puc);
            puc.Dock = DockStyle.Fill;
            puc.BringToFront();
            
            
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Production_Sub_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.time_lbl.Text = datetime.ToString();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            ProductionLineUC puc = new ProductionLineUC();


            panel1.Controls.Add(puc);
            puc.Dock = DockStyle.Fill;
            puc.BringToFront();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Prototype puc = new Prototype();


            panel1.Controls.Add(puc);
            puc.Dock = DockStyle.Fill;
            puc.BringToFront();

        }
    }
}
