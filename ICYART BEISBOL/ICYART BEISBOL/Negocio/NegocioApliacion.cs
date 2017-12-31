using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ICYART_BEISBOL.Datos;
using ICYART_BEISBOL.Entidad;

namespace ICYART_BEISBOL.Negocio
{
    class NegocioApliacion
    {
        //Aqui definimos una variable estatica para la ruta de las fotos
        public static string FOTO_PATH = "Fotos\\";

        //Constructor de la clase NegocioAplicacion
        public NegocioApliacion()
        {
            //En este caso no haremos nada en el constructor de la clase, pero aqui se puede realizar alguna tarea cada vez que se 
            //hace una instancia de la clase.
        }

        public DataSet obtieneDatosJugador(string idJugador)
        { 
            try
            {
                //Desde aqui se hace referencia a la clase de datos
                DatosAplicacion datos = new DatosAplicacion();

                //Y aqui mandamos a llamar el método que obtiene la información
                return datos.obtieneDatosJugador(idJugador);
            }
            catch (Exception)
            {
                return null;
            }

        }

        public List<EntidadGenericaNombreId> obtieneListaJugadores()
        {
            try
            {
                //Esta es otra forma de mandar a llamar un método de la clase DatosAplicacion
                //Aqui en la misma línea y para no hacer una variable datos se hace la instancia de la clase DatosAplicacion 
                //y se manda a llamar el método que obtiene la información
                return (new DatosAplicacion()).obtieneListaJugadores();
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
