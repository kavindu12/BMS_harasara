using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
namespace Harasara
{
    class dbconnect
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");
        MySqlCommand cmd;
        


        public void getData(string query)
        {
            con.Open();


            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
            

            con.Close();

        }

    }
}
