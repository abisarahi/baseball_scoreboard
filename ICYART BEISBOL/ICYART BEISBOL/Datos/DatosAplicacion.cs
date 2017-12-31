using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.OleDb;
using ICYART_BEISBOL.Entidad;
using System.Collections.Generic;

namespace ICYART_BEISBOL.Datos
{
    class DatosAplicacion
    {
        //Aqui declaramos las variables globales
        //Con esta variable obtenemos la cadena de conexión a la base de datos definida en el archivo de configuración App.config
        string sCadenaConexion = ConfigurationManager.ConnectionStrings["cadenaConexion"].ToString();

        //Constructor de la clase DatosAplicacion
        public DatosAplicacion()
        {
            //En este caso no haremos nada en el constructor de la clase, pero aqui se puede realizar alguna tarea cada vez que se 
            //hace una instancia de la clase.
        }

        public DataSet obtieneDatosJugador(string idJugador) {

            //En esta variable regresaremos los datos del jugador seleccionado
            DataSet resultado = new DataSet();
            //En esta variable crearemos el query para obtener los datos del jugador
            string sQuery = @"SELECT j.id_equipo, j.nombres & ' ' & j.apellido_paterno & ' ' &  j.apellido_materno as nombre, j.id_nacionalidad, j.id_posicion, j.foto, e.nombre as equipo, n.nacionalidad, jp.Posición
                                FROM ((Jugador j
                                INNER JOIN Equipo e ON j.id_equipo=e.id_equipo)
                                INNER JOIN Nacionalidad n ON j.id_nacionalidad = n.id_nacionalidad)
                                INNER JOIN Posiciones_jugador jp ON j.Id_posicion = jp.id_posicion
                                WHERE j.id_jugador=@idJugador;";
            //El @ del inicio de la cadena quiere decir que la cadena que está dentro de las comillas dobles respetara saltos de linea, tabuladores etc
            //El @ que esta ein idJugador quiere decir que es un parámetro al query

            //Con este bloque creamos la conexión a la base de datos que se cerrará una vez que termine el bloque 'using'
            using (OleDbConnection con = new OleDbConnection(sCadenaConexion))
            {
                try
                {
                    //Abrimos la conexión
                    con.Open();

                    //Con esta variable llenaremos el data set que retornaremos con la información
                    OleDbDataAdapter adapter = new OleDbDataAdapter(sQuery, con);
                    //Aqui añadimos el parámetro y su valor para que traiga los datos del jugador
                    adapter.SelectCommand.Parameters.Add("@idJugador", OleDbType.Integer).Value = int.Parse(idJugador);
                    adapter.Fill(resultado);
                    //Una vez que se llena el dataset se cierra el adaptador
                    adapter.Dispose();

                }
                catch (Exception ex)
                {
                    //Si algo falla, se manda una excepción
                    throw new Exception("Error al obtener la información del jugador de la base de datos", ex);
                }
            }

            return resultado;
            
        }

        public List<EntidadGenericaNombreId> obtieneListaJugadores()
        {
            //Usamos la Entidad genérica para la lista de jugadores, la entidad Genérica tiene como propiedades Id y NombreId
            List<EntidadGenericaNombreId> lista = new List<EntidadGenericaNombreId>();
            //Query para obtener la lista de jugadores
            string queryString = @"SELECT j.id_jugador, j.nombres & ' ' & j.apellido_paterno & ' ' &  j.apellido_materno as nombres FROM Jugador j";

            using (OleDbConnection con = new OleDbConnection(sCadenaConexion))
            {
                con.Open();
                //Para este caso como los datos los vamos a llenar en la lista de EntidadGenericaNombreId utilizamos in OleDbCommand para obtener los datos
                OleDbCommand command = new OleDbCommand(queryString, con);

                try
                {
                    //Con esta variable vamos a recorrer los datos que obtenemos de la base de datos
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        //Para cada registro que obtenemos de la base de datos a la lista le añadimos un elemento, definiendo sus propiedades Id y NombreId
                        lista.Add(
                                new EntidadGenericaNombreId()
                                {
                                    Id = ((int)reader["id_jugador"]).ToString(),
                                    NombreId = (string)reader["nombres"]
                                });
                    }
                    //Se cierra el data reader para liberar memoria
                    reader.Close();
                }
                catch (Exception ex)
                {
                    //Si algo sale mal se envía un error controlado
                    throw new Exception("Error al obtener la lista de jugadores en la BD", ex);
                }
            }

            return lista;

        }

    }
}
