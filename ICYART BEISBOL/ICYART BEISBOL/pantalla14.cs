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
    public partial class pantalla14 : Form
    {
        public pantalla14()
        {
            InitializeComponent();
        }
        public pantalla14(string scv)
        {
           
            InitializeComponent();
            //scv = "0";
            lblcarrerav.Text = scv;
        }

        private void lblcarrerav_Click(object sender, EventArgs e)
        {
            FontDialog fontdialog1 = new FontDialog();
            if (fontdialog1.ShowDialog() == DialogResult.OK)
            {

                lblcarrerav.Font = fontdialog1.Font;
                fontdialog1.ShowApply = true;
            }
        }
    }
}
