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

            if (TXTPassword.PasswordChar == '*')
            {
                TXTPassword.PasswordChar = '\0';
            }
            else
            {
                TXTPassword.PasswordChar = '*';
            }
        }

        private void BTNVerConfirmarPassword_Click(object sender, EventArgs e)
        {

            if (TXTConfirmarPassword.PasswordChar == '*')
            {
                TXTConfirmarPassword.PasswordChar = '\0';
            }
            else
            {
                TXTConfirmarPassword.PasswordChar = '*';
            }
        }
        #endregion

        #region SeguridadContraseña
        public int ObtenerNivelSeguridad(string password)
        {
            int score = 0;
            if (string.IsNullOrEmpty(password)) return 0;
            if (password.Length >= 8) score++;
            if (System.Text.RegularExpressions.Regex.IsMatch(password, "[a-z]")) score++;
            if (System.Text.RegularExpressions.Regex.IsMatch(password, "[A-Z]")) score++;
            if (System.Text.RegularExpressions.Regex.IsMatch(password, "[0-9]")) score++;
            if (System.Text.RegularExpressions.Regex.IsMatch(password, "[^a-zA-Z0-9]")) score++;
            return score; 
        }

        #endregion

        private void BTNGuardarPassword_Click(object sender, EventArgs e)
        {
            int numero = ObtenerNivelSeguridad(TXTPassword.Text);
            if (numero==0)
            {
                MessageBox.Show("0", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (numero == 1)
            {
                MessageBox.Show("1", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (numero == 2)
            {
                MessageBox.Show("2", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (numero == 3)
            {
                MessageBox.Show("3", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (numero == 4)
            {
                MessageBox.Show("4", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (numero == 5)
            {
                MessageBox.Show("5", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
