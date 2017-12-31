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
    public partial class pantalla9 : Form
    {
        public pantalla9()
        {
            InitializeComponent();
        }
        public pantalla9(string s3o)
        {
            InitializeComponent();
            lbl3o.Text = s3o;
        }
    }
}
