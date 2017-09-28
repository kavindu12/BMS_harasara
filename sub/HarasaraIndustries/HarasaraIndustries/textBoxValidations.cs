using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Drawing;

namespace HarasaraIndustries
{
    class textBoxValidations
    {

        public void Email(string text,Label label)
        {
            Regex rx = new Regex(@"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");

                    bool x = rx.IsMatch(text);

                    if (x == true)
                    {
                        label.Text = "   ";
                    }
                    else
                    {
                        label.ForeColor = Color.Red;
                        label.Text = "please input valid email address";

                    }
        }
        public void ContcatNumber(string text, Label label)
        {
            try
            {
                Regex rx = new Regex(@"^(\+[0-9]{9})$");
                bool x = rx.IsMatch(text);

                if (x == true)
                {
                    label.Text = "        ";
                }
                else
                {

                    label.ForeColor = Color.Red;
                    label.Text = " Invalid Contact Number ";

                }
            }
            catch (Exception ex)
            {
                CustomMsgBox.Show(ex.Message, "OK");
            }

        }
    }
}
