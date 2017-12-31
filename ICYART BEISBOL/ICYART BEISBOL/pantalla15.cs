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
    public partial class pantalla15 : Form
    {
        public pantalla15()
        {
            InitializeComponent();
        }
        public pantalla15(string shito)
        {
            InitializeComponent();
            //shito = "0";
            lblhitv.Text = shito;

        }

        private void lblhitv_Click(object sender, EventArgs e)
        {
            FontDialog fontdialog1 = new FontDialog();
            if (fontdialog1.ShowDialog() == DialogResult.OK)
            {

                lblhitv.Font = fontdialog1.Font;
                fontdialog1.ShowApply = true;
            }
        }
    }
}
