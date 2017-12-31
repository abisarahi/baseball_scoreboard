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
    public partial class pantalla17 : Form
    {
        public pantalla17()
        {
            InitializeComponent();
        }
        public pantalla17(string sp17)
        {
            InitializeComponent();
            sp17 = "0";
            lblcarrerao.Text = sp17;
        }

        private void lblcarrerao_Click(object sender, EventArgs e)
        {
            FontDialog fontdialog1 = new FontDialog();
            if (fontdialog1.ShowDialog() == DialogResult.OK)
            {

                lblcarrerao.Font = fontdialog1.Font;
                fontdialog1.ShowApply = true;
            }
        }
    }
}
