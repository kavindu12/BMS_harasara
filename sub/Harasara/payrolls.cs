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
       // MySqlCommand cmd;
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
            MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(e_id) FROM leaverecords where e_id='" + textBox1.Text + "'", connect);

            connect.Open();

        

            leavecount = cmd1.ExecuteNonQuery();
            exl = nlm +  leavecount;
            label19.Text = exl.ToString(); 
            

            MySqlCommand command = connect.CreateCommand();
            command = connect.CreateCommand();
            command.CommandText = "select b.b_name,e.acc_no,COUNT(lr.e_id) from employee e, bank b , leaverecords lr where e.bank=b.b_id AND lr.e_id=e.employee_id";
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
    }
}
