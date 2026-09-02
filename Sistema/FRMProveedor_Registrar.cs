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
    public partial class FRMProveedor_Registrar : DevComponents.DotNetBar.OfficeForm
    {
        #region Variables
        private aperson persona = new aperson();
        private aprovee proveedor = new aprovee();
        private xnumcor correlativo = new xnumcor();
        public bool modificar = false;
        public String codProMod = "";
        public bool actualizar = false;
        public bool personaok = false;
        #endregion
        #region Constructor
        public FRMProveedor_Registrar()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRMProveedor_Registrar_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FRMProveedor_Registrar_Load(object sender, EventArgs e)
        {

            if (this.modificar)
            {
                JalarDatos();
                BTNGuardar.Text = "&Modificar";
                this.Text = "Modificar Proveedor";
                TXTRazon.Focus();
            }
            else
            {
                LimpiarCasillas();
                BTNGuardar.Text = "&Guardar";
                this.Text = "Registrar Proveedor";
                TXTNitCi.Focus();
            }
        }

        private void TXTNitCi_KeyDown(object sender, KeyEventArgs e)
        {

            bool teclaValida = false;
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
                SWBUsar.Value = true;

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

        private void SWBUsar_ValueChanged(object sender, EventArgs e)
        {

            if (SWBUsar.Value)
            {
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
                TXTRazon.Text = "";
                TXTNitCi.Text = "";
                TXTRazon.Enabled = true;
                TXTNitCi.Enabled = true;
                TXTRazon.Focus();
            }
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            if (VerificarIntegridad())
            {

                if (!this.modificar)
                {
                    correlativo.pxnctipcor = "aprovee";
                    if (correlativo.ObtenerSiguiente())
                    {
                        proveedor.papvcodpro = correlativo.pxnctipcor + "-" +
                                             correlativo.cxncnumcor.ToString("D12");
                    }
                }
                else
                {
                    proveedor.papvcodpro = this.codProMod;
                }
                proveedor.capvestpro = SWBEstado.Value;
                proveedor.capvrazsoc = TXTRazon.Text;
                proveedor.capvnuidtr = int.Parse(TXTNitCi.Text);
                proveedor.capvtelefo = TXTTelefono.Text;
                proveedor.capvdirecc = TXTDireccion.Text;
                proveedor.fapvcodper = persona.papscodper;
                proveedor.capvtippro = SWBUsar.Value;

                if (!this.modificar)
                {
                    if (proveedor.Grabar())
                    {
                        MessageBox.Show("Proveedor guardado correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMProveedor_Registrar_FormClosing;

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Proveedor no se pudo guardar!!",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (proveedor.Modificar())
                    {
                        MessageBox.Show("Proveedor modificado correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMProveedor_Registrar_FormClosing;

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Proveedor no se pudo modificar!!",
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
            bool respuesta = true;

            if (TXTRazon.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca la Razón Social del Proveedor", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTRazon.Focus();
                respuesta = false;
            }
            else if (TXTNitCi.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el NIT/Cédula del Proveedor", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Debe buscar y seleccionar una persona antes de guardar el proveedor", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                respuesta = false;
            }

            return respuesta;
        }
        private void LimpiarCasillas()
        {
            SWBEstado.Value = true;
            SWBUsar.Value = false;
            SWBUsar.Visible = false;
            TXTRazon.Text = "";
            TXTNitCi.Text = "";
            TXTTelefono.Text = "";
            TXTDireccion.Text = "";
        }
        private void JalarDatos()
        {
            proveedor.papvcodpro = this.codProMod;
            proveedor.ObtenerDatos();
            persona.papscodper = proveedor.fapvcodper;
            persona.ObtenerDatos();
            this.personaok = true;

            SWBUsar.Visible = true;
            SWBUsar.Value = proveedor.capvtippro;

            TXTRazon.Enabled = !proveedor.capvtippro;
            TXTNitCi.Enabled = !proveedor.capvtippro;

            SWBEstado.Value = proveedor.capvestpro;
            TXTRazon.Text = proveedor.capvrazsoc;
            TXTNitCi.Text = proveedor.capvnuidtr.ToString();
            TXTTelefono.Text = proveedor.capvtelefo;
            TXTDireccion.Text = proveedor.capvdirecc;
        }
        #endregion


    }
}
