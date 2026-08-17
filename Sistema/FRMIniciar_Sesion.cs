using CapaRN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class FRMIniciar_Sesion : DevComponents.DotNetBar.OfficeForm
    {
        #region varialbes
        public ausuari usuario = new ausuari();
        public aperson persona = new aperson();
        public bool loginExitoso = false;
        public bool actualizarPassword = false;
        #endregion



        #region Constructor

        public FRMIniciar_Sesion()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos

        private void BTNVerPassword_Click(object sender, EventArgs e)
        {
            TXTPassword.UseSystemPasswordChar = !TXTPassword.UseSystemPasswordChar;
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Metodos
        private bool VerificarIntegridad()
        {
            bool respuesta = true;



            if (TXTNombreUsuario.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el Login del Usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTNombreUsuario.Focus();
                respuesta = false;
            }

            else if (TXTPassword.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el Password del usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTPassword.Focus();
                respuesta = false;
            }


            return respuesta;
        }
        #endregion

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            if (VerificarIntegridad())
            {
                usuario.cauanomlog = TXTNombreUsuario.Text;
                usuario.ObtenerDatosLogin(false, usuario.cauanomlog);
                persona.papscodper = usuario.fauacodper;
                persona.ObtenerDatos();
                if (usuario.cauaactcla)
                {

                    if (TXTPassword.Text == persona.capsnumcid)
                    {

                        MessageBox.Show("Bienvenido " + persona.capsnomper, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loginExitoso = true;
                        actualizarPassword = true;
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show(
               "El usuario o la contraseña son incorrectos.",
               "Error de inicio de sesión",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error
                       );
                    }

                }
                else
                {
                    if (TXTPassword.Text == usuario.cauaclausu)
                    {

                        MessageBox.Show("Bienvenido " + persona.capsnomper, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loginExitoso = true;
                        actualizarPassword = false;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
               "El usuario o la contraseña son incorrectos.",
               "Error de inicio de sesión",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error
               );
                    }
                }
            }
        }

        private void FRMIniciar_Sesion_Load(object sender, EventArgs e)
        {
            TXTPassword.UseSystemPasswordChar = true;
        }
    }
}
