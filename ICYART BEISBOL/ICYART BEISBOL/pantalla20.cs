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
    public partial class pantalla20 : Form
    {
        public pantalla20()
        {
            InitializeComponent();
        }

        public pantalla20(string mn)
        {
            InitializeComponent();
            label1.Text = mn;
            
        }
        private void pantalla20_Load(object sender, EventArgs e)
        {

        }
    }
}
