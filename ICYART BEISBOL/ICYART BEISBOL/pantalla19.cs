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
    public partial class pantalla19 : Form
    {
        public pantalla19()
        {
            InitializeComponent();
        }
        public pantalla19(string sp19)
        {
            InitializeComponent();
            sp19 = "0";
            lblerroro.Text = sp19;
        }

        private void lblerroro_Click(object sender, EventArgs e)
        {
            FontDialog fontdialog1 = new FontDialog();
            if (fontdialog1.ShowDialog() == DialogResult.OK)
            {

                lblerroro.Font = fontdialog1.Font;
                fontdialog1.ShowApply = true;
            }
        }
    }
}
