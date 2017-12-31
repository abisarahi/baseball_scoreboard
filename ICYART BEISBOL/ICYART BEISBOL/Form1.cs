using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using AForge.Video;
using AForge.Video.DirectShow;
using ICYART_BEISBOL.Negocio;
using ICYART_BEISBOL.Entidad;

namespace ICYART_BEISBOL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        private void txtbx1L_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnenviarscore_Click(object sender, EventArgs e)
        {

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Muestra);
            if (frm != null)
            {

                ((Muestra)frm).lblocal.Text = txtbxlocal.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else {
                Muestra f2 = new Muestra(txtbxlocal.Text);

                f2.Show(); // mostrar el segundo formulario;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        //intención de agregar la carga de videos para que siga una url seleccionada 
        private void abrirPromosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //con esta instrucción se evita que se dupliquen las pantallas abiertas 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla2);
            if (frm != null)
            {

                ((pantalla2)frm).label1.Text = txtbxvis.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla2 f3 = new pantalla2(txtbxvis.Text);

                f3.Show(); // mostrar el segundo formulario;
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Pantalla3);
            if (frm != null)
            {

                ((Pantalla3)frm).lblnumber.Text = txtbx1L.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                Pantalla3 f4 = new Pantalla3(txtbx1L.Text);

                f4.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Pantalla4);
            if (frm != null)
            {

                ((Pantalla4)frm).lblnum.Text = txtbx2L.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                Pantalla4 f5 = new Pantalla4(txtbx2L.Text);

                f5.Show(); // mostrar el segundo formulario;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Muestra);
            if (frm != null)
            {

                ((Muestra)frm).lblbis.Text = txtbxcL.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                Muestra f2 = new Muestra(txtbxcL.Text);

            }


        }

        private void button5_Click(object sender, EventArgs e)
        {

            //con esta instrucción se evita que se dupliquen las pantallas abiertas 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla2);
            if (frm != null)
            {

                ((pantalla2)frm).lblP2.Text = txtbxcv.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla2 f3 = new pantalla2(txtbxcv.Text);

                f3.Show(); // mostrar el segundo formulario;
            }

        }

        private void btn3v_Click(object sender, EventArgs e)
        {

            //con esta instrucción se evita que se dupliquen las pantallas abiertas 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla5);
            if (frm != null)
            {

                ((pantalla5)frm).lbl3a.Text = txtbx3v.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla5 F5 = new pantalla5(txtbx3v.Text);

                F5.Show(); // mostrar el segundo formulario;
            }



        }

        private void btn4a_Click(object sender, EventArgs e)
        {
            //con esta instrucción se evita que se dupliquen las pantallas abiertas 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla5);
            if (frm != null)
            {

                ((pantalla5)frm).lbl4a.Text = txtbx4v.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla5 F5 = new pantalla5(txtbx4v.Text);

                F5.Show(); // mostrar el segundo formulario;
            }



        }

        private void btn5a_Click(object sender, EventArgs e)
        {
            //con esta instrucción se evita que se dupliquen las pantallas abiertas 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla6);
            if (frm != null)
            {

                ((pantalla6)frm).lbl5v.Text = txtbx5v.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla6 F6 = new pantalla6(txtbx5v.Text);

                F6.Show(); // mostrar el segundo formulario;
            }
        }

        private void btn6a_Click(object sender, EventArgs e)
        {
            //con esta instrucción se evita que se dupliquen las pantallas abiertas 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla6);
            if (frm != null)
            {

                ((pantalla6)frm).lbl6v.Text = txtbx6v.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla6 F6 = new pantalla6(txtbx6v.Text);

                F6.Show(); // mostrar el segundo formulario;
            }
        }

        private void btn7a_Click(object sender, EventArgs e)
        {
            //con esta instrucción se evita que se dupliquen las pantallas abiertas 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla7);
            if (frm != null)
            {

                ((pantalla7)frm).lbl7v.Text = txtbx7v.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla7 F7 = new pantalla7(txtbx7v.Text);

                F7.Show(); // mostrar el segundo formulario;
            }


        }

        private void btn8a_Click(object sender, EventArgs e)
        {
            //con esta instrucción se evita que se dupliquen las pantallas abiertas 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla7);
            if (frm != null)
            {

                ((pantalla7)frm).lbl8v.Text = txtbx8v.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla7 F7 = new pantalla7(txtbx8v.Text);

                F7.Show(); // mostrar el segundo formulario;
            }
        }

        private void btn9a_Click(object sender, EventArgs e)
        {
            //con esta instrucción se evita que se dupliquen las pantallas abiertas 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla8);
            if (frm != null)
            {

                ((pantalla8)frm).lbl9v.Text = txtbx9v.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla8 F8 = new pantalla8(txtbx9v.Text);

                F8.Show(); // mostrar el segundo formulario;
            }
        }

        private void btn10a_Click(object sender, EventArgs e)
        {
            //con esta instrucción se evita que se dupliquen las pantallas abiertas 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla8);
            if (frm != null)
            {

                ((pantalla8)frm).lbl10v.Text = txtbx10v.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla8 F8 = new pantalla8(txtbx10v.Text);

                F8.Show(); // mostrar el segundo formulario;
            }
        }

        private void btn3o_Click(object sender, EventArgs e)
        {
            //con esta instrucción se evita que se dupliquen las pantallas abiertas 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla9);
            if (frm != null)
            {

                ((pantalla9)frm).lbl3o.Text = txtbx3o.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla9 F9 = new pantalla9(txtbx3o.Text);

                F9.Show(); // mostrar el segundo formulario;
            }
        }

        private void btn4o_Click(object sender, EventArgs e)
        {
            //con esta instrucción se evita que se dupliquen las pantallas abiertas 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla9);
            if (frm != null)
            {

                ((pantalla9)frm).lbl4o.Text = txtbx4o.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla9 F9 = new pantalla9(txtbx4o.Text);

                F9.Show(); // mostrar el segundo formulario;
            }
        }

        private void btn5o_Click(object sender, EventArgs e)
        {
            //con esta instrucción se evita que se dupliquen las pantallas abiertas 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla10);
            if (frm != null)
            {

                ((pantalla10)frm).lbl5o.Text = txtbx5o.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla10 F10 = new pantalla10(txtbx5o.Text);

                F10.Show(); // mostrar el segundo formulario;
            }
        }

        private void btn6o_Click(object sender, EventArgs e)
        {
            //con esta instrucción se evita que se dupliquen las pantallas abiertas 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla10);
            if (frm != null)
            {

                ((pantalla10)frm).lbl6o.Text = txtbx6o.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla10 F10 = new pantalla10(txtbx6o.Text);

                F10.Show(); // mostrar el segundo formulario;
            }
        }

        private void btn7o_Click(object sender, EventArgs e)
        {
            //con esta instrucción se evita que se dupliquen las pantallas abiertas 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla11);
            if (frm != null)
            {

                ((pantalla11)frm).lbl7o.Text = txtbx7o.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla11 F11 = new pantalla11(txtbx7o.Text);

                F11.Show(); // mostrar el segundo formulario;
            }
        }

        private void btn8o_Click(object sender, EventArgs e)
        {
            //con esta instrucción se evita que se dupliquen las pantallas abiertas 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla11);
            if (frm != null)
            {

                ((pantalla11)frm).lbl8o.Text = txtbx8o.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla11 F11 = new pantalla11(txtbx8o.Text);

                F11.Show(); // mostrar el segundo formulario;
            }
        }

        private void btn9o_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla12);
            if (frm != null)
            {

                ((pantalla12)frm).lbl9o.Text = txtbx9o.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla12 F12 = new pantalla12(txtbx9o.Text);

                F12.Show(); // mostrar el segundo formulario;
            }
        }

        private void btn10o_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla12);
            if (frm != null)
            {

                ((pantalla12)frm).lbl10o.Text = txtbx10o.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla12 F12 = new pantalla12(txtbx10o.Text);//aqui es donde se pasa el número a initialize component en el string p12

                F12.Show(); // mostrar el segundo formulario;
            }
        }

        private void btnbola0_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Pantalla3);
            if (frm != null)
            {
                lblbola.Text = "0";
                ((Pantalla3)frm).lblnumber.Text = "0";

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                Pantalla3 f4 = new Pantalla3(txtbx1L.Text);

                f4.Show(); // mostrar el segundo formulario;
            }
        }

        private void btnbola1_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Pantalla3);
            if (frm != null)
            {
                lblbola.Text = "1";
                ((Pantalla3)frm).lblnumber.Text = "1";

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                Pantalla3 f4 = new Pantalla3(txtbx1L.Text);

                f4.Show(); // mostrar el segundo formulario;
            }
        }

        private void btnbola2_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Pantalla3);
            if (frm != null)
            {
                lblbola.Text = "2";
                ((Pantalla3)frm).lblnumber.Text = "2";
                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                Pantalla3 f4 = new Pantalla3(txtbx1L.Text);
                f4.Show(); // mostrar el segundo formulario;
            }
        }

        private void btnbola3_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Pantalla3);
            if (frm != null)
            {
                lblbola.Text = "3";
                ((Pantalla3)frm).lblnumber.Text = "3";
                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                Pantalla3 f4 = new Pantalla3(txtbx1L.Text);
                f4.Show(); // mostrar el segundo formulario;
            }
        }

        private void btnstrike0_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Pantalla4);
            if (frm != null)
            {
                lblstrike.Text = "0";
                ((Pantalla4)frm).lblnum.Text = "0";

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                Pantalla4 f5 = new Pantalla4(txtbx2L.Text);

                f5.Show(); // mostrar el segundo formulario;
            }
        }

        private void btnstrike1_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Pantalla4);
            if (frm != null)
            {
                lblstrike.Text = "1";
                ((Pantalla4)frm).lblnum.Text = "1";

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                Pantalla4 f5 = new Pantalla4(txtbx2L.Text);

                f5.Show(); // mostrar el segundo formulario;
            }
        }

        private void btnstrike2_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Pantalla4);
            if (frm != null)
            {
                lblstrike.Text = "2";
                ((Pantalla4)frm).lblnum.Text = "2";

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                Pantalla4 f5 = new Pantalla4(txtbx2L.Text);

                f5.Show(); // mostrar el segundo formulario;
            }
        }

        private void btnout0_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla13);
            if (frm != null)
            {
                lblout.Text = "0";
                ((pantalla13)frm).lblout.Text = "0";

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla13 f13 = new pantalla13(txtbx2L.Text);

                f13.Show(); // mostrar el segundo formulario;
            }
        }

        private void btnout1_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla13);
            if (frm != null)
            {
                lblout.Text = "1";
                ((pantalla13)frm).lblout.Text = "1";

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla13 f13 = new pantalla13(txtbx2L.Text);

                f13.Show(); // mostrar el segundo formulario;
            }
        }

        private void btnout2_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla13);
            if (frm != null)
            {
                lblout.Text = "2";
                ((pantalla13)frm).lblout.Text = "2";

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla13 f13 = new pantalla13(txtbx2L.Text);

                f13.Show(); // mostrar el segundo formulario;
            }
        }

        private void btnhito_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla18);
            if (frm != null)
            {

                ((pantalla18)frm).lblhito.Text = txtbxhito.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla18 F18 = new pantalla18(txtbxhito.Text);//aqui es donde se pasa el número a initialize component en el string p12

                F18.Show(); // mostrar el segundo formulario;
            }
        }

        private void btncarrerav_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla14);
            if (frm != null)
            {

                ((pantalla14)frm).lblcarrerav.Text = txtbxcarrerav.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla14 F14 = new pantalla14(txtbxcarrerav.Text);//aqui es donde se pasa el número a initialize component en el string p12

                F14.Show(); // mostrar el segundo formulario;
            }
        }

        private void btnhitv_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla15
            );
            if (frm != null)
            {

                ((pantalla15)frm).lblhitv.Text = txtbxhitv.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla15 F15 = new pantalla15(txtbxhitv.Text);//aqui es donde se pasa el número a initialize component en el string p12

                F15.Show(); // mostrar el segundo formulario;
            }
        }

        private void btnerrorv_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla16);
            if (frm != null)
            {

                ((pantalla16)frm).lblerrorv.Text = txtbxerrorv.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla16 F16 = new pantalla16(txtbxerrorv.Text);//aqui es donde se pasa el número a initialize component en el string p12

                F16.Show(); // mostrar el segundo formulario;
            }
        }

        private void btncarrerao_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla17);
            if (frm != null)
            {

                ((pantalla17)frm).lblcarrerao.Text = txtbxcarrerao.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla17 F17 = new pantalla17(txtbxerrorv.Text);//aqui es donde se pasa el número a initialize component en el string p12

                F17.Show(); // mostrar el segundo formulario;
            }
        }

        private void btnerroro_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla19);
            if (frm != null)
            {

                ((pantalla19)frm).lblerroro.Text = txtbxerroro.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla19 F19 = new pantalla19(txtbxerroro.Text);//aqui es donde se pasa el número a initialize component en el string p12

                F19.Show(); // mostrar el segundo formulario;
            }
        }

        private void buttono_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla13);
            if (frm != null)
            {

                ((pantalla13)frm).lblout.Text = textBoxo.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla13 f13 = new pantalla13(textBoxo.Text);

                f13.Show(); // mostrar el segundo formulario;
            }
        }

        private void txtbx9o_TextChanged(object sender, EventArgs e)
        {

        }

        //En esta parte trate de pasar el cambiode fuente a la pantalla 16 que es donde esta la etiqueta que quiero 
        //modificar 
        private void button6_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla16);
            FontDialog fontdialog1 = new FontDialog();
            if (fontdialog1.ShowDialog() == DialogResult.OK)
            {
                ((pantalla16)frm).lblerrorv.Font = fontdialog1.Font;

                fontdialog1.ShowApply = true;
            }
            // Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla16);
            // FontDialog fontdialog1 = new FontDialog();
            // if (fontdialog1.ShowDialog() == DialogResult.OK & !string.IsNullOrEmpty(((pantalla16)frm).lblerrorv.Text)) ;

            // pantalla16 F16 = new pantalla16 (Font);
            // ((pantalla16)frm).lblerrorv.Font;
            //F16.Show();
            //((pantalla16)frm).lblerrorv.Text = FontDialog1.   pantalla16 F16 = new pantalla16(txtbxerrorv.Text);

        }

        private void txtbx5v_TextChanged(object sender, EventArgs e)
        {

        }
        //insertar ciclo para incrementar con un boton 

        private void button7_Click(object sender, EventArgs e)
        {
            int au, suma;
            suma = 0;
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla14);
            if (frm != null)
            {

                for (au = 0; au <= 3; au++)
                {
                    suma = suma + au;

                }
                    //((Pantalla3)frm).lblnumber.Text = txtbx1L.Text;

                    ((pantalla14)frm).lblcarrerav.Text = suma.ToString();
                frm.Refresh();
                frm.BringToFront();
                return;

            }

            else
            {
                pantalla14 f4 = new pantalla14(txtbx1L.Text = suma.ToString());

                f4.Show();
            }
             
        
            } 

        private void btnvideo_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is video);
            if (frm != null)
            {

                //video frm = new video(@"C:\Users\SARA\Videos\1x5 8-8.mp4");
                ((video)frm).Visible = true;
                ((video)frm).axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                //video f4 = new video (@"C:\Users\SARA\Videos\1x5 8-8.mp4");
                video f4 = new video(openFileDialog1.FileName);
                f4.Show();
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is video);
            if (frm != null)
            {
                //   ((video)frm).Visible=false;
                ((video)frm).Visible = true;
                ((video)frm).axWindowsMediaPlayer1.Ctlcontrols.pause();

                frm.Refresh();
                // frm.BringToFront();
                frm.SendToBack();
                return;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Muestra);
            if (frm != null)
            {

                ((Muestra)frm).Close();

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                //Muestra f2 = new Muestra(txtbxcL.Text);

            }
        }

        private void btnclv2_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla5);
            if (frm != null)
            {

                ((pantalla5)frm).Close();

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            
        }

        private void btnclv3_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla6);
            if (frm != null)
            {

                ((pantalla6)frm).Close();

                frm.Refresh();
                frm.BringToFront();
                return;
            }
        }

        private void btnclv4_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla7);
            if (frm != null)
            {

                ((pantalla7)frm).Close();

                frm.Refresh();
                frm.BringToFront();
                return;
            }
        }

        private void btnclv5_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla8);
            if (frm != null)
            {

                ((pantalla8)frm).Close();

                frm.Refresh();
                frm.BringToFront();
                return;
            }
        }

        private void btnclo1_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla2);
            if (frm != null)
            {

                ((pantalla2)frm).Close();

                frm.Refresh();
                frm.BringToFront();
                return;
            }
        }

        private void btnclo2_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla9);
            if (frm != null)
            {

                ((pantalla9)frm).Close();

                frm.Refresh();
                frm.BringToFront();
                return;
            }
        }

        private void btnclo3_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla10);
            if (frm != null)
            {

                ((pantalla10)frm).Close();

                frm.Refresh();
                frm.BringToFront();
                return;
            }
        }

        private void btnclo4_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla11);
            if (frm != null)
            {

                ((pantalla11)frm).Close();

                frm.Refresh();
                frm.BringToFront();
                return;
            }
        }

        private void btnclo5_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla12);
            if (frm != null)
            {

                ((pantalla12)frm).Close();

                frm.Refresh();
                frm.BringToFront();
                return;
            }
        }

        private void btnc5_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla20);
            if (frm != null)
            {

                ((pantalla20)frm).label1.Text = txtbx5v.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla20 F20 = new pantalla20(txtbx5v.Text);

                F20.Show(); // mostrar el segundo formulario;
            }
        }

        private void btnc6_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla20);
            if (frm != null)
            {

                ((pantalla20)frm).label2.Text = txtbx6v.Text;

                frm.Refresh();
                frm.BringToFront();
                return;
            }
            else
            {
                pantalla20 F20 = new pantalla20(txtbx6v.Text);

                F20.Show(); // mostrar el segundo formulario;
            }
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is video);
            if (frm != null)
            {
                //   ((video)frm).Visible=false;
                ((video)frm).Visible = true;
                ((video)frm).axWindowsMediaPlayer1.Ctlcontrols.stop();

                frm.Refresh();
                 frm.BringToFront();
                //frm.SendToBack();
                return;
            }
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is video);
            if (frm != null)
            {
                //   ((video)frm).Visible=false;
                ((video)frm).Visible = true;
                ((video)frm).axWindowsMediaPlayer1.Ctlcontrols.play();

                frm.Refresh();
                frm.BringToFront();
                //frm.SendToBack();
                return;
            }
        }

        private void btncerr_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is video);
            if (frm != null)
            {

                ((video)frm).Close();

                frm.Refresh();
                frm.BringToFront();
                return;
            }
        }

        // private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)


        // {
        //   Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is pantalla16);
        //double a;
        //   ((pantalla16)frm).a =scroll1.Value;        
        //if (fontdialog1.ShowDialog() == DialogResult.OK & !string.IsNullOrEmpty(((pantalla16)frm).lblerrorv.Text)) ;
        //}
    }
}
