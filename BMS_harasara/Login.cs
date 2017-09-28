using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



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
            String x = check.Text.ToString();
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
            }
        }
    }
}
