using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarasaraIndustries
{
    public partial class promotions : UserControl
    {

        private static promotions _instance;
        public static promotions Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new promotions();
                return _instance;

            }
        }
        public promotions()
        {
            InitializeComponent();
        }
    }
}
