using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace proyecto_db
{
    public partial class login : Form
    {
        public login(LinkLabel linkLabelPerfil)
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        /**
         * Metodo por el cual el usuario da click en el boton iniciar seccion del login
         * Busca en la base de datos un usuario con ese email y clave
         */
        private void buttonIniciarSecion_Click(object sender, EventArgs e)
        {
            Console.WriteLine("1");

            //Variable que controlara si el usuario lleno los campos de email y contraseña
            bool verificacionCajasTexto = false;

            verificacionCajasTexto = verificarCajasTexto();

            if (verificacionCajasTexto == true)
            {
                
                //LLama al metodo que verifica si hay un registro que contenga ese usuario(email) y esa contraseña
                bool verificacionLogin= verificarLogin(textBoxUsuario.Text, textBoxContrasena.Text);

                if (verificacionLogin == true)
                {
                    //Habilita los botones y cambia el link al nombre del usuario
                    Console.WriteLine("Logueo exitoso");
                }
                else
                {
                    //indica con un cuadro de dialogo sobre el error de acceso 
                    Console.WriteLine("Logueo erroneo");
                }
            }

        }

        /**
         * Metodo el cual verifica si hay un registro que tenga ese correo y esa contraseña
         */
        private bool verificarLogin(string login, string clave)
        {
            Console.WriteLine("entro a verificacion loguin");

            bool usuarioExiste = false;
            try
            {
                //Crea la conexion a la db
                ConexionMysql conection = new ConexionMysql();

                // Obtener la conexión a la base de datos
                MySqlConnection con = conection.GetConnection();


                Task.Delay(5000);  // Esperar 5 segundos de forma asíncrona

                // Definir la consulta SQL para la inserción
                string query = "SELECT COUNT(*) FROM usuario WHERE login = @login AND clave = @clave";

                // Crear un comando para ejecutar la consulta SQL
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@clave", clave);


                try
                {
                    int count = (int)cmd.ExecuteScalar();
                    usuarioExiste = (count > 0);
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }

                //Retorna si existe
                return usuarioExiste;

            }
            catch
            {
                Console.WriteLine("Ocurrio un error al loguearse");
            }







            throw new NotImplementedException();
        }

        /**
         * Metodo mediante el cual se verifica si el campo de email y contraseña estan llenos
         * para posteriormente iniciar con la consulta
         */
        private bool verificarCajasTexto()
        {
            Console.WriteLine("entro a verificacion de cajas de texto");

            //Verifica que los dos string de las cajas no sean un string vacio
            if (textBoxUsuario.Text == string.Empty && textBoxContrasena.Text == string.Empty)
            {
                Console.WriteLine("estan vacias las cajas de texto");
                return false;
                
            }
            else
            {
                return true;
            }

        }
    }
}
