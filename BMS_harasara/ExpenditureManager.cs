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

namespace HarasaraIndustries
{
    public partial class ExpenditureManager : UserControl
    {
        private static ExpenditureManager _instance;
        public static ExpenditureManager Instance
        {
            get
            {
                if(_instance==null){
                    _instance = new ExpenditureManager();
                }
                return _instance;
            }
        }
        public ExpenditureManager()
        {
            InitializeComponent();
        }

        private void ExpenditureManager_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton7_Click(object sender, EventArgs e)
        {
            MySqlConnection connectionString = new MySqlConnection("server=localhost;user id=root;database=harasaraindustries");
            MySqlCommand cmdDataBase = new MySqlCommand("select * from harasaraindustries.expentable;",connectionString);
            MySqlDataReader myReader;
            try
            {
                connectionString.Open();
                myReader = cmdDataBase.ExecuteReader();
                while(myReader.Read()){
                    this.chart1.Series["Person"].Points.AddXY(myReader.GetString("PersonValidated"), myReader.GetInt32("Income"));                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
