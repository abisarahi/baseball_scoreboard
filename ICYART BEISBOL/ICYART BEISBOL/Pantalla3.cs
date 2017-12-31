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
    public partial class Pantalla3 : Form
    {
        public Pantalla3()
        {
            InitializeComponent();
        }
        public Pantalla3 (string snumber)
        {
            InitializeComponent();
            //snumber = "0";
            lblnumber.Text = snumber;
        }
        private void Pantalla3_Load(object sender, EventArgs e)
        {

        }

        private void lblnumber_Click(object sender, EventArgs e)
        {

        }
    }
}
