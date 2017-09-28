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

namespace BMS_harasara
{
    public partial class Prototype : UserControl
    {
        public Prototype()
        {
            InitializeComponent();
        }

        private void Prototype_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.JPG;*.PNG)|*.jpg;*.png";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=harasara");
                connection.Open();
                MySqlCommand command = connection.CreateCommand();

                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();

                command.CommandText = "INSERT INTO prototype(catagory,description,date,image,name,material_list) VALUES(?catagory,?description,?date,?img,?name,?material)";
                command.Parameters.Add("?name", MySqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("?description", MySqlDbType.VarChar).Value = textBox3.Text;
                command.Parameters.Add("?catagory", MySqlDbType.VarChar).Value = textBox4.Text;
                command.Parameters.Add("?material", MySqlDbType.VarChar).Value = textBox5.Text;
                command.Parameters.Add("?img", MySqlDbType.MediumBlob).Value = img;
                command.Parameters.Add("?date", MySqlDbType.DateTime).Value = DateTime.Now;
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch(Exception e2)
            {
                MessageBox.Show(e2.Message);
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
