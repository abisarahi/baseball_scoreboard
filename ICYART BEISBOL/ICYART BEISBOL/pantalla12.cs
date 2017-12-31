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
    public partial class pantalla12 : Form
    {
        public pantalla12()
        {
            InitializeComponent();
        }
        public pantalla12(string p12)
        {
            InitializeComponent();
            lbl9o.Text = p12;
        }
    }
}
