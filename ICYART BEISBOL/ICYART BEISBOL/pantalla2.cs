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
    public partial class pantalla2 : Form
    {
        public pantalla2()
        {
            InitializeComponent();
        }

        public pantalla2(string snumero)
        {

            InitializeComponent();
            label1.Text = snumero;
        }
        private void pantalla2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
