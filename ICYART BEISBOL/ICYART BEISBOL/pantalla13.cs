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
    public partial class pantalla13 : Form
    {
        public pantalla13()
        {
            InitializeComponent();
        }

        public pantalla13(string sout)
        {
            InitializeComponent();
            //sout = "0";
            lblout.Text = sout;
        }
    }
}
