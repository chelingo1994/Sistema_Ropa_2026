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
        private List<litemven> listaItems = new List<litemven>();
        public bool productook = false;

        private bool clienteok = false;
        #endregion
        #region Constructor
        public FRMVenta_Registrar()
        {
            InitializeComponent();
        }
        #endregion
        #region Eventos
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
                        agregarProductoALista(producto);
                        lectorCBHabilitado = true;
                        LBLCodigoDeBarras.Text = "LECTOR ACTIVO";

                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado", "Mensaje", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        LBLCodigoDeBarras.Text = "Lector Activo";
                        LBLCodigoDeBarras.BackColor = Color.PaleGreen;
                        BTNCodigoDeBarras.Focus();
                    }
                }
                
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
        #endregion

        #region Metodos
        private void actualizarGridItems()
        {
            DTGLista.Rows.Clear();
            foreach (litemven a in listaItems)
            {
                DTGLista.Rows.Add();
                DTGLista[0, DTGLista.Rows.Count - 1].Value = a.fdevcodpro;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = a.capdmodpro;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = a.capdcodbar;
                DTGLista[3, DTGLista.Rows.Count - 1].Value = a.capdnompro;
                DTGLista[4, DTGLista.Rows.Count - 1].Value = a.capdtalpro;
                DTGLista[5, DTGLista.Rows.Count - 1].Value = a.capddespro;
                DTGLista[6, DTGLista.Rows.Count - 1].Value = a.cdevcantid;
                DTGLista[7, DTGLista.Rows.Count - 1].Value = a.cdevpreuni;
                DTGLista[8, DTGLista.Rows.Count - 1].Value = a.cdevsubtot;

            }
            actualizarTotal();
        }
        private void actualizarTotal()
        {
            decimal total = listaItems.Sum(i => i.cdevsubtot);


            LBTotal.Text = total.ToString("N2");


            string literal = MetodosGenerales.ConvertirNumeroALetras((double)total);
            LBTotalLiteral.Text = char.ToUpper(literal[0]) + literal.Substring(1) + " Bolivianos";
        }

        private void agregarProductoALista(aproduc producto)
        {
            if (producto == null)
            {
                MessageBox.Show("No se ha seleccionado ningún producto.");
                return;
            }


            litemven existente = listaItems.FirstOrDefault(i =>
                (!string.IsNullOrEmpty(producto.papdcodpro)
                    && i.fdevcodpro == producto.papdcodpro)
                ||
                (string.IsNullOrEmpty(producto.papdcodpro)
                    && i.capdcodbar == producto.capdcodbar));

            if (existente != null)
            {

                int nuevaCantidad = existente.cdevcantid + 1;


                if (!verificarstock(nuevaCantidad, producto))
                    return;

                existente.cdevcantid = nuevaCantidad;
                existente.cdevsubtot =
                    existente.cdevcantid * existente.cdevpreuni;

                actualizarGridItems();
                return;
            }


            if (!verificarstock(1, producto))
                return;

            litemven item = new litemven();

            item.fdevcodpro = producto.papdcodpro;
            item.capdmodpro = producto.capdmodpro;
            item.capdcodbar = producto.capdcodbar;
            item.capdnompro = producto.capdnompro;
            item.capdtalpro = producto.capdtalpro;
            item.capddespro = producto.capddespro;

            item.cdevcantid = 1;
            item.cdevpreuni = producto.capdprvepr;
            item.cdevsubtot = item.cdevcantid * item.cdevpreuni;
            item.cdevesdeve = true;

            listaItems.Add(item);

            actualizarGridItems();
        }


        private bool verificarstock(int cantidad, aproduc producto)
        {
         

            if (cantidad <= 0)
            {
                MessageBox.Show(
                    "La cantidad debe ser mayor que cero.",
                    "Cantidad inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (producto.capdstopro <= 0)
            {
                MessageBox.Show(
                    "El producto no tiene stock disponible.",
                    "Stock insuficiente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (cantidad > producto.capdstopro)
            {
                MessageBox.Show(
                    $"Stock insuficiente. Stock disponible: {producto.capdstopro}. " +
                    $"Cantidad solicitada: {cantidad}.",
                    "Stock insuficiente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void EliminarItem(string codPro)
        {
            listaItems.RemoveAll(i => i.fdevcodpro == codPro);
            actualizarGridItems();
        }
        #endregion

        private void BTNCodigoDeBarras_Leave(object sender, EventArgs e)
        {
            lectorCBHabilitado = false;
            LBLCodigoDeBarras.Text = "LECTOR INACTIVO";
            LBLCodigoDeBarras.BackColor = Color.Salmon;
        }

        private void FRMVenta_Registrar_Load(object sender, EventArgs e)
        {
            lectorCBHabilitado = false;
            LBLCodigoDeBarras.Text = "LECTOR INACTIVO";
            LBLCodigoDeBarras.BackColor = Color.Salmon;
            LBTotal.Text = "0.00";
            LBTotalLiteral.Text = "Cero 00/100 Bolivianos";
        }

        private void btn_buscar_producto_Click(object sender, EventArgs e)
        {
            FRMProducto_Buscar a = new FRMProducto_Buscar();
            a.ShowDialog();
            if (a.seleccionadoOk)
            {
                this.producto = a.producto;
                this.productook = true;
                agregarProductoALista(this.producto);
            }
            else
            {
                this.productook = false;
                
            }
        }

       

       
        

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (DTGLista.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar el producto seleccionado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EliminarItem(DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString());
                }
             }

        }

        private void DTGLista_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false;
            //Identificar si es una tecla válida
            if ((e.KeyCode >= Keys.Delete))
                teclaValida = true;
                if (DTGLista.SelectedRows.Count > 0)
             {
                if (MessageBox.Show("¿Está seguro de que desea eliminar el producto seleccionado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EliminarItem(DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString());
                }
            }

            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
