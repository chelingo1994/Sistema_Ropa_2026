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
    public partial class FRMVenta_Registrar : DevComponents.DotNetBar.OfficeForm
    {

        #region Variables
        private aclient cliente = new aclient();
        private bool lectorCBHabilitado = false;
        public aproduc producto = new aproduc();
        private bool clienteok = false;
        #endregion
        public FRMVenta_Registrar()
        {
            InitializeComponent();
        }

        private void TXTNitCi_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(TXTNitCi.Text, out int nit))
            {
                cliente.cacenuidtr = nit;

                if (cliente.ObtenerDatosNIT())
                {
                    TXTNombreCliente.Text = cliente.cacerazsoc;
                    clienteok = true;
                }
                else
                {
                    TXTNombreCliente.Text = "";
                    clienteok = false;
                }
            }
            else
            {
                TXTNombreCliente.Text = "";
                clienteok = false;
            }
        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            FRMCliente_Buscar a = new FRMCliente_Buscar();
            a.ShowDialog();
            if (a.seleccionadoOk)
            {
                this.cliente = a.cliente;
                this.clienteok = true;
                TXTNitCi.Text = cliente.cacenuidtr.ToString();
                TXTNombreCliente.Text = cliente.cacerazsoc;
            }
            else
            {
                this.clienteok = false;
                TXTNitCi.Text = "";
                TXTNombreCliente.Text = "Nombre del cliente";
            }
        }

        private void BTNCodigoDeBarras_Click(object sender, EventArgs e)
        {
            if (!lectorCBHabilitado)
            {
                lectorCBHabilitado = true;
                LBLCodigoDeBarras.Text = "LECTOR ACTIVO";
                LBLCodigoDeBarras.BackColor = Color.PaleGreen;
            }
            else
            {
                if (LBLCodigoDeBarras.Text == "LECTOR ACTIVO")
                {
                    LBLCodigoDeBarras.Text = "SIN CÓDIGO";
                    LBLCodigoDeBarras.BackColor = Color.Salmon;
                }
                else
                {
                    producto.capdcodbar = LBLCodigoDeBarras.Text;
                    if (producto.ObtenerDatosCodigo(false, producto.capdcodbar))
                    {
                        MessageBox.Show("Producto encontrado " + producto.capddespro);
                    }
                }
                lectorCBHabilitado = false;
            }
        }

        private void BTNCodigoDeBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (LBLCodigoDeBarras.Text == "LECTOR ACTIVO")
            {
                LBLCodigoDeBarras.Text = "" + e.KeyChar;
            }
            else
            {
                LBLCodigoDeBarras.Text += e.KeyChar;
            }
        }
    }
}
