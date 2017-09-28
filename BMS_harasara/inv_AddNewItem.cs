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
            //fillcombo();
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
        
    }
}
