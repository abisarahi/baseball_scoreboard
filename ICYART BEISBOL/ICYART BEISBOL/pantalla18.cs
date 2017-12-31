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
    public partial class pantalla18 : Form
    {
        public pantalla18()
        {
            InitializeComponent();
        }
        public pantalla18(string sp18)
        {
            InitializeComponent();
            sp18 = "0";
            lblhito.Text = sp18;
        }

        private void lblhito_Click(object sender, EventArgs e)
        {
            FontDialog fontdialog1 = new FontDialog();
            if (fontdialog1.ShowDialog() == DialogResult.OK)
            {

                lblhito.Font = fontdialog1.Font;
                fontdialog1.ShowApply = true;
            }
        }
    }
}
