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

        #region SeguridadContraseña
        public enum NivelSeguridad
        {
            Invalida = 0,
            Baja,
            Media,
            Alta
        }
        public NivelSeguridad ObtenerNivelSeguridad(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
                return NivelSeguridad.Invalida;

            int score = 0;

            if (Regex.IsMatch(password, "[a-z]")) score++;
            if (Regex.IsMatch(password, "[A-Z]")) score++;
            if (Regex.IsMatch(password, "[0-9]")) score++;
            if (Regex.IsMatch(password, "[^a-zA-Z0-9]")) score++;

            switch (score)
            {
                case 1:
                case 2:
                    return NivelSeguridad.Baja;
                case 3:
                    return NivelSeguridad.Media;
                case 4:
                    return NivelSeguridad.Alta;
                default:
                    return NivelSeguridad.Invalida;
            }
        }

        #endregion

        private void BTNGuardarPassword_Click(object sender, EventArgs e)
        {
        }

        private void TXTPassword_TextChanged(object sender, EventArgs e)
        {
            string password = TXTPassword.Text;

            string longitud = password.Length >= 8 ? "✔ Mínimo 8 caracteres" : "✖ Mínimo 8 caracteres";
            string minusculas = Regex.IsMatch(password, "[a-z]") ? "✔ Contiene minúsculas" : "✖ Contiene minúsculas";
            string mayusculas = Regex.IsMatch(password, "[A-Z]") ? "✔ Contiene mayúsculas" : "✖ Contiene mayúsculas";
            string numeros = Regex.IsMatch(password, "[0-9]") ? "✔ Contiene números" : "✖ Contiene números";
            string especiales = Regex.IsMatch(password, "[^a-zA-Z0-9]") ? "✔ Contiene caracteres especiales" : "✖ Contiene caracteres especiales";

            LBPasswordCondicion.Text =
                $"{longitud}\n" +
                $"{minusculas}\n" +
                $"{mayusculas}\n" +
                $"{numeros}\n" +
                $"{especiales}";
        }

        private void FRMModificar_Password_Load(object sender, EventArgs e)
        {
            TXTPassword.UseSystemPasswordChar=true;
        }
    }
}
