using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            using (login ventanaLogin = new login(linkLabelPerfil))
            {
                
                    // Suscribirse al evento FormClosed
                    ventanaLogin.FormClosed += VentanaLogin_FormClosed;

                    // Mostrar el formulario de inicio de sesión
                    ventanaLogin.ShowDialog();
                

                
            }

        }

        private void VentanaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Este método se ejecutará cuando el formulario de inicio de sesión se cierre
            // Obtener el nombre de usuario del formulario de inicio de sesión
            string nombreUsuario = ((login)sender).NombreUsuario;

            if (nombreUsuario!=null)
            {
                // Actualizar el texto del LinkLabel en el formulario principal con el nombre de usuario
                linkLabelPerfil.Text = nombreUsuario;
            }
            else
            {
                //En caso de salir de los formularios, se deja el link label con el nombre predertermiando
                linkLabelPerfil.Text = "Perfil";
            }




            //Habilita los botones para la gestion de la base de datos
            linkLabelAdminSucursales.Enabled = true;
            linkLabelAdminPaises.Enabled = true;
            linkLabelAdminDepartamento.Enabled = true;
            linkLabelAdminMunicipio.Enabled = true;
            linkLabelPersonas.Enabled = true;
            linkLabelAdminContratos.Enabled = true;
            tabControlVistaTuplas.Enabled = true;
        }
    }
}
