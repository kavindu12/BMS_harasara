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
using System.IO;

namespace Harasara
{
    public partial class search : UserControl
    {

        private static search _instance;

        public static search Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new search();
                return _instance;
            }
        }
        private Image originalImage;
        MySqlConnection connect = new MySqlConnection("server=localhost;user id=root;database=harasara");
        public search()
        {
            InitializeComponent();
        }

        private void search_Load(object sender, EventArgs e)
        {
            originalImage = pictureBox1.Image;
        }

       // MySqlConnection connect = new MySqlConnection("server=localhost;user id=root;database=harasara;Convert Zero Datetime=True");
        private void button3_Click(object sender, EventArgs e)
        {
               
           /* if (!panel3.Controls.Contains(personal_details.Instance))
            {
                panel3.Controls.Add(personal_details.Instance);
                personal_details.Instance.Dock = DockStyle.Fill;
                personal_details.Instance.BringToFront();
            }

            else
                personal_details.Instance.BringToFront();*/

            connect.Open();
            MySqlCommand  command= connect.CreateCommand();
            command=connect.CreateCommand();
           // command.CommandText = "select  e.fname,e.lname,e.address,e.email,e.gender,e.mobile_no,e.home_phone_no,e.acc_no,b.b_name, from employee e, bank b where e.bank=b.b_id AND e.employee_id='"+this.textBox1.Text+"'";
            command.CommandText = "select e.fname,e.lname,e.address,e.email,e.gender,e.mobile_no,e.home_phone_no,e.acc_no,b.b_name from employee e , bank b where e.bank=b.b_id AND e.employee_id='" + textBox1.Text + "'";
           command.CommandType = CommandType.Text;
            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                label8.Text=reader.GetString(0).ToString();
                label9.Text=reader.GetString(1).ToString();
                label11.Text=reader.GetString(2).ToString();
                label12.Text=reader.GetString(3).ToString();
                label10.Text=reader.GetString(4).ToString();
                label13.Text=reader.GetString(5).ToString();
                label14.Text=reader.GetString(6).ToString();
                label27.Text=reader.GetString(7).ToString();
                label28.Text = reader.GetString(8).ToString();
                string output = reader.ToString().ToString();
            }
            reader.Close();
            connect.Close();

                 
        }

        private void button2_Click(object sender, EventArgs e)
        {

          /*  if (!panel3.Controls.Contains(OfficialDetails.Instance))
            {
                panel3.Controls.Add(OfficialDetails.Instance);
                OfficialDetails.Instance.Dock = DockStyle.Fill;
                OfficialDetails.Instance.BringToFront();
            }

            else
                OfficialDetails.Instance.BringToFront();*/


            connect.Open();
            MySqlCommand command = connect.CreateCommand();
            command = connect.CreateCommand();
            
           //
           command.CommandText = " select p.p_name,e.joined_date,d.dname from profession p, employee e, department d where e.position=p.job_id AND e.department_name=d.did AND e.employee_id='" + textBox1.Text + "'";

           // command.CommandText = "select fname,lname,gender from employee where employee_id='" + this.textBox1.Text + "'";
            command.CommandType = CommandType.Text;
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                label23.Text = reader.GetString(0).ToString();
                label20.Text = reader.GetString(1).ToString();
                label18.Text = reader.GetString(2).ToString();
                string output = reader.ToString().ToString();
               
            }
            reader.Close();
            connect.Close();


        }

        private void button4_Click(object sender, EventArgs e)
        {

            connect.Open();
           // MySqlDataAdapter view_t = new MySqlDataAdapter("select e.employee_id as 'Employee id',e.fname as 'First name',e.lname as 'Last name',e.dob as 'DOB',e.gender as 'Gender',e.status as 'Status',e.mobile_no as 'Moblie No',e.home_phone_no as 'Home Phone No',e.address as 'Address',e.email as 'E-mail',d.dname as 'Department',p.p_name as 'Designation',e.joined_date as 'Joined Date',e.acc_no as 'Acc No',b.b_name as 'Bank' from employee e , department d , bank b, profession p where e.department_name=d.did AND e.position=p.job_id  AND e.bank=b.b_id", connect);
            //MySqlDataAdapter view_t = new MySqlDataAdapter("select * from employee", connect);
            MySqlDataAdapter view_t = new MySqlDataAdapter("select employee_id AS 'Employee ID' from employee ", connect);
            DataTable DT3 = new DataTable();

            view_t.Fill(DT3);
            dataGridView1.DataSource = DT3;
            connect.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          // textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void dataGridView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string query = "select image from harasara.employee where employee_id='" + this.textBox1.Text + "'";
            //MySqlConnection conDataBase = new MySqlConnection(connect);
            MySqlCommand cmdDataBase = new MySqlCommand(query, connect);
            MySqlDataReader myReader;

            try
            {
                connect.Open();
                myReader = cmdDataBase.ExecuteReader();

                while(myReader.Read())
                {
                    byte[] imgg = (byte[])(myReader["image"]);
                    if (imgg == null)
                        pictureBox1.Image = null;
                    else
                    {
                        MemoryStream mstream = new MemoryStream(imgg);
                        pictureBox1.Image = System.Drawing.Image.FromStream(mstream);
                    }


                } 
                
                connect.Close(); 
            }


            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       
        private void button5_Click(object sender, EventArgs e)
        {
                pictureBox1.Image = originalImage;
            //pictureBox1.InitialImage = null;
            //pictureBox1.Image = null;
                label8.Text = "";
                label9.Text = "";
                label11.Text = "";
                label12.Text = "";
                label10.Text = "";
                label13.Text = "";
                label14.Text = "";
                label27.Text = "";
                label28.Text = "";
                textBox1.Text = "";
                label23.Text = "";
                label20.Text = "";
                label18.Text = "";
        }
    }
}
