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
    public partial class pantalla7 : Form
    {
        public pantalla7()
        {
            InitializeComponent();
        }

        public pantalla7(string s7)
        {
            InitializeComponent();
            lbl7v.Text = s7;
        }
    }
}
