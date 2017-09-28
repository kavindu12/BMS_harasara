using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.IO;
using System.Configuration;
using System.Text.RegularExpressions;
 

namespace Harasara
{


    
    public partial class emp_details : UserControl
    {
        private static emp_details _instance;

        public static emp_details Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new emp_details();
                return _instance;
            }
        }

      
        public emp_details()
        {
            InitializeComponent();
            t4.MaxLength = 10;
            t5.MaxLength = 10;
            t10.MaxLength = 12;

            
        }
        //MySqlConnection con = new MySqlConnection("server=localhost;user id=root");
       // MySqlCommand cmd;
        MySqlConnection connect = new MySqlConnection("server=localhost;user id=root;database=harasara;Convert Zero Datetime=True");
        
           // MySqlDataAdapter SDA = new MySqlDataAdapter();
        private Image originalImage;
        private void emp_details_Load(object sender, EventArgs e)
        {

            originalImage = t12.Image; 
            MySqlDataAdapter SDA = new MySqlDataAdapter("select distinct dname from department", connect);
            DataTable DT = new DataTable();
            SDA.Fill(DT);
            //t8.Items.Add("---SELECT---");
            foreach(DataRow Row in DT.Rows)
            {
                t8.Items.Add(Row["dname"].ToString());
            }



            MySqlDataAdapter bnk = new MySqlDataAdapter("select distinct b_name from bank", connect);
            DataTable DT1 = new DataTable();
            bnk.Fill(DT1);
           // t11.Items.Add("---SELECT---");
            foreach (DataRow Row in DT1.Rows)
            {
                t11.Items.Add(Row["b_name"].ToString());
            }

            



            MySqlDataAdapter job = new MySqlDataAdapter("select distinct p_name from profession", connect);
            DataTable DT2 = new DataTable();
            job.Fill(DT2);
            // t11.Items.Add("---SELECT---");
            foreach (DataRow Row in DT2.Rows)
            {
                comboBox1.Items.Add(Row["p_name"].ToString());
            }

          



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void ValidateEmail()
        {
            string email = t7.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                label16.Text = email + " is A Valid Email Address";
            else
                label16.Text = email + " is An Invalid Email Address";
        }



        private void button2_Click(object sender, EventArgs e)
        {
                 //validation


           
            
            if (t2.Text == "" || t3.Text == "" || t4.Text == "" || t5.Text == "" || t6.Text == "" || t7.Text == "" || t10.Text == "" ||  t11.SelectedIndex == -1 || comboBox1.SelectedIndex==-1||t8.SelectedIndex==-1) 
            {
                MessageBox.Show("Fill Data");


            }


            else if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Please Fill The Gender Of The Emploee");
                
            }




            else  if (!checkBox3.Checked && !checkBox4.Checked)
            {
                MessageBox.Show("Please Fill The Marital Status Of The Emploee");
            }
            else
            {

                button2.BackColor = Color.MediumSeaGreen;
                byte[] imageBt = null;
                 FileStream fstream = new FileStream(this.textBox_image_path.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageBt = br.ReadBytes((int)fstream.Length);


                int dep, pos, bb;
                //string query;

                MySqlCommand cmd1 = new MySqlCommand("SELECT did FROM department where dname='" + t8.Text + "'", connect);
                MySqlCommand cmd2 = new MySqlCommand("SELECT job_id FROM profession where p_name='" + comboBox1.Text + "'", connect);
                MySqlCommand cmd3 = new MySqlCommand("SELECT b_id FROM bank where b_name='" + t11.Text + "'", connect);
                MySqlCommand cmd;


                try
                {
                    connect.Open();
                    dep = (Int32)cmd1.ExecuteScalar();
                    pos = (Int32)cmd2.ExecuteScalar();
                    bb = (Int32)cmd3.ExecuteScalar();


                    cmd = connect.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into harasara.employee(fname,lname,dob,gender,status,mobile_no,home_phone_no,address,email,department_name,position,joined_date,acc_no,bank,image) values('" + this.t2.Text + "','" + this.t3.Text + "','" + dateTimePicker1.Value.Date.ToString("yyyy/MM/dd") + "','" + GENDER + "','" + STATUS + "','" + this.t4.Text + "','" + this.t5.Text + "','" + this.t6.Text + "','" + this.t7.Text + "','" + dep + "','" + pos + "','" + dateTimePicker2.Value.Date.ToString("yyyy/MM/dd") + "','" + this.t10.Text + "','" + bb + "',@IMG)";
                    cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt));
                    cmd.ExecuteNonQuery();


                    connect.Close();
                    MessageBox.Show("Saved Succesfully");


                    //clearing the data--------------------------
                    foreach (Control c in groupBox1.Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = "";
                        }



                        if (c is CheckBox)
                        {

                            ((CheckBox)c).Checked = false;
                        }

                        if (c is DateTimePicker)
                        {
                            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                        }

                        if (c is PictureBox)
                        {
                            t12.Image = originalImage;
                        }
                        label16.Text = "";
                    }


                    foreach (Control c in groupBox2.Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = "";
                        }


                        if (c is ComboBox)
                        {
                            comboBox1.Text = "";
                            t8.Text = "";
                            t11.Text = "";
                        }

                        if (c is DateTimePicker)
                        {
                            dateTimePicker2.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                        }
                    }

                    //---------------------------------------
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

           
            

        }

        string GENDER;
        string STATUS;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            GENDER = "Male";
            checkBox2.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            GENDER = "Female";
            checkBox1.Checked = false;    
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            STATUS ="Married";
            checkBox4.Checked = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            STATUS = "Unmarried";
            checkBox3.Checked = false;
        }

        string imgLocation = "";

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                textBox_image_path.Text= imgLocation;
                t12.ImageLocation = imgLocation;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void t3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void t12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //int emp;
           

           // MySqlCommand cmd1 = new MySqlCommand("SELECT employee_id FROM employee", connect);
             MySqlCommand cmd;



            try
            {
                connect.Open();
                //emp = (Int32)cmd1.ExecuteScalar();
               
                cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("delete from employee where employee_id='"+label1.Text+"'");
                 //cmd.CommandText = "insert into harasara.employee(fname,lname,dob,gender,status,mobile_no,home_phone_no,address,email,department_name,position,joined_date,acc_no,bank) values(
                cmd.ExecuteNonQuery();


                connect.Close();
                MessageBox.Show("Deleted Succesfully");

                //clearing the data--------------------------
                foreach (Control c in groupBox1.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }


                  
                    if (c is CheckBox)
                    {

                        ((CheckBox)c).Checked = false;
                    }

                    if (c is DateTimePicker)
                    {
                        dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                    }

                }


                foreach (Control c in groupBox2.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }


                    if (c is ComboBox)
                    {
                        comboBox1.Text = "";
                        t8.Text = "";
                        t11.Text = "";
                    }

                    if (c is DateTimePicker)
                    {
                        dateTimePicker2.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                    }
                }
                label1.Text = "";
                //---------------------------------------


                 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
           
        }

        private void t8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
              connect.Open();
            MySqlDataAdapter view_t = new MySqlDataAdapter("select e.employee_id as 'Employee id',e.fname as 'First name',e.lname as 'Last name',e.dob as 'DOB',e.gender as 'Gender',e.status as 'Status',e.mobile_no as 'Moblie No',e.home_phone_no as 'Home Phone No',e.address as 'Address',e.email as 'E-mail',d.dname as 'Department',p.p_name as 'Designation',e.joined_date as 'Joined Date',e.acc_no as 'Acc No',b.b_name as 'Bank' from employee e , department d , bank b, profession p where e.department_name=d.did AND e.position=p.job_id  AND e.bank=b.b_id", connect); 
             //MySqlDataAdapter view_t = new MySqlDataAdapter("select * from employee", connect);
            DataTable DT3 = new DataTable();

            view_t.Fill(DT3);
            dataGridView1.DataSource = DT3;
            connect.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
             
            int dep, pos, bb;
            //string query;

            MySqlCommand cmd1 = new MySqlCommand("SELECT did FROM department where dname='" + t8.Text + "'", connect);
            MySqlCommand cmd2 = new MySqlCommand("SELECT job_id FROM profession where p_name='" + comboBox1.Text + "'", connect);
            MySqlCommand cmd3 = new MySqlCommand("SELECT b_id FROM bank where b_name='" + t11.Text + "'", connect);
            //MySqlCommand cmd4 = new MySqlCommand("SELECT employee_id FROM employee", connect);
            MySqlCommand cmd;


            try
            {
                connect.Open();
                dep = (Int32)cmd1.ExecuteScalar();
                pos = (Int32)cmd2.ExecuteScalar();
                bb = (Int32)cmd3.ExecuteScalar();
               // emp= (Int32)cmd4.ExecuteScalar();


                cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("update employee set fname='" + this.t2.Text + "',lname='"+this.t3.Text + "', dob='" + dateTimePicker1.Value.Date.ToString("yyyy/MM/dd") + "',gender='" + GENDER + "',status='" + STATUS + "',mobile_no='" + this.t4.Text + "',home_phone_no='" + this.t5.Text + "',address='" + this.t6.Text + "',email='" + this.t7.Text + "',department_name='" + dep + "',position='" + pos + "',joined_date='" + dateTimePicker2.Value.Date.ToString("yyyy/MM/dd") + "',acc_no='" + this.t10.Text + "',bank='" + bb + "' where employee_id='"+label1.Text+"'");
                cmd.ExecuteNonQuery();


                connect.Close();
                MessageBox.Show("Updated Succesfully");

                //clearing the data--------------------------
                foreach (Control c in groupBox1.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }



               

                     if (c is CheckBox)
                    {

                        ((CheckBox)c).Checked = false;
                    }

                    if (c is DateTimePicker)
                    {
                        dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                    }
                    label16.Text = "";
                }


                foreach (Control c in groupBox2.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }


                    if (c is ComboBox)
                    {
                        comboBox1.Text = "";
                        t8.Text = "";
                        t11.Text = "";
                    }

                    if (c is DateTimePicker)
                    {
                        dateTimePicker2.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                    }


                } label1.Text = "";

                //---------------------------------------
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            
            

        }
       // MySqlDataReader myReader;
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label16.Text = "";
            label1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            t2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            t3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            //checkBox2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            GENDER = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            STATUS = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            t4.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            t5.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            t6.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            t7.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            t8.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            dateTimePicker2.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString(); 
            t10.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            t11.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();

            //-----------------------------------------------------------------------

            if (GENDER == "Male")
            {
                checkBox1.Checked = true;
            }else
            {
                checkBox2.Checked = true;
            }



            if (STATUS == "Married")
            {
                checkBox3.Checked = true;
            }
            else
            {
                checkBox4.Checked = true;
            }

           // t12.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
              /* byte[] imgg=(byte[])(myReader["image"]);
                if(imgg==null)
                    t12.Image=null;
                else
                {
                    MemoryStream mstream=new MemoryStream(imgg);
                    t12.Image=System.Drawing.Image.FromStream(mstream);
                }*/
        }


        //button colours
        Color c1;
        private void button2_MouseHover(object sender, EventArgs e)
        {
            c1 = button2.BackColor;
            button2.BackColor = Color.MediumSeaGreen;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {

            button2.BackColor = c1;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            c1 = button5.BackColor;
            button5.BackColor = Color.MediumSeaGreen;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {

            button5.BackColor = c1;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {

            c1 = button4.BackColor;
            button4.BackColor = Color.MediumSeaGreen;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {

            button4.BackColor = c1;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            c1 = button3.BackColor;
            button3.BackColor = Color.MediumSeaGreen;
            
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = c1;

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {

            //button2.BackColor = Color.MediumSeaGreen;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            //button2.BackColor = Color.MediumSeaGreen;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }



                if (c is CheckBox)
                {

                    ((CheckBox)c).Checked = false;
                }

                if (c is DateTimePicker)
                {
                    dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                }

                if (c is PictureBox)
                {
                    t12.Image = originalImage;
                }

            }


            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }


                if (c is ComboBox)
                {
                    comboBox1.Text = "";
                    t8.Text = "";
                    t11.Text = "";
                }

                if (c is DateTimePicker)
                {
                    dateTimePicker2.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                }
            } label1.Text = "";

        }

        private void t7_Leave(object sender, EventArgs e)
        {
            ValidateEmail();
            
        }

        private void t4_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
                if (e.KeyChar < '0' || e.KeyChar > '9')
                {

                    if (e.KeyChar != (char)8)
                        MessageBox.Show("You Have Pressed " + e.KeyChar + " .. Please Provide A valid Phone Number");
                    e.KeyChar = (Char)0;
                    t4.Text = "";
                }
            
        }


        private void t4_TextChanged(object sender, EventArgs e)
        {
           // if(t4.Text.Length>10)
           // {
               // MessageBox.Show("Valid Contact Number Should Contain 10 Digits."); 
            //}
        }

        private void t5_TextChanged(object sender, EventArgs e)
        {

        }

        private void t5_KeyPress(object sender, KeyPressEventArgs e)
        {

              if (e.KeyChar < '0' || e.KeyChar > '9')
            {

                if (e.KeyChar != (char)8)
                    MessageBox.Show("You Have Pressed " + e.KeyChar + " .. Please Provide A valid Phone Number");
                e.KeyChar = (Char)0;
                t5.Text = "";
            }
        
        }

        private void t10_KeyPress(object sender, KeyPressEventArgs e)
        {

             if (e.KeyChar < '0' || e.KeyChar > '9')
            {

                if (e.KeyChar != (char)8)
                    MessageBox.Show("You Have Pressed " + e.KeyChar + " .. Please Provide A Valid Account Number ");
                e.KeyChar = (Char)0;
                t10.Text = "";
            }
        }

        private void t2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if(char.IsLetter(e.KeyChar)||e.KeyChar==8)
            {
                e.Handled = false;
            }
            
            //e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 ? false : true; MessageBox.Show("You are not allowed to use digits.");

            else
            {
                e.Handled = true;
                MessageBox.Show("Not Allowed To Use Digits Here.");
            }
        }

        private void t3_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }


            else
            {
                e.Handled = true;
                MessageBox.Show("Not Allowed To Use Digits Here.");
            }
        
        }

        private void groupBox1_Leave(object sender, EventArgs e)
        {

            
        }

        private void t4_Leave(object sender, EventArgs e)
        {
            if(t4.Text.Length<10)
            {
                label17.Text="Invalid Phone Number";
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void t5_Leave(object sender, EventArgs e)
        {

            if (t5.Text.Length < 10)
            {
                label18.Text = "Invalid Phone Number";
            }

            else
            {
                label18.Text = "";
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
         



    }
}
 