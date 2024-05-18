using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_db
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void tabControlVistaTuplas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /**
         * Metodo que carga la pagina principal
         */
        private void inicio_Load(object sender, EventArgs e)
        {
            //Deshabilita los links hasta que no se haga login
            linkLabelAdminSucursales.Enabled = false;
            linkLabelAdminPaises.Enabled = false;
            linkLabelAdminDepartamento.Enabled = false;
            linkLabelAdminMunicipio.Enabled = false;
            linkLabelPersonas.Enabled = false;
            linkLabelAdminContratos.Enabled = false;
            tabControlVistaTuplas.Enabled = false;
        }

        /**
         * Evento el cual se ejecuta cuando damos click sobre el link perfil del inicio
         * Abre el formulario del login 
         */
        private void linkLabelPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {
                //Crea la conexion a la db
                ConexionMysql conection = new ConexionMysql();

                // Obtener la conexión a la base de datos
                MySqlConnection con = conection.GetConnection();




                // Definir la consulta SQL para la inserción
                string sqlInsert = "INSERT INTO usuarios (id, nombre, email, contrasena) VALUES (@id, @nombre, @email, @contrasena)";

                // Crear un comando para ejecutar la consulta SQL
                MySqlCommand cmd = new MySqlCommand(sqlInsert, con);

                // Asignar valores a los parámetros de la consulta
                cmd.Parameters.AddWithValue("@id", 1);
                cmd.Parameters.AddWithValue("@nombre", "nombre_de_prueba");
                cmd.Parameters.AddWithValue("@email", "correo_de_prueba@example.com");
                cmd.Parameters.AddWithValue("@contrasena", "contraseña_de_prueba");

                // Ejecutar la consulta de inserción
                int rowsAffected = cmd.ExecuteNonQuery();

                Console.WriteLine("Regristo agregado con exito a la base de datos");

            }
            catch {
                Console.WriteLine("Ocurrio un error al ingresar el registro a la base de datos" + e);
            }
           


            //Voy acaaaaaa----------------------------------



        }
    }
}
