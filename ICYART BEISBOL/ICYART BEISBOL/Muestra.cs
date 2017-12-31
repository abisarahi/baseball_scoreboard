using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using ICYART_BEISBOL.Negocio;
using System.IO;

namespace ICYART_BEISBOL
{
    public partial class Muestra : Form
    {
        public string sgIdJugador;

        public Muestra()
        {
            InitializeComponent();
        }

        public Muestra( string sVisitante) {

            //oleDbDataAdapter1.Fill(datos); Muestra(string sLocal, string sVisitante, string idJugador, string video)

            //Desde la clase de Negocio obtenemos los datos:
            InitializeComponent();
           // video= OpenFileDialog1.

            //Establecemos el marcador y el id del Jugador
          //  lblocal.Text = sLocal;
            lblocal.Text = sVisitante;
           // sgIdJugador = idJugador;
            //axWindowsMediaPlayer1.URL = video;

          //  obtieneInformacion();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void lblocal_Click(object sender, EventArgs e)
        {

        }

        //        public void obtieneInformacion() {

        //          DataSet datos = (new NegocioApliacion()).obtieneDatosJugador(sgIdJugador);

        //        for (int i = 0; i < datos.Tables[0].Rows.Count; i++)
        //    {
        //Se establece los valores de las etiquetas
        //Depende de que posición ocupen en el query, por ejemplo:
        //Para el query que está en el método obtieneDatosJugador
        //SELECT j.id_equipo, j.nombres & ' ' & j.apellido_paterno & ' ' &  j.apellido_materno as nombre, j.id_nacionalidad, j.id_posicion, j.foto, e.nombre as equipo, n.nacionalidad, jp.Posición
        // j.id_equipo => 0
        // j.nombres & ' ' & j.apellido_paterno & ' ' &  j.apellido_materno as nombre => 1
        // j.id_nacionalidad => 2
        // j.id_posicion => 3
        // j.foto => 4
        // e.nombre as equipo => 5
        // n.nacionalidad => 6
        // jp.Posición => 7
        //          lblNumero.Text = ((int)datos.Tables[0].Rows[i].ItemArray[0]).ToString();
        //          lblNombreJugador.Text = (string)datos.Tables[0].Rows[i].ItemArray[1];
        //          lblPosicion.Text = (string)datos.Tables[0].Rows[i].ItemArray[7];
        //          lblNacionalidad.Text = (string)datos.Tables[0].Rows[i].ItemArray[6];
        //          pbJugador.ImageLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, NegocioApliacion.FOTO_PATH + (string)datos.Tables[0].Rows[i].ItemArray[4]);
        //Para el caso de la foto utilicé la propiedad de la aplicación AppDomain.CurrentDomain.BaseDirectory para establecer la ruta de la imagen
        //Cuando corres la aplicación desde visual studio (en el modo debug, por ejemplo) AppDomain.CurrentDomain.BaseDirectory tiene un valor de C:\...\bin\debug
        //Y con la función Path.Combine le estoy concatenando la carpeta de las Fotos NegocioApliacion.FOTO_PATH y el nombre de la foto que viene de la base de datos

        //  }

        //}
    }
}
