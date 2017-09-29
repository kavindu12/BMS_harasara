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
using MySql.Data.MySqlClient;

namespace BMS_harasara
{
    public partial class inv_AddNewItem : UserControl
    {
        private static inv_AddNewItem _instance;

        public static inv_AddNewItem Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new inv_AddNewItem();
                return _instance;
            }
        }
        public inv_AddNewItem()
        {
            InitializeComponent();
            fillcombo();
            fillcombo2();
            filltable();
        }

        void fillcombo()
        {
            string qry = "Select * from warehouse;";
            

            MySqlConnection connst = new MySqlConnection("server=localhost;user id=root;database=harasara");
            MySqlCommand cmd1 = new MySqlCommand(qry, connst);
           

            MySqlDataReader reader;
            
            try
            {
                connst.Open();
                reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    string location = reader.GetString("location");
                    comboBox2.Items.Add(location);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"database error");
            }          

        }

        void fillcombo2()
        {
           
            string qry1 = "Select * from metrics;";
            MySqlConnection connst = new MySqlConnection("server=localhost;user id=root;database=harasara");
            
            MySqlCommand cmd2 = new MySqlCommand(qry1, connst);
            

            
            MySqlDataReader reader1;
            try
            {
                connst.Open();
               
                reader1 = cmd2.ExecuteReader();
                while (reader1.Read())
                {
                    string itype = reader1.GetString("type");
                    comboBox1.Items.Add(itype);

                    //string imetric = reader1.GetString("metric");
                    //comboBox3.Items.Add(imetric);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"database error");
            }
        }

        void filltable()
        {
            String qry3 = "SELECT `item_id`, `name`, `last_update`, `count`, `price`, `rol`, `min`, `metric`, `type`, `location`  from inventory";
            MySqlConnection connst = new MySqlConnection("server=localhost;user id=root;database=harasara");
            MySqlCommand cmd2 = new MySqlCommand(qry3, connst);

            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd2;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bsource = new BindingSource();

            bsource.DataSource = dbdataset;
            dataGridView1.DataSource = bsource;
            sda.Update(dbdataset);
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch)&&ch != 8&& ch != 46)
            {
                label8.Text = "Numbers only";
                e.Handled = true;
            }
            else
            {
                label8.Text = "";
            }

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                label8.Text = "Numbers only";
                e.Handled = true;
            }else{
                label8.Text="";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg.ShowDialog()==DialogResult.OK)
            {
                string picLoc = dlg.FileName.ToString();
                textBox5.Text = picLoc;

                pictureBox1.ImageLocation = picLoc;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] imageBT = null;
            FileStream fstream = new FileStream(this.textBox5.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBT = br.ReadBytes((int)fstream.Length);

            string qry = "insert into inventory(item_id,name,type,rol,metric,min,location,item_pic) values('" +this.textBox1.Text+ "','" +this.textBox2.Text +"','"+this.comboBox1.SelectedItem+"','"+this.textBox3
                .Text+"','"+this.comboBox3.SelectedItem+"','"+this.textBox4.Text+"','"+this.comboBox2.SelectedItem+"',@IMG)";
            dbconnect conn = new dbconnect();
            conn.ExQuery(qry);
            MessageBox.Show("Entry Added Success");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itype = (string)comboBox1.SelectedItem;
            string qry1 = "Select metric from metrics where type = '"+itype+"';";


            MySqlConnection connst = new MySqlConnection("server=localhost;user id=root;database=harasara");

            MySqlCommand cmd2 = new MySqlCommand(qry1, connst);
            ;


            MySqlDataReader reader1;
            try
            {
                connst.Open();

                reader1 = cmd2.ExecuteReader();
                while (reader1.Read())
                {

                    string imetric = reader1.GetString("metric");
                    comboBox3.Items.Add(imetric);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"database error");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
    }
}
