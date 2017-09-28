using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarasaraIndustries
{
    public partial class SystemAdmins : UserControl
    {
        DBconnect d1 = new DBconnect();
        private static SystemAdmins _instance;
        public static SystemAdmins Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new SystemAdmins();
                return _instance;

            }
        }
        public SystemAdmins()
        {
            InitializeComponent();
        }

        private void Add1_Click(object sender, EventArgs e)
        {
            string query = "insert into harasara.admins(Name,Username,Password,Position,Email,ContactNumber) values ('" + name.Text + "','" + username.Text + "','" + password.Text + "','" + position.Text + "','" + email.Text + "','" + Convert.ToInt32(contactnumber.Text) + "')";
            DBconnect d1 = new DBconnect();
            d1.InsertDeleteUpdate(query);
            admintab();
        }
        public void admintab()
        {
            string query = "select * from harasara.admins";

          
            d1.tableLoad(query, dataGridView1);
        }
        private void SystemAdmins_Load(object sender, EventArgs e)
        {

            admintab();
           
        }

        private void contactnumber_Leave(object sender, EventArgs e)
        {
           /* textBoxValidations t1 = new textBoxValidations();
            t1.ContcatNumber(contactnumber.Text, label8);*/
        }

        private void email_Leave(object sender, EventArgs e)
        {
           /* textBoxValidations t1 = new textBoxValidations();
            t1.Email(email.Text, label9);*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void position_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void email_Validated(object sender, EventArgs e)
        {
             string mail = email.Text;
            if (mail.IndexOf("@") != -1 && mail.IndexOf(".com") != -1)
            {
                if (mail.IndexOf("@") > mail.IndexOf(".com"))
                {

                    // MessageBox.Show("Please Insert valid Email");
                    email.BackColor = Color.Red;
                    email.Text = "please enter vaild mail";
                    //mail.Text = string.Empty;
                }
                else
                {

                    email.BackColor = Color.White;
                }
             
            }
            else {
                email.BackColor = Color.Red;
                email.Text = "please enter vaild mail";
               
            }

        
        }

        private void contactnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
