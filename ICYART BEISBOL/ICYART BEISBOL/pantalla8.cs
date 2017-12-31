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
    public partial class pantalla8 : Form
    {
        public pantalla8()
        {
            InitializeComponent();
        }

        public pantalla8(string s8)
        {
            InitializeComponent();
            lbl9v.Text = s8;
        }

        private void lbl9v_Click(object sender, EventArgs e)
        {

        }
    }
}
