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

namespace BMS_harasara
{
    public partial class AddProductUC : UserControl
    {
        public AddProductUC()
        {
            InitializeComponent();
        }

        private void AddProductUC_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");
                con.Open();
                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "INSERT INTO production(name,id,catagory) VALUES(?name,?id,?catagory)";
                cmd.Parameters.Add("?name", MySqlDbType.VarChar).Value = textBox1.Text;
                cmd.Parameters.Add("?id", MySqlDbType.VarChar).Value = textBox2.Text;
                cmd.Parameters.Add("?catagory", MySqlDbType.VarChar).Value = textBox3.Text;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
