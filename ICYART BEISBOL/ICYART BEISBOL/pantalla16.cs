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
    public partial class pantalla16 : Form
    {
        public int a;
        public pantalla16()
        {
            InitializeComponent();
        }

        //la localización de la letra para centrarla es 190,0 para que este en medio el cero y 190,-200 
        //para poder ponerla hacia arriba 
        public pantalla16(string sp16)
        {
            InitializeComponent();
            //sp16 = "0";
            lblerrorv.Text = sp16;
            
            //if (sp16.Equals( "10"))
            if (sp16=="10")
            {
                //lblerrorv.Location = new Point(0, 0);
                //lblerrorv.Left = 0;
                //lblerrorv.Location.X(0);
                // lblerrorv.Location = new Point(lblerrorv.Location.X,  lblerrorv.Location.Y);
                //lblerrorv.Location = new Point(lblerrorv.Location.X, lblerrorv.Location.Y);
                this.lblerrorv.Location = new Point(0, 0);
                lblerrorv.Refresh();
            }
                             
        }

        private void lblerrorv_Click(object sender, EventArgs e)
        {
            FontDialog fontdialog1 = new FontDialog();
            if (fontdialog1.ShowDialog() == DialogResult.OK )
            {
                
                lblerrorv.Font= fontdialog1.Font;
                fontdialog1.ShowApply = true;
            }
        }

        
    }
}
