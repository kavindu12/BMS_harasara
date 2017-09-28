using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS_harasara
{
    public partial class ViewPrototype : UserControl
    {
        public ViewPrototype()
        {
            InitializeComponent();
            fillDG();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void fillDG()
        {
            Database db = new Database();
            DataSet ds = db.dbse("SELECT * FROM prototype");
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.DataSource = ds.Tables["load"];
        }
    }
}
