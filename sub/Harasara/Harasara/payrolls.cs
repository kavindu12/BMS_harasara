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
    public partial class payrolls : UserControl
    {

        private static payrolls _instance;

        public static payrolls Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new payrolls();
                return _instance;
            }
        }

        MySqlConnection connect = new MySqlConnection("server=localhost;user id=root;database=harasara");
        MySqlCommand cmd3;
        public payrolls()
        {
            InitializeComponent();
        }

        private void payrolls_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int nlm = 10;
            label17.Text = nlm.ToString();
            int leavecount,exl;
            double OT,OT2,sal,netsal;

            connect.Open();

          /*  MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(e_id) FROM leaverecords where e_id='" + textBox1.Text + "'", connect);
            object o = cmd1.ExecuteScalar();
            leavecount = Convert.ToInt32(o);*/
            
            MySqlCommand cmd1 = connect.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT COUNT(e_id) FROM leaverecords where e_id='" + textBox1.Text + "'";
            object o = cmd1.ExecuteScalar();
            leavecount = Convert.ToInt32(o);

//------------------------------------------------------------------------------------
          
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select p.OT_rate from profession  p, employee e where e.position=p.job_id AND e.employee_id='" + this.textBox1.Text + "' ";
            object p = cmd.ExecuteScalar();
            OT = Convert.ToInt32(p);
           // connect.Close();
//---------------------------------------------------------------------------------------
            
            MySqlCommand command1 = connect.CreateCommand();
            command1 = connect.CreateCommand();
            //command1.CommandText = "select p.OT_rate from profession  p, employee e where e.position=p.job_id AND e.employee_id='" + this.textBox1.Text+ "' ";
           // OT = command1.ExecuteNonQuery();
           OT2=OT *Convert.ToInt32(this.textBox2.Text);    
           // --------------------------------------------------------------

           MySqlCommand cmd2= connect.CreateCommand();
           cmd2.CommandType = CommandType.Text;
           cmd2.CommandText = "select p.basic_allowance from profession  p, employee e where e.position=p.job_id AND e.employee_id='" + this.textBox1.Text + "' ";
           object basic = cmd2.ExecuteScalar();
           sal = Convert.ToInt32(basic);
           // MessageBox.Show("" + OT);

           label24.Text = sal.ToString();
            label28.Text = OT2.ToString();
            command1.CommandType = CommandType.Text;


            //calculating final net salary
            netsal = sal + OT2;
            label31.Text = netsal.ToString();


            //leavecount

          
           
            exl = nlm - leavecount;
            label19.Text = exl.ToString(); 
            

            MySqlCommand command = connect.CreateCommand();
            command = connect.CreateCommand();
            command.CommandText = "select b.b_name,e.acc_no,COUNT(lr.e_id) from employee e, bank b , leaverecords lr where e.bank=b.b_id AND lr.e_id=e.employee_id AND lr.e_id = '"+textBox1.Text+"'";
            command.CommandType = CommandType.Text;
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                label15.Text = reader.GetString(0).ToString();
                label16.Text = reader.GetString(1).ToString();
                label18.Text = reader.GetString(2).ToString();
                string output = reader.ToString().ToString();
            }
            reader.Close();
            connect.Close();

                 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label15.Text="";
            label16.Text="";
            label18.Text = "";
            label19.Text = "";
            label24.Text = "";
            label28.Text = "";
            label31.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            label17.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connect.Open();
            cmd3 = connect.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "insert into harasara.salary(e_id,netsalary) values('"+textBox1.Text+"','" + label31.Text+ "')";

            cmd3.ExecuteNonQuery();


            connect.Close();
            MessageBox.Show("Submitted Succesfully");
        }
    }
}
