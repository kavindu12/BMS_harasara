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
    public partial class ProductionLineUC : UserControl
    {
        public ProductionLineUC()
        {
            InitializeComponent();
            fillCombo();
            


        }
        public void fillCombo()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=harasara;user id=root");
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from products";
            MySqlDataReader read;

            try
            {
                
                read = command.ExecuteReader();

                while (read.Read())
                {
                    string orderID = read.GetString("orderID");
                    comboBox1.Items.Add(orderID);
                }
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }
        }
        
        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = (string)comboBox1.SelectedItem;

            MySqlConnection connection = new MySqlConnection("server=localhost;database=harasara;user id=root");
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from products where orderID=?id";
            command.Parameters.Add("?id", MySqlDbType.VarChar).Value = select;

            MySqlDataAdapter data = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();
            data.Fill(ds, "load");
            dataGridView1.DataSource = ds.Tables["load"];
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void ProductionLineUC_Load(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
