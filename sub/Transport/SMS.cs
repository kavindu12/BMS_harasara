using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Common;
using System.Net;
using System.IO;

namespace Transport
{
    public partial class SMS : Form
    {
        public SMS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dbconnect db = new dbconnect();

                
                dt = db.ReadValue("Select employeename,employeeID,contactno From employee");
                dataGridView1.DataSource = dt;
            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message, "Error");




            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dbconnect db = new dbconnect();


                dt = db.ReadValue("Select DriverID,DriverName,ContactNo From driverdetails");
                dataGridView1.DataSource = dt;
            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message, "Error");




            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > -1)
            {
                
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
               

            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            try
            {

                WebClient client = new WebClient();
                Stream s = client.OpenRead("");
                StreamReader reader = new StreamReader(s);
                string result = reader.ReadToEnd();
                MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Error");
            
            
            
            }
        }
    }
}
