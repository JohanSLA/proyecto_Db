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
        // Propiedad pública para almacenar el nombre de usuario
        public string nombreUsuario;

        // Propiedad para almacenar el nombre de usuario
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public login(LinkLabel linkLabelPerfil)
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        /**
         * Metodo por el cual el usuario da click en el boton iniciar seccion del login
         * Busca en la base de datos un usuario con ese email y clave
         */
        private void buttonIniciarSecion_Click(object sender, EventArgs e)
        {

            // Variable que controlará si el usuario llenó los campos de email y contraseña
            bool verificacionCajasTexto = verificarCajasTexto();

            if (verificacionCajasTexto == true)
            {
                // Llama al método que verifica si hay un registro que contenga ese usuario (email) y esa contraseña
                bool existe = verificarUsuario(textBoxUsuario.Text, textBoxContrasena.Text);

                if (existe == true)  // Aquí debes comparar el resultado de la invocación del método
                {
                    // Habilita los botones y cambia el link al nombre del usuario
                    Console.WriteLine("Bank: Logueo exitoso");
                    // Habilita los botones y cambia el link al nombre del usuario
                    MessageBox.Show("Logueo exitoso"+" Bienvenido "+textBoxUsuario.Text, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NombreUsuario = textBoxUsuario.Text;
                    this.Close();
                }
                else
                {
                    // Indica con un cuadro de diálogo sobre el error de acceso
                    Console.WriteLine("Bank: Logueo erroneo");
                    // Ejemplo de cómo mostrar un mensaje de error
                    MessageBox.Show("Ha ocurrido un error en el login, intenatlo nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        /**
         * Metodo el cual verifica si hay un registro que tenga ese correo y esa contraseña
         */
        private bool verificarUsuario(string login, string clave)
        {
            Console.WriteLine("entro a verificacion loguin");

            bool usuarioExiste = false;

            try
            {
                // Crea la conexion a la db
                ConexionMysql conection = new ConexionMysql();

                // Obtener la conexión a la base de datos
                using (MySqlConnection con = conection.GetConnection())
                {
                    // Esperar 5 segundos de forma sincrónica
                    System.Threading.Thread.Sleep(5000);

                    // Definir la consulta SQL para la inserción
                    string query = "SELECT COUNT(*) FROM usuario WHERE login = @login AND clave = @clave";

                    // Crear un comando para ejecutar la consulta SQL
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@clave", clave);

                        try
                        {
                            
                            int count = Convert.ToInt32(cmd.ExecuteScalar());
                            usuarioExiste = (count > 0);
                        }
                        catch (Exception ex)
                        {
                            // Manejo de excepciones
                            Console.WriteLine("Ocurrió un error: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al loguearse: " + ex.Message);
            }

            // Retorna si existe
            return usuarioExiste;
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

        /**
         * Metodo que se ejecuta si se da click en el link de registrarse de la pantalla de inicio
         */
        private void linkRegistrarse(object sender, LinkLabelLinkClickedEventArgs e)
        {

            using (Registrarse ventanaRegistrarse = new Registrarse())
            {
                //Permite abrir otro formulario bloqueando el anterior
                //No lo desbloquea hasta que termines el formulario que esta encima
                ventanaRegistrarse.ShowDialog();
            }
        }
    }
}
