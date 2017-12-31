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
    public partial class pantalla10 : Form
    {
        public pantalla10()
        {
            InitializeComponent();
        }
        public pantalla10(string p10)
        {
            InitializeComponent();
            lbl5o.Text = p10;
        }

        private void lbl6o_Click(object sender, EventArgs e)
        {

        }
    }
}
