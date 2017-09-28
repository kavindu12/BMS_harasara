using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Harasara
{
    public partial class leaves : UserControl
    {

        private static leaves _instance;
        string i;
        public static leaves Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new leaves();
                return _instance;

            }
        }

        public leaves()
        {
            InitializeComponent();
        }


        MySqlConnection connect = new MySqlConnection("server=localhost;user id=root;database=harasara;Convert Zero Datetime=True");
        MySqlCommand cmd;
        
        private void leaves_Load(object sender, EventArgs e)
        {

           




           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {





        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void view_Click(object sender, EventArgs e)
        {

            connect.Open();
            MySqlDataAdapter view_t = new MySqlDataAdapter("select e.employee_id AS 'employee id',e.fname AS 'first name',e.lname AS 'last name',p.p_name AS 'Designation',d.dname AS 'Department',l.requested_date 'Leave Requested Date',l.submitted_date AS 'Request Submitted Date',l.Type,l.period,l.Reason from employee e, leaverecords l, department d, profession p where e.employee_id=l.e_id AND e.department_name=d.did AND e.position=p.job_id", connect);
           
            DataTable DT3 = new DataTable();

            view_t.Fill(DT3);
            dataGridView1.DataSource = DT3;
            int n = 0;
            foreach(DataRow item in DT3.Rows)
            {
                
                dataGridView1.Rows[n].Cells[0].Value = false;
                n++;

            }
            connect.Close();

            this.dataGridView1.DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 10.00F, FontStyle.Bold);



           
        }


       
        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            string i = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //nt id = Convert.ToInt32(i);




            //--------------------------------------copying to another table-----



            
                 /*   connect.Open();
                    

                    cmd = connect.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into leavehistory(e_id) values ('" +dataGridView1.SelectedRows[0].Cells[1].Value.ToString()+"' where e_id=)";

                    cmd.ExecuteNonQuery();


                    connect.Close();*/

          /*  label1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
           // t2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            t3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            //checkBox2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            GENDER = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            STATUS = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            t4.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            t5.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();*///---

            DataTable dt = new DataTable();
            
            this.dataGridView2.DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 10.00F, FontStyle.Bold);
            
            // int n = 0;
           dataGridView2.Rows.Clear();
            foreach(DataGridViewRow item in dataGridView1.Rows)
            {
                if((bool)item.Cells[0].Value==true)
                {
                   int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = item.Cells[1].Value.ToString();
                   // n++;
                   dataGridView2.Rows[n].Cells[1].Value = item.Cells[2].Value.ToString();
                    dataGridView2.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();
                    dataGridView2.Rows[n].Cells[3].Value = item.Cells[4].Value.ToString();
                    dataGridView2.Rows[n].Cells[4].Value = item.Cells[5].Value.ToString();
                    dataGridView2.Rows[n].Cells[5].Value = item.Cells[6].Value.ToString();
                    dataGridView2.Rows[n].Cells[6].Value = item.Cells[7].Value.ToString();
                    dataGridView2.Rows[n].Cells[7].Value = item.Cells[8].Value.ToString();
                    dataGridView2.Rows[n].Cells[8].Value = item.Cells[9].Value.ToString();
                    dataGridView2.Rows[n].Cells[9].Value = item.Cells[10].Value.ToString();
                }
            }
            
           

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if((bool)dataGridView1.SelectedRows[0].Cells[0].Value == false)
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = false;
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView2_Layout(object sender, LayoutEventArgs e)
        {
           // this.dataGridView2.DefaultCellStyle.Font = new Font("Verdana", 10);
           //this. dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 10.00F, FontStyle.Bold);
        }

        private void dataGridView1_Layout(object sender, LayoutEventArgs e)
        {
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        } 
    }


}
