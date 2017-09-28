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
    public partial class Progress : UserControl
    {
        public Progress()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=harasara");
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO production(name,id,image,catagory) VALUES(?name,?id,?img,?catagory)";
            //command.Parameters.Add("?name", MySqlDbType.VarChar).Value = product.name;
            int progress = 0;

            if (checkedListBox1.GetItemCheckState(0) == (CheckState.Checked)&&!(checkedListBox1.GetItemCheckState(1) == CheckState.Checked)&&!(checkedListBox1.GetItemCheckState(2) == CheckState.Checked)&&!(checkedListBox1.GetItemCheckState(3) == CheckState.Checked)&&!(checkedListBox1.GetItemCheckState(4) == CheckState.Checked))
            {
                progress += 20;
            }
            else if ((checkedListBox1.GetItemCheckState(0) == CheckState.Checked)&&(checkedListBox1.GetItemCheckState(1) == CheckState.Checked))
            {
                progress += 20;
            }
            else if ((checkedListBox1.GetItemCheckState(0) == CheckState.Checked)&&(checkedListBox1.GetItemCheckState(1) == CheckState.Checked)&&(checkedListBox1.GetItemCheckState(2) == CheckState.Checked))
            {
                progress += 20;
            }
            else if ((checkedListBox1.GetItemCheckState(0) == CheckState.Checked)&&(checkedListBox1.GetItemCheckState(1) == CheckState.Checked)&&(checkedListBox1.GetItemCheckState(2) == CheckState.Checked)&&(checkedListBox1.GetItemCheckState(3) == CheckState.Checked))
            {
                progress += 20;
            }
            else if ((checkedListBox1.GetItemCheckState(0) == CheckState.Checked)&&(checkedListBox1.GetItemCheckState(1) == CheckState.Checked)&&(checkedListBox1.GetItemCheckState(2) == CheckState.Checked)&&(checkedListBox1.GetItemCheckState(3) == CheckState.Checked)&&(checkedListBox1.GetItemCheckState(4) == CheckState.Checked))
            {
                progress += 20;
            }
        }
    }
}
