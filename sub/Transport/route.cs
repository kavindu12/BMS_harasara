using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transport
{
    public partial class route : Form
    {
        public route()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m1 = new Main();
            m1.ShowDialog();
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void bunifuThinButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m1 = new Main();
            m1.ShowDialog();
            this.Close();
        }

        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            orderRoute or1 = new orderRoute();
            or1.ShowDialog();
            this.Close();
        }

        private void bunifuThinButton2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Main m1 = new Main();
            m1.ShowDialog();
            this.Close();
        }

        private void route_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bunifuCustomDataGrid1.Rows.Count > -1)
            {
                bunifuCustomTextbox1.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
                bunifuCustomTextbox4.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
                bunifuCustomTextbox3.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
                bunifuCustomTextbox2.Text = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
    

            }
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
