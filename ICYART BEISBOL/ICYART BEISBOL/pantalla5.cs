using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICYART_BEISBOL
{
    public partial class pantalla5 : Form
    {
        public pantalla5()
        {
            InitializeComponent();
        }
        public pantalla5(string s3)
         {
            InitializeComponent();
            lbl3a.Text = s3;
            //lbl4a.Text = s4;

        }
    }
}
