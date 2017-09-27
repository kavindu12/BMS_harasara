using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Harasara
{
    public partial class Leave_Request : Form
    {
        public Leave_Request()
        {
            InitializeComponent();
        }
    //Setting the connection
       MySqlConnection connect = new MySqlConnection("server=localhost;user id=root;database=harasara;Convert Zero Datetime=True");
      

        //canceling the leave request form
        private void button2_Click(object sender, EventArgs e)
        {
            welcome backto = new welcome();
            backto.Show();
            Visible = false; 
        }

       
        private void Leave_Request_Load(object sender, EventArgs e)
        {
           
          
        }
        //Getting the value of checkboxes
        string REASON;
        string TYPE;
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            TYPE="Full Day";
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            TYPE = "Half Day";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            REASON = "Sick";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            REASON = "Bereavement";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            REASON = "Unpaid Leave";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            REASON = "Personal Leave";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            REASON = "Maternity/Paternity";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            REASON = "Other";
        }


        //inserting the values into the leaverecord table.
        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "" || textBox2.Text == "" )
            {
                MessageBox.Show("Fill Data");


            }

            else if (!checkBox7.Checked && !checkBox8.Checked)
            {
                MessageBox.Show("Please Fill The Type Of Leave");
            }


            else if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked && !checkBox5.Checked && !checkBox6.Checked && !checkBox7.Checked)
            {
                MessageBox.Show("Please Fill The Reason");
            }

            else
            {
                int eid;
                MySqlCommand cmd1 = new MySqlCommand("SELECT employee_id FROM employee where employee_id='" + textBox1.Text + "'", connect);
                MySqlCommand cmd;



                try
                {
                    connect.Open();
                    eid = (Int32)cmd1.ExecuteScalar();

                    cmd = connect.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into harasara.leaverecords(e_id,requested_date,submitted_date,Type,period,Reason) values ('" + eid + "','" + dateTimePicker1.Value.Date.ToString("yyyy/MM/dd") + "','" + dateTimePicker2.Value.Date.ToString("yyyy/MM/dd") + "','" + TYPE + "','" + this.textBox2.Text + "','" + REASON + "')";

                    cmd.ExecuteNonQuery();


                    connect.Close();

                    MessageBox.Show("Your Request Is Succesfully Submitted");
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
           // string query;
            //dbconnect d1 = new dbconnect();
            //query = "insert into harasara.leaverecords(e_id,requested_date,submitted_date,Type,period,Reason) values ('" + this.textBox1.Text + "','" + dateTimePicker1.Value.Date.ToString("yyyy/MM/dd") + "','" + dateTimePicker2.Value.Date.ToString("yyyy/MM/dd") + "','" + TYPE + "','" + this.textBox2.Text + "','" + REASON + "')";
            //d1.getData(query);
           
        }
    }
}
