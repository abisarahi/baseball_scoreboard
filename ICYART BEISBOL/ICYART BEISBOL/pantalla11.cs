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
    public partial class pantalla11 : Form
    {
        public pantalla11()
        {
            InitializeComponent();
        }
        public pantalla11(string p11)
        {
            InitializeComponent();
            lbl7o.Text = p11;
        }
        
        
    }
}
