using CapaRN;
using DevComponents.DotNetBar.Controls;
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
    public partial class FRM_Persona_Registrar : DevComponents.DotNetBar.OfficeForm
    {
        #region Variables
        private aperson persona = new aperson();
        private xnumcor correlativo = new xnumcor();
        public bool modificar = false;
        public String codPerMod = "";
        public bool actualizar = false;
        #endregion

        #region constructor
        public FRM_Persona_Registrar()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos

        private bool VerificarIntegridad()
        {
            bool respuesta = true;

            persona.capsdni = TXTCi.Text;

            if (TXTCi.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el CI de la persona", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCi.Focus();
                respuesta = false;
            }
            
            return respuesta;
        }

        private void LimpiarCasillas()
        {
            SWBEstado.Value = true;
            TXTCi.Text = "";
            
        }

        private void JalarDatos()
        {
            persona.fapscodper = this.codPerMod;
            persona.ObtenerDatos();
            SWBEstado.Value = persona.capsestper;
            TXTCi.Text = persona.capsdni;
           
        }


        #endregion

        #region Eventos



        #endregion

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FRM_Persona_Registrar_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FRM_Persona_Registrar_Load(object sender, EventArgs e)
        {
            if (this.modificar)
            {
                JalarDatos();
                BTNGuardar.Text = "&Modificar";
                this.Text = "Modificar Persona";
                GBDatos.Text = "Modificar Persona";
                TXTCi.Focus();
            }
            else
            {
                LimpiarCasillas();
                BTNGuardar.Text = "&Guardar";
                this.Text = "Registrar Persona";
                GBDatos.Text = "Registrar Persona";
                TXTCi.Focus();
            }
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            if (VerificarIntegridad())
            {
                persona = new aperson();

                if (!this.modificar)
                {
                    //Generar el correlativo
                    correlativo.pxnctipcor = "aperson";
                    if (correlativo.ObtenerSiguiente())
                    {
                        persona.fapscodper = correlativo.cxncnumcor.ToString();
                    }
                }
                else
                {
                    persona.fapscodper = this.codPerMod;
                }
                persona.capsdni = TXTCi.Text;
                persona.capsapepat = TXTApPa.Text;
                persona.capsapemat = TXTApMa.Text;
                persona.capsnombre = TXTNombre.Text;
                persona.capsnumcel = TXTCelular.Text;
                persona.capcorreo = TXTCorreo.Text;
                persona.capsdirecc = TXTDireccion.Text;
                persona.capsestper = SWBEstado.Value;

                if (!this.modificar)
                {
                    if (persona.Grabar())
                    {
                        MessageBox.Show("Persona guardada correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRM_Persona_Registrar_FormClosing;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Persona no se pudo guardar!!",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (persona.Modificar())
                    {
                        MessageBox.Show("Persona modificada correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRM_Persona_Registrar_FormClosing;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Persona no se pudo modificar!!",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                    }
                }
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

        private void TXTApPa_KeyDown(object sender, KeyEventArgs e)
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

        private void TXTCelular_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false;
            if ((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9))
                teclaValida = true;
            else if (
                (e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Delete) ||
                (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Right))
                teclaValida = true;

            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void TXTApMa_KeyDown(object sender, KeyEventArgs e)
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

        private void TXTNombre_KeyDown(object sender, KeyEventArgs e)
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

        private void TXTCorreo_KeyDown(object sender, KeyEventArgs e)
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
            else if ((e.Shift && e.KeyCode == Keys.Oemplus) ||
                     e.KeyCode == Keys.Add)
                teclaValida = true;
            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
