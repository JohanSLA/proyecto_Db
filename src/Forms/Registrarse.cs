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

namespace proyecto_db
{
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * Funcion que se ejecuta cuando damos click en el boton registar
         * Registra un nuevo email
         */
        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            bool verificacionCajasTexto=verificarCajasTexto();


            if (verificacionCajasTexto == true)
            {
                // Obtener la fecha actual desde C#
                DateTime fechaActual = DateTime.Now;

                // Convertir la fecha a formato MySQL DATE (yyyy-MM-dd)
                string fechaMySQL = fechaActual.ToString("yyyy-MM-dd");

                registrarUsuario(textBoxId.Text,textBoxContrasena.Text,textBoxEmail.Text,fechaMySQL);
            }
            else
            {
                Console.WriteLine("estan vacias");
            }

        }

        /**
         * Metodo que me registra un usuario
         */
        private void registrarUsuario(string id, string clave, string login, String fechaMySql)
        {
            Console.WriteLine("entro al registro");

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
                    string query = "INSERT INTO usuario (id, login, clave, fechaCreacion, nivel) VALUES (@id, @login, @clave, @fechaCreacion, @nivel)";

                    // Crear un comando para ejecutar la consulta SQL
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@clave", clave);
                        cmd.Parameters.AddWithValue("@fechaCreacion", fechaMySql);
                        cmd.Parameters.AddWithValue("@nivel", "bajo");

                        try
                        {

                            int count = Convert.ToInt32(cmd.ExecuteScalar());
                            //Imprime mensaje de que se registro con exito
                            Console.WriteLine("Bank: Se registro el usuario con el id: "+textBoxId.Text);
                            MessageBox.Show("Registro exitoso" + " Bienvenido a bank " + textBoxId.Text, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            // Manejo de excepciones
                            Console.WriteLine("Ocurrió un error: " + ex.Message);
                            MessageBox.Show("Ha ocurrido un error en el registro, intenatlo nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                            //Borra los datos de los campos de texto
                            textBoxContrasena.Text = "";
                            textBoxEmail.Text = "";
                            textBoxId.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al intenatar registrarse: " + ex.Message);
            }

        }

        /**
         * Metodo mediante el cual se verifica si el campo de email y contraseña estan llenos
         * para posteriormente iniciar con la consulta
         */
        private bool verificarCajasTexto()
        {
            Console.WriteLine("entro a verificacion de cajas de texto");

            //Verifica que los dos string de las cajas no sean un string vacio
            if (textBoxId.Text == string.Empty && textBoxContrasena.Text == string.Empty && textBoxEmail.Text == string.Empty)
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
