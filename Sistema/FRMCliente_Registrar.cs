using Accord;
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
    public partial class FRMCliente_Registrar : DevComponents.DotNetBar.OfficeForm
    {
        #region Variables
        private aperson persona = new aperson();
        private aclient cliente = new aclient();
        private xnumcor correlativo = new xnumcor();
        public bool modificar = false;
        public String codCliMod = "";
        public bool actualizar = false;
        public bool personaok = false;
        #endregion

        #region Constructor

        public FRMCliente_Registrar()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRMCliente_Registrar_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FRMCliente_Registrar_Load(object sender, EventArgs e)
        {

            if (this.modificar)
            {
                JalarDatos();
                BTNGuardar.Text = "&Modificar";
                this.Text = "Modificar Cliente";
                //GBDatos.Text = "Modificar Usuario";
                TXTRazon.Focus();
            }
            else
            {
                LimpiarCasillas();
                BTNGuardar.Text = "&Guardar";
                this.Text = "Registrar Cliente";
                //GBDatos.Text = "Registrar Persona";
                TXTNitCi.Focus();
            }
        }

        private void TXTNitCi_KeyDown(object sender, KeyEventArgs e)
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

        private void TXTRazon_KeyDown(object sender, KeyEventArgs e)
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

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            FRMPersona_Buscar a = new FRMPersona_Buscar();
            a.ShowDialog();
            if (a.seleccionadorOK)
            {
                this.persona = a.persona;
                this.personaok = true;

                SWBUsar.Visible = true;
                SWBUsar.Value = true; // por defecto asumimos "usar datos de la persona"

                TXTNitCi.Text = persona.capsnumcid;
                TXTRazon.Text = persona.capsapepat + " " +
                           persona.capsapemat + " " +
                           persona.capsnomper;
                TXTRazon.Enabled = false;
                TXTNitCi.Enabled = false;
            }
            else
            {
                this.personaok = false;

                SWBUsar.Value = false;
                SWBUsar.Visible = false;

                TXTNitCi.Text = "";
                TXTRazon.Text = "";
                TXTRazon.Enabled = true;
                TXTNitCi.Enabled = true;
            }
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            if (VerificarIntegridad())
            {


                if (!this.modificar)
                {
                    //Generar el correlativo
                    correlativo.pxnctipcor = "aclient";
                    if (correlativo.ObtenerSiguiente())
                    {
                        cliente.pacecodcli = correlativo.pxnctipcor + "-" +
                                             correlativo.cxncnumcor.ToString("D12");
                    }
                }
                else
                {
                    cliente.pacecodcli = this.codCliMod;
                }
                cliente.caceestcli = SWBEstado.Value;
                cliente.cacerazsoc = TXTRazon.Text;
                cliente.cacenuidtr = int.Parse(TXTNitCi.Text);
                cliente.cacetelefo = TXTTelefono.Text;
                cliente.cacedirecc = TXTDireccion.Text;
                cliente.facecodper = persona.papscodper;
                cliente.cacetipcli = SWBUsar.Value;




                if (!this.modificar)
                {
                    if (cliente.Grabar())
                    {
                        MessageBox.Show("Cliente guardado correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMCliente_Registrar_FormClosing;

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no se pudo guardar!!",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (cliente.Modificar())
                    {
                        MessageBox.Show("Cliente modificado correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMCliente_Registrar_FormClosing;

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cliente no se pudo modificar!!",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                    }
                }
            }
        }
        #endregion

        #region Metodos
        private bool VerificarIntegridad()

        {
            aclient cliente2 = new aclient();
            cliente2.cacenuidtr = int.Parse(TXTNitCi.Text);
            bool respuesta = true;

            if (TXTRazon.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca la Razón Social del Cliente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTRazon.Focus();
                respuesta = false;
            }
            else if (TXTNitCi.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el NIT/Cédula del Cliente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTNitCi.Focus();
                respuesta = false;
            }
            else if (!int.TryParse(TXTNitCi.Text, out _))
            {
                MessageBox.Show("El NIT/Cédula debe contener solo números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTNitCi.Focus();
                respuesta = false;
            }
            else if (!this.personaok)
            {
                MessageBox.Show("Debe buscar y seleccionar una persona antes de guardar el cliente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                respuesta = false;
            }

            else if (cliente2.ObtenerDatosCliente(modificar, cliente.cacenuidtr.ToString()))
            {
                MessageBox.Show("Ya existe ese NIT/Cédula Registrado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTNitCi.Focus();
                respuesta = false;
            }

            return respuesta;
        }
        private void LimpiarCasillas()
        {
            SWBEstado.Value = true;
            SWBUsar.Value = false;
            SWBUsar.Value=false;
            TXTRazon.Text = "";
            TXTNitCi.Text = "";
            TXTTelefono.Text = "";
            TXTDireccion.Text = "";
            
        }
        private void JalarDatos()
        {
            cliente.pacecodcli = this.codCliMod;
            cliente.ObtenerDatos();
            persona.papscodper = cliente.facecodper;
            persona.ObtenerDatos();
            this.personaok = true;

            SWBUsar.Visible = true;
            SWBUsar.Value = cliente.cacetipcli;

            TXTRazon.Enabled = !cliente.cacetipcli;
            TXTNitCi.Enabled = !cliente.cacetipcli;

            SWBEstado.Value = cliente.caceestcli;
            TXTRazon.Text = cliente.cacerazsoc;
            TXTNitCi.Text = cliente.cacenuidtr.ToString();
            TXTTelefono.Text = cliente.cacetelefo;
            TXTDireccion.Text = cliente.cacedirecc;
        }

        #endregion

        private void SWBUsar_ValueChanged(object sender, EventArgs e)
        {

            if (SWBUsar.Value)
            {
                // Modo "persona": usamos automáticamente los datos de la persona seleccionada
                if (this.personaok)
                {
                    TXTNitCi.Text = persona.capsnumcid;
                    TXTRazon.Text = persona.capsapepat + " " +
                               persona.capsapemat + " " +
                               persona.capsnomper;
                }
                TXTRazon.Enabled = false;
                TXTNitCi.Enabled = false;
            }
            else
            {
                // Modo "empresa": datos manuales
                TXTRazon.Text = "";
                TXTNitCi.Text = "";
                TXTRazon.Enabled = true;
                TXTNitCi.Enabled = true;
                TXTRazon.Focus();
            }
        }
    }
}
