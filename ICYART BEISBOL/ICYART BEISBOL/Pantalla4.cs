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
    public partial class Pantalla4 : Form
    {
        public Pantalla4()
        {
            InitializeComponent();
        }

        public Pantalla4(string num)
        {
            InitializeComponent();
            //num = "0";
            lblnum.Text = num;
        }
        private void Pantalla4_Load(object sender, EventArgs e)
        {

        }
    }
}
