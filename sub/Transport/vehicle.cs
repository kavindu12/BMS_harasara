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

namespace Transport
{
    public partial class vehicle : Form
    {
        public vehicle()
        {
            InitializeComponent();
        }

        //MySqlConnection connnection = new MySqlConnection("server=localhost;user id=root;database=harasara");

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m1 = new Main();
            m1.ShowDialog();
            this.Close();
        }

        private void bunifuThinButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m1 = new Main();
            m1.ShowDialog();
            this.Close();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            repair re1 = new repair();
            re1.ShowDialog();
            this.Close();

        }

        private void vehicle_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dbconnect db = new dbconnect();

                String id;
                //String text;
                id = bunifuTextbox1.text;


                dt = db.ReadValue("Select * From vehicles where '" + id + "' = VehicleID");
                dataGridView1.DataSource = dt;
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");

            }
        }

        private void bunifuThinButton9_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dbconnect db = new dbconnect();

            try
            {

                dt = db.ReadValue("Select * From vehicles");
                dataGridView1.DataSource = dt;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");

            }

        }

        private void bunifuThinButton7_Click(object sender, EventArgs e)
        {
            //clear feilds
            bunifuCustomTextbox1.Clear();
            bunifuCustomTextbox2.Clear();
            bunifuCustomTextbox3.Clear();
            bunifuCustomTextbox4.Clear();
            bunifuCustomTextbox5.Clear();
            bunifuCustomTextbox6.Clear();
            
        }

        private void bunifuThinButton8_Click(object sender, EventArgs e)
        {
            //Adding vehicle info
            DataTable dt = new DataTable();
            dbconnect db = new dbconnect();
            /*
            //String ID;
            String Type;
            String Number;
            String Milage;
            String Repairs;
            String Notes;
            String Avail;




           // Type = bunifuCustomTextbox3.Text;
           // Number = bunifuCustomTextbox4.Text;
           // Milage = bunifuCustomTextbox5.Text;
           // Repairs = bunifuCustomTextbox6.Text;
           // Notes = bunifuCustomTextbox2.Text;
           // Avail = bunifuCustomTextbox1.Text;
            //insert into table
            */
           
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");

                String insert = "INSERT INTO vehicles(VehicleID,VehicleNumber,VehicleType,Milage, NoOfRepairs,Availability,Notes) VALUES('" + this.bunifuCustomTextbox7 + "','" + this.bunifuCustomTextbox4 + "','" + this.bunifuCustomTextbox3 + "','" + this.bunifuCustomTextbox5 + "','" + this.bunifuCustomTextbox6 + "','" + this.bunifuCustomTextbox2 + "' ";
                MySqlCommand command = new MySqlCommand(insert, con);
                
                MySqlDataReader myreader;
                try
             {

                con.Open();
                myreader = command.ExecuteReader();
                MessageBox.Show("Saved Successfully");

            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");

            }
        }

        private void bunifuThinButton6_Click(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //dbconnect db = new dbconnect();

            
            


           
        }

        private void bunifuCustomTextbox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!char.IsDigit(ch) && ch != 8 && ch != 46 )
            {

            e.Handled = true;
            
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > -1)
            {
                bunifuCustomTextbox7.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                bunifuCustomTextbox4.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                bunifuCustomTextbox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                bunifuCustomTextbox5.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                bunifuCustomTextbox6.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                bunifuCustomTextbox1.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                bunifuCustomTextbox2.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                
                //comboBox1.Text = DataGridView01.Rows[e.RowIndex].Cells[1].Value.ToString();
                //Txt_FirstName.Text = DataGridView01.Rows[e.RowIndex].Cells[2].Value.ToString();
                //mIDDLENAMETextBox.Text = DataGridView01.Rows[e.RowIndex].Cells[3].Value.ToString();
                //sURNAMETextBox.Text = DataGridView01.Rows[e.RowIndex].Cells[4].Value.ToString();
                //cITYTextBox.Text = DataGridView01.Rows[e.RowIndex].Cells[5].Value.ToString();
                //eMAILTextBox.Text = DataGridView01.Rows[e.RowIndex].Cells[6].Value.ToString();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCustomTextbox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsLetter(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }
        }

        private void bunifuCustomTextbox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {

                e.Handled = true;

            }
        }

        private void bunifuCustomTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsLetter(ch) && ch != 8 && ch != 46)
            {

                e.Handled = true;

            }
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {
            bunifuCustomTextbox1.MaxLength = 3;
        }

        private void bunifuCustomTextbox6_TextChanged(object sender, EventArgs e)
        {
            bunifuCustomTextbox6.MaxLength = 3;
            
        }

        private void bunifuCustomTextbox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsLetterOrDigit(ch))
            {
                e.Handled = true;

            }
        }
    }
}
