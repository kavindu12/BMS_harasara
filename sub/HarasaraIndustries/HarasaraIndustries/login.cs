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
    public partial class login : Form
    {

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root");
        MySqlCommand cmd;
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            textBox1.Text = "";

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from harasara.admins where Username='"+textBox1.Text+"'";

           // main hr = new main();
           // hr.Show();
           // Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form1 back = new Form1();
            //back.Show();
           // Visible = false;
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            // welcome back = new welcome();
           // back.Show();
            //Visible = false;

        }
    }
}
