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

                //Permite abrir otro formulario bloqueando el anterior
                //No lo desbloquea hasta que termines el formulario que esta encima
                ventanaLogin.ShowDialog();



        }
    }
}
