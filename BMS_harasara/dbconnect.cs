using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;


namespace BMS_harasara
{
    public class dbconnect
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=bms_harasaradb");

        public void openconn()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            else
            {
                MessageBox.Show("Check the Database Connection");
            }
            
        }

        public void closeconn()
        {
            conn.Close();
        }

        public void ExQuery(string inqry)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = inqry;
            openconn();
            cmd.ExecuteNonQuery();
            closeconn();
        }
        public DataTable ReadValue(string qry)
        {
            string x = qry;
            DataTable dt = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(x,conn);

            da.Fill(dt);

            

            return dt;
        }
    }
}
