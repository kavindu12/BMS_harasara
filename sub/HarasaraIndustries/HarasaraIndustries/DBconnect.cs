using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
namespace HarasaraIndustries
{
    class DBconnect
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root");
        MySqlCommand cmd;


        //me tyna funtion eken oyta onama query ekak excute krnn pluwn,Insert Update Delete

        public void InsertDeleteUpdate(string query)
        {
            con.Open();

            try
            {

                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                CustomMsgBox.Show("Process Successfull", "OK");

            }
            catch (Exception ex)
            {
                CustomMsgBox.Show(ex.Message, "OK");
                
            }

            con.Close();
        }
        //meken oyta database eke tyne ewa interfaces wla datagried view wala pennane pluwn.habai query eka ghnne...
        public void tableLoad(string query,DataGridView dw)
        {
            con.Open();
            try
            {


                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();


                DataTable dt = new DataTable();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dw.DataSource = dt;

            }
            catch (Exception ex)
            {
                CustomMsgBox.Show(ex.Message, "OK");

            }
            con.Close();
        }
             

    }
}
