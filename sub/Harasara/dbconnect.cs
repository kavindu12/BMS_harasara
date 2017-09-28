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
        public int getValue(string query)
        {
             
            con.Open();

            try
            {
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                int x = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return x;




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public string getString(string query)
        {
            con.Open();

            try
            {
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                string x = cmd.ExecuteScalar().ToString();
                con.Close();
                return x;




            }
            catch (Exception ex)
            {
                string charc = " ";
                MessageBox.Show(ex.Message, "OK");
                con.Close();
                return charc;
            }

        }
        

    }
}
