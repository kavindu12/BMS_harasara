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



namespace BMS_harasara
{
    public partial class login : Form
    {
        public login(string s)
        {
           
            InitializeComponent();
            check.Text = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main_menu mfr= new main_menu();
            this.Hide();
            mfr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usrnm = textBox1.Text;
            String pwd = textBox2.Text;

            String qry1="Select * from admins where Username='"+usrnm+"'and Password='"+pwd+"'";

            MySqlConnection connst = new MySqlConnection("server=localhost;user id=root;database=harasara");
            MySqlCommand cmd1 = new MySqlCommand(qry1, connst);

            try
            {
                connst.Open();
                MySqlDataReader reader = cmd1.ExecuteReader();
                while(reader.Read())
                {
                    String check = reader.GetString("Position");
                    String x = check;
                    if (x == "Inventory")
                    {
                        inv_sub invfrm = new inv_sub();
                        this.Hide();
                        invfrm.Show();
                    }
                    else if (x == "Employees")
                    {
                        Harasara.main empfrm = new Harasara.main();
                        this.Hide();
                        empfrm.Show();
                    }
                    else if (x == "Finance")
                    {
                        FinanceSub finfrm = new FinanceSub();
                        this.Hide();
                        finfrm.Show();
                    }
                    else if (x == "Adminstration")
                    {
                        Machine_sub macfrm = new Machine_sub();
                        this.Hide();
                        macfrm.Show();
                    }
                    else if (x == "Products")
                    {
                        Production_Sub_User profrm = new Production_Sub_User();
                        this.Hide();
                        profrm.Show();
                    }
                    else if (x == "Sales")
                    {
                        HarasaraIndustries.Form1 salfr = new HarasaraIndustries.Form1();
                        this.Hide();
                        salfr.Show();
                    }
                    else if (x == "Adminstration")
                    {
                        System_sub sysfrm = new System_sub();
                        this.Hide();
                        sysfrm.Show();
                    }
                    else if (x == "Transport")
                    {
                        Transport.Main trafrm = new Transport.Main();
                        this.Hide();
                        trafrm.Show();
                    }
                }
            }catch(Exception ex){
                MessageBox.Show(ex.Message, "Invalid Credentials");
            }

           /* String x = check.Text.ToString();
            if (x == "inv")
            {
                inv_sub invfrm = new inv_sub();
                this.Hide();
                invfrm.Show();
            }else if(x=="emp")
            {
                Harasara.main empfrm = new Harasara.main();
                this.Hide();
                empfrm.Show();
            }
            else if (x == "fin")
            {
                FinanceSub finfrm = new FinanceSub();
                this.Hide();
                finfrm.Show();
            }
            else if (x == "mac")
            {
                Machine_sub macfrm = new Machine_sub();
                this.Hide();
                macfrm.Show();
            }
            else if (x == "pro")
            {
                Production_Sub_User profrm = new Production_Sub_User();
                this.Hide();
                profrm.Show();
            }
            else if (x == "sal")
            {
                HarasaraIndustries.Form1 salfr = new HarasaraIndustries.Form1();
                this.Hide();
                salfr.Show();
            }
            else if (x == "sys")
            {
                System_sub sysfrm = new System_sub();
                this.Hide();
                sysfrm.Show();
            }
            else if (x == "tra")
            {
                Transport.Main trafrm = new Transport.Main();
                this.Hide();
                trafrm.Show();
            }else
            {
                MessageBox.Show("Invalid Credentials");
            }*/
        }
    }
}
