using CapaRN;
using DevComponents.DotNetBar.Controls;
using Sistema.Properties;
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
    public partial class FRMUsuario_Registrar : Form
    {
        #region Variables
        private ausuari usuario = new ausuari();
        private xnumcor correlativo = new xnumcor();
        public bool modificar = false;
        public String codUsuMod = "";
        public bool actualizar = false;



        #endregion
        #region Constructor
        public FRMUsuario_Registrar()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        

        
        private bool VerificarIntegridad()
        {
            bool respuesta = true;

            

            if (TXTNombreLogin.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el Login del Usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCi.Focus();
                respuesta = false;
            }

           

            return respuesta;
        }

        private void LimpiarCasillas()
        {
            SWBEstado.Value = true;
            TXTCi.Text = "";
            TXTNombres.Text = "Nombre Completo";
            TXTNombreLogin.Text = "";
            TXTNombreLogin.Focus();

        }

        private void JalarDatos()
        {
            usuario.pauacodusu = this.codUsuMod;
            usuario.ObtenerDatos();
            SWBEstado.Value = usuario.cauaestusu;
            TXTCi.Text = "";

            TXTNombres.Text = "";
            TXTNombreLogin.Text = usuario.cauanomlog;
        }






        #endregion

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRMUsuario_Registrar_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("¿Está seguro que desea cerrar el formulario?",
                               "Pregunta",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
           
        }

        private void TXTCi_Enter(object sender, EventArgs e)
        {
            TextBoxX a = (TextBoxX)sender;
            a.SelectAll();
        }

        private void FRMUsuario_Registrar_Load(object sender, EventArgs e)
        {
            



            if (this.modificar)
            {
                JalarDatos();
                BTNGuardar.Text = "&Modificar";
                this.Text = "Modificar Usuario";
                //GBDatos.Text = "Modificar Usuario";
                TXTCi.Focus();
            }
            else
            {
                LimpiarCasillas();
                BTNGuardar.Text = "&Guardar";
                this.Text = "Registrar Usuario";
                //GBDatos.Text = "Registrar Persona";
                TXTCi.Focus();
            }
        }

        private void TXTCi_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false;
            //Identificar si es una tecla válida
            if ((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9))
                teclaValida = true;
            else if ((e.KeyCode >= Keys.D0) && (e.KeyCode <= Keys.D9) && !e.Shift)
                teclaValida = true;
            else if ((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z) && (!e.Alt))
                teclaValida = true;
            else if ((e.KeyCode == Keys.Subtract) ||
                (e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Delete) ||
                (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Right) ||
                ((e.KeyCode == Keys.OemMinus) && !e.Shift))
                teclaValida = true;

            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }
        }

        //FALTA AGREGAR GROUP PANEL GENERAL

        private void TXTNombres_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false;
            //Identificar si es una tecla válida            
            if ((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z) && (!e.Alt))
                teclaValida = true;
            else if (
                (e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Delete) ||
                (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Right) ||
                (e.KeyCode == Keys.Space) ||
                ((e.KeyCode == Keys.Oem4) && !e.Shift))
                teclaValida = true;

            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void TXTNombreLogin_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false;
            if ((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z))
                teclaValida = true;
            else if ((e.KeyCode >= Keys.D0) && (e.KeyCode <= Keys.D9) && !e.Shift)
                teclaValida = true;
            else if ((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9))
                teclaValida = true;
            else if (e.KeyCode == Keys.Back ||
                     e.KeyCode == Keys.Delete ||
                     e.KeyCode == Keys.Left ||
                     e.KeyCode == Keys.Right)
                teclaValida = true;
            else if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal)
                teclaValida = true;
            else if (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract)
                teclaValida = true;
            else if (e.Shift && e.KeyCode == Keys.OemMinus)
                teclaValida = true;
            else if (e.Control && e.Alt && e.KeyCode == Keys.Q)
                teclaValida = true;
            else if (e.Shift && e.KeyCode == Keys.D2)
                teclaValida = true;
            else if ((!e.Shift && e.KeyCode == Keys.Oemplus) ||
                     e.KeyCode == Keys.Add)
                teclaValida = true;
            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
