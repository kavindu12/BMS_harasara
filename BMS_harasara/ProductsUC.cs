using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;

namespace BMS_harasara
{
	public partial class ProductsUC : UserControl
	{
		public ProductsUC()
		{
			InitializeComponent();
            Product product = new Product();
		}
        
		public void fillDataGrid()
		{
			Database db = new Database();
			DataSet ds = db.dbse("SELECT * FROM production");
			datagrid1.RowTemplate.Height = 60;
			datagrid1.DataSource = ds.Tables["load"];

            datagrid1.Columns["material_list"].Visible = false;
            //datagrid1.Columns["catagory"].Visible = false;
            datagrid1.Columns["image"].Visible = false;
            //datagrid1.Columns["description"].Visible = false;
			
			datagrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

		}
        public Boolean checkProcduct(string id)
        {
            try
            {
                string productid=id;

                MySqlConnection connection = new MySqlConnection("server=localhost;database=harasara;user id=root");
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "select * from production where id=?id";
                command.Parameters.Add("?id", MySqlDbType.VarChar).Value =productid;

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
                return false;

            }
        }
        
        public void search(string id)
        {
            try
            {
                Product product = new Product();
                product.productid = id;

                MySqlConnection connection = new MySqlConnection("server=localhost;database=harasara;user id=root");
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "select * from production where id=?id";
                command.Parameters.Add("?id", MySqlDbType.VarChar).Value = product.productid;

                MySqlDataReader reader = command.ExecuteReader();

                
                    while (reader.Read())
                    {
                        nametxt.Text = (reader["name"].ToString());
                        catagorytxt.Text = (reader["catagory"].ToString());
                    }

                
            }
            catch (Exception ee4)
            {
                MessageBox.Show(ee4.Message);
              

            }
        }

		private void bunifuThinButton1_Click(object sender, EventArgs e)
		{
			fillDataGrid();


		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void bunifuThinButton2_Click(object sender, EventArgs e)
		{
			
			
		}
		
		

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel2_Paint_1(object sender, PaintEventArgs e)
		{

		}

		private void ProdutsUC_Load(object sender, EventArgs e)
		{
			fillDataGrid();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void bunifuCustomLabel1_Click(object sender, EventArgs e)
		{

		}

		private void bunifuCustomLabel3_Click(object sender, EventArgs e)
		{

		}

		private void bunifuThinButton3_Click(object sender, EventArgs e)
		{
			OpenFileDialog opf = new OpenFileDialog();
			opf.Filter = "Choose Image(*.JPG;*.PNG)|*.jpg;*.png";
			if (opf.ShowDialog() == DialogResult.OK)
			{
				pictureBox1.Image = Image.FromFile(opf.FileName);
			}
		}

		private void datagrid1_Click(object sender, EventArgs e)
		{
			Byte[] img = (Byte[])datagrid1.CurrentRow.Cells[3].Value;

			MemoryStream ms = new MemoryStream(img);

			pictureBox1.Image = Image.FromStream(ms);

			nametxt.Text = datagrid1.CurrentRow.Cells[0].Value.ToString();
			productidtxt.Text = datagrid1.CurrentRow.Cells[1].Value.ToString();
			catagorytxt.Text = datagrid1.CurrentRow.Cells[4].Value.ToString();

		}

		private void bunifuThinButton1_Click_1(object sender, EventArgs e)
		{
			
		}

		private void searchbutton_Click(object sender, EventArgs e)
		{
            

            if (checkProcduct(productidtxt.Text))
            {
                search(productidtxt.Text);
            }
            else
            {
                MessageBox.Show("Please re enter a valid product ID");
            }
		}

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                product.name = nametxt.Text;
                product.productid = productidtxt.Text;
                product.catagory = catagorytxt.Text;
                product.description = descriptiontxt.Text;




                MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=harasara");
                connection.Open();

                if (!String.IsNullOrWhiteSpace(nametxt.Text) && !String.IsNullOrWhiteSpace(catagorytxt.Text))
                {
                   

                if (!checkProcduct(product.productid))
                {
                    MySqlCommand command = connection.CreateCommand();

                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    command.CommandText = "INSERT INTO production(name,id,image,catagory) VALUES(?name,?id,?img,?catagory)";
                    command.Parameters.Add("?name", MySqlDbType.VarChar).Value = product.name;
                    command.Parameters.Add("?id", MySqlDbType.VarChar).Value = product.productid;
                    command.Parameters.Add("?catagory", MySqlDbType.VarChar).Value = product.catagory;
                    command.Parameters.Add("?img", MySqlDbType.MediumBlob).Value = img;
                    command.ExecuteNonQuery();
                    connection.Close();

                    fillDataGrid();
                }
                else
                {
                    
                        MySqlCommand command = connection.CreateCommand();

                        MemoryStream ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        byte[] img = ms.ToArray();

                        command.CommandText = "UPDATE production SET name=?name,id=?id,image=?img,catagory=?catagory WHERE id=?id";
                        command.Parameters.Add("?name", MySqlDbType.VarChar).Value = product.name;
                        command.Parameters.Add("?id", MySqlDbType.VarChar).Value = product.productid;
                        command.Parameters.Add("?catagory", MySqlDbType.VarChar).Value = product.catagory;
                        command.Parameters.Add("?img", MySqlDbType.MediumBlob).Value = img;
                        command.ExecuteNonQuery();
                        connection.Close();

                        fillDataGrid();
                    
                    
                }
                }
                else
                {
                    MessageBox.Show("Please fill all the fields");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void productidtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton1_Click_2(object sender, EventArgs e)
        {
           
        }
	}
}
