using Google.Protobuf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_db
{
    /**
     * Clase que hace la conexión con la base de datos
     */
    internal class ConexionMysql : Conexion
    {
        //Usa las herrmainetas necesarias para conexión mysql
        private MySqlConnection connection;

        //Cadena para ahacer la respectiva conexión a la db
        private String cadenaConexion;



        //Metodo constructor de la clase
        public ConexionMysql() {
            cadenaConexion = "Database=" + database +
                "; DataSource=" + server +
                "; User Id=" + user +
                ";Password=" + password;

            connection = new MySqlConnection(cadenaConexion);

            Console.WriteLine("Base de datos conectada exitosamente");
        }

        /**
         * Metodo el cual me obtiene la conexión para hacer las respectivas consultas o ser usada
         * la base de datos
         */
        public MySqlConnection GetConnection()
        {

            try
            {
                //Verifica que el estado de la conexión no sea igual a Open(abierta)
                if (connection.State != System.Data.ConnectionState.Open) {

                    //Intenta abrir la conexión con el metodo open
                    connection.Open();
                }

            }
            catch (Exception e)
            {

                //Muestra el emensaje con el error
                MessageBox.Show(e.ToString());
            }

            //Retorna la conexión
            return connection;

        }
    }
}
