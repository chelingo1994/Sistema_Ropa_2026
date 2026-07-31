using CapaRN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class FRMModificar_Password : DevComponents.DotNetBar.OfficeForm
    {

        #region varialbes
        public ausuari usuario = new ausuari();
        public aperson persona = new aperson();
        public bool loginExitoso = false;
        #endregion

        #region Constructor
        public FRMModificar_Password()
        {
            InitializeComponent();
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

        // Evalúa la contraseña y actualiza el label con las condiciones + nivel de seguridad
        private int EvaluarSeguridadPassword(string password)
        {
            bool tieneLongitud = password.Length >= 8;
            bool tieneMinusculas = Regex.IsMatch(password, "[a-z]");
            bool tieneMayusculas = Regex.IsMatch(password, "[A-Z]");
            bool tieneNumeros = Regex.IsMatch(password, "[0-9]");
            bool tieneEspeciales = Regex.IsMatch(password, "[^a-zA-Z0-9]");

            string longitud = tieneLongitud ? "✔ Mínimo 8 caracteres" : "✖ Mínimo 8 caracteres";
            string minusculas = tieneMinusculas ? "✔ Contiene minúsculas" : "✖ Contiene minúsculas";
            string mayusculas = tieneMayusculas ? "✔ Contiene mayúsculas" : "✖ Contiene mayúsculas";
            string numeros = tieneNumeros ? "✔ Contiene números" : "✖ Contiene números";
            string especiales = tieneEspeciales ? "✔ Contiene caracteres especiales" : "✖ Contiene caracteres especiales";

            // Nivel de seguridad: cuenta cuántas condiciones se cumplen (0 a 5)
            int nivel = new[] { tieneLongitud, tieneMinusculas, tieneMayusculas, tieneNumeros, tieneEspeciales }
                        .Count(c => c);

            string nivelTexto;
            switch (nivel)
            {
                case 0:
                case 1:
                case 2:
                    nivelTexto = "Seguridad: Débil";
                    break;
                case 3:
                case 4:
                    nivelTexto = "Seguridad: Media";
                    break;
                case 5:
                    nivelTexto = "Seguridad: Fuerte";
                    break;
                default:
                    nivelTexto = "";
                    break;
            }

            LBPasswordCondicion.Text =
                $"{longitud}\n" +
                $"{minusculas}\n" +
                $"{mayusculas}\n" +
                $"{numeros}\n" +
                $"{especiales}\n" +
                $"{nivelTexto}";

            return nivel;
        }
        #endregion



        #region Eventos
        private void BTNVerPassword_Click(object sender, EventArgs e)
        {

            TXTPassword.UseSystemPasswordChar=!TXTPassword.UseSystemPasswordChar;
        }

        private void BTNVerConfirmarPassword_Click(object sender, EventArgs e)
        {
            TXTConfirmarPassword.UseSystemPasswordChar = !TXTConfirmarPassword.UseSystemPasswordChar;
        }
        #endregion

        

        private void BTNGuardarPassword_Click(object sender, EventArgs e)
        {
            int nivel = EvaluarSeguridadPassword(TXTPassword.Text);

            if (TXTPassword.Text==TXTConfirmarPassword.Text)
            {
                if (nivel < 5) // exige que cumpla las 5 condiciones; cambia el umbral si prefieres permitir "Media"
                {
                    MessageBox.Show(
                        "La contraseña no cumple con todos los requisitos de seguridad.",
                        "Contraseña inválida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    
                }
                else
                {
                    usuario.cauaactcla=false;
                    usuario.cauaclausu=TXTPassword.Text;
                    if (usuario.Modificar())
                    {
                        MessageBox.Show(
                        "El Password modificado correctamente.",
                        "Contraseña inválida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                       "Error al modificar el Password.",
                       "Contraseña inválida",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                        
                    }
                }
            }
            else
            {

                MessageBox.Show(
                    "La contraseña no coinciden.",
                    "Contraseña inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                
            }




        }

        private void TXTPassword_TextChanged(object sender, EventArgs e)
        {
            EvaluarSeguridadPassword(TXTPassword.Text);
        }

        private void FRMModificar_Password_Load(object sender, EventArgs e)
        {
            TXTPassword.UseSystemPasswordChar=true;
            TXTNombreUsuario.Text = usuario.cauanomlog;
        }
    }
}
