using CapaRN;
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
    public partial class FRMCategoriaRegistrar : DevComponents.DotNetBar.OfficeForm
    {
        #region Variables
        private acatego categoria = new acatego();
        private xnumcor correlativo = new xnumcor();
        public bool modificar = false;
        public String codCatMod = "";
        public bool actualizar = false;
        #endregion
        #region Constructor
        public FRMCategoriaRegistrar()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private bool VerificarIntegridad()
        {
            bool respuesta = true;

            if (TXTNombre.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el nombre de la categoría", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTNombre.Focus();
                respuesta = false;
            }
            return respuesta;
        }

        private void LimpiarCasillas()
        {
            SWBEstado.Value = true;
            TXTNombre.Text = "";
            TXTDescripcion.Text = "";
        }

        private void JalarDatos()
        {
            categoria.pacecodcat = this.codCatMod;
            categoria.ObtenerDatos();
            SWBEstado.Value = categoria.caceestcat;
            TXTNombre.Text = categoria.cacenomcat;
            TXTDescripcion.Text = categoria.cacedescat;
        }
        #endregion

        #region Eventos
        #endregion

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRMCategoriaRegistrar_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FRMCategoriaRegistrar_Load(object sender, EventArgs e)
        {
            if (this.modificar)
            {
                JalarDatos();
                BTNGuardar.Text = "&Modificar";
                this.Text = "Modificar Categoria";
                GBDatos.Text = "Modificar Categoria";
                TXTNombre.Focus();
            }
            else
            {
                LimpiarCasillas();
                BTNGuardar.Text = "&Guardar";
                this.Text = "Registrar Categoria";
                GBDatos.Text = "Registrar Categoria";
                TXTNombre.Focus();
            }
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            if (VerificarIntegridad())
            {
                categoria = new acatego();

                if (!this.modificar)
                {
                    //Generar el correlativo
                    correlativo.pxnctipcor = "acatego";
                    if (correlativo.ObtenerSiguiente())
                    {
                        categoria.pacecodcat = correlativo.pxnctipcor + "-" +
                                                correlativo.cxncnumcor.ToString("D12");
                    }
                }
                else
                {
                    categoria.pacecodcat = this.codCatMod;
                }
                categoria.caceestcat = SWBEstado.Value;
                categoria.cacenomcat = TXTNombre.Text;
                categoria.cacedescat = TXTDescripcion.Text;
                

               
                if (!this.modificar)
                {
                    if (categoria.Grabar())
                    {
                        MessageBox.Show("Categoría guardada correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMCategoriaRegistrar_FormClosing;
                        
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Categoría no se pudo guardar!!",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (categoria.Modificar())
                    {
                        MessageBox.Show("Categoría modificada correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMCategoriaRegistrar_FormClosing;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Categoría no se pudo modificar!!",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                    }
                }
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
    }
}
