using Accord;
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
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Fonts;
using System.IO;
using System.Diagnostics;
namespace Sistema
{
    public partial class FRMVenta_Registrar : DevComponents.DotNetBar.OfficeForm
    {

        #region Variables
        public ausuari usuario = new ausuari();
        private xnumcor correlativo = new xnumcor();
        private aventas venta = new aventas();
        
        private aclient cliente = new aclient();
        private bool lectorCBHabilitado = false;
        public aproduc producto = new aproduc();
        private List<litemven> listaItems = new List<litemven>();
        public bool productook = false;
        private litemven itemModificar = new litemven();
        private bool productoItem = false;
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
                DTGLista[7, DTGLista.Rows.Count - 1].Value = a.capdstopro;
                DTGLista[8, DTGLista.Rows.Count - 1].Value = a.cdevpreuni;
                DTGLista[9, DTGLista.Rows.Count - 1].Value = a.cdevsubtot;

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
            item.capdstopro = producto.capdstopro;
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
            // Solo la tecla Suprimir elimina; las demás teclas (flechas, etc.) funcionan normal
            if (e.KeyCode == Keys.Delete && DTGLista.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar el producto seleccionado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EliminarItem(DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString());
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void DTGLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0 || e.RowIndex >= DTGLista.Rows.Count)
                return;
            if (DTGLista[0, e.RowIndex].Value == null)
                return;

            string codigo = DTGLista[0, e.RowIndex].Value.ToString();
            itemModificar = listaItems.Find(i => i.fdevcodpro == codigo);
            productoItem = itemModificar != null;
            if (itemModificar != null)
            {
                TXTDescripcion.Text = itemModificar.capddespro;
                IIPStock.Value = itemModificar.cdevcantid;
                DIPPrecio.Value = (Double)itemModificar.cdevpreuni;
                producto.papdcodpro = itemModificar.fdevcodpro;
                if (producto.ObtenerDatos())
                {
                    if (producto.capdfotpro == "")
                        PBCaptura.Image = Resources.NoImage;
                    else
                        PBCaptura.Image = MetodosGenerales.ConvertBase64StringToImage(producto.capdfotpro);
                }
            }
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            if (!productoItem || itemModificar == null)
            {
                MessageBox.Show("Haga doble clic en un producto de la lista para modificarlo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (DIPPrecio.Value <= 0)
            {
                MessageBox.Show("El precio debe ser mayor que cero.", "Precio inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 'producto' quedó cargado en el doble clic, con su stock actual
            if (!verificarstock((int)IIPStock.Value, producto))
                return;

            itemModificar.cdevcantid = (int)IIPStock.Value;
            itemModificar.cdevpreuni = (Decimal)DIPPrecio.Value;
            itemModificar.cdevsubtot = itemModificar.cdevcantid * itemModificar.cdevpreuni;
            actualizarGridItems();

            productoItem = false;
            itemModificar = null;
            TXTDescripcion.Text = "Descripción del producto";
            IIPStock.Value = 0;
            DIPPrecio.Value = 0;
            PBCaptura.Image = Resources.NoImage;
        }

        private void BTNLimpiarProducto_Click(object sender, EventArgs e)
        {
            productoItem = false;
            TXTDescripcion.Text = "Descripción del producto";
            IIPStock.Value = 0;
            DIPPrecio.Value = 0;
            PBCaptura.Image = Resources.NoImage;
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            if (!clienteok)
            {
                MessageBox.Show("Seleccione un cliente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (listaItems.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Generar correlativo de la venta
            correlativo.pxnctipcor = "aventas";
            if (correlativo.ObtenerSiguiente())
            {
                venta.pavtcodven = correlativo.pxnctipcor + "-" +
                                   correlativo.cxncnumcor.ToString("D12");
            }
            else
            {
                MessageBox.Show("No se pudo generar el código de la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generar correlativos del detalle (uno por cada producto)
            correlativo.pxnctipcor = "adetvet";
            if (correlativo.ObtenerSiguiente(listaItems.Count))
            {
                int numero = correlativo.cxncnumcor - listaItems.Count + 1;
                foreach (litemven item in listaItems)
                {
                    item.pdevcodeve = correlativo.pxnctipcor + "-" + numero.ToString("D12");
                    item.fdevcodven = venta.pavtcodven;
                    numero++;
                }
            }
            else
            {
                MessageBox.Show("No se pudo generar el código del detalle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cabecera de la venta
            venta.favtcodcli = cliente.pacecodcli;
            venta.cavtfechor = DateTime.Now;
            venta.cavtmontot = listaItems.Sum(i => i.cdevsubtot);
            venta.cavtestven = true;
            venta.cavtfeccre = DateTime.Now;
            venta.cavtfecmod = DateTime.Now;
            venta.cavtobserv = TXTObservaciones.Text;
            venta.favtcouscr = usuario.pauacodusu;
            venta.favtcousmo = usuario.pauacodusu;
            if (venta.Grabar(listaItems))
            {

                MessageBox.Show("Venta registrada correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string carpeta = Path.Combine(Application.StartupPath, "Ventas");
                Directory.CreateDirectory(carpeta);
                string archivo = Path.Combine(carpeta, "Venta_" + venta.pavtcodven + ".pdf");

                try
                {
                    GenerarPDF(archivo);
                    Process.Start(new ProcessStartInfo(archivo) { UseShellExecute = true }); // abre el PDF
                }
                catch (Exception ex)
                {
                    MessageBox.Show("La venta se guardó, pero no se pudo generar el PDF: " + ex.Message, "PDF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo registrar la venta. Revise ErrorLog.log", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void GenerarPDF(string archivo)
        {
            // Solo para PDFsharp 6.x: usar las fuentes instaladas en Windows
            GlobalFontSettings.UseWindowsFontsUnderWindows = true;

            PdfDocument documento = new PdfDocument();
            documento.Info.Title = "Nota de venta " + venta.pavtcodven;

            PdfPage pagina = documento.AddPage();
            pagina.Size = PdfSharp.PageSize.Letter;   // tamaño carta
            XGraphics g = XGraphics.FromPdfPage(pagina);

            XFont fTitulo = new XFont("Arial", 16, XFontStyleEx.Bold);
            XFont fNormal = new XFont("Arial", 10, XFontStyleEx.Regular);
            XFont fNegrita = new XFont("Arial", 10, XFontStyleEx.Bold);
            XBrush b = XBrushes.Black;

            // Medidas en puntos (72 puntos = 1 pulgada)
            double margen = 40;
            double x = margen;
            double y = margen;
            double ancho = pagina.Width.Point - margen * 2;
            double alto = 16;

            // ---------- Encabezado ----------
            g.DrawString("NOTA DE VENTA", fTitulo, b,
                         new XRect(x, y, ancho, 20), XStringFormats.TopCenter);
            y += 35;

            g.DrawString("N°: " + venta.pavtcodven, fNormal, b, x, y); y += alto;
            g.DrawString("Fecha: " + venta.cavtfechor.ToString("dd/MM/yyyy HH:mm"), fNormal, b, x, y); y += alto;
            g.DrawString("Cliente: " + cliente.cacerazsoc, fNormal, b, x, y); y += alto;
            g.DrawString("NIT/CI: " + cliente.cacenuidtr, fNormal, b, x, y); y += alto + 10;

            // ---------- Columnas ----------
            double cCant = x;
            double cDesc = x + 50;
            double cPrecio = x + ancho - 170;
            double cSub = x + ancho - 85;

            g.DrawLine(XPens.Black, x, y - 12, x + ancho, y - 12);
            g.DrawString("Cant.", fNegrita, b, cCant, y);
            g.DrawString("Descripción", fNegrita, b, cDesc, y);
            g.DrawString("P. Unit.", fNegrita, b, cPrecio, y);
            g.DrawString("Subtotal", fNegrita, b, cSub, y);
            y += 6;
            g.DrawLine(XPens.Black, x, y, x + ancho, y);
            y += alto;

            // ---------- Detalle ----------
            foreach (litemven item in listaItems)
            {
                // Nueva página si ya no entra
                if (y > pagina.Height.Point - margen - 60)
                {
                    pagina = documento.AddPage();
                    pagina.Size = PdfSharp.PageSize.Letter;
                    g.Dispose();
                    g = XGraphics.FromPdfPage(pagina);
                    y = margen;
                }

                g.DrawString(item.cdevcantid.ToString(), fNormal, b, cCant, y);
                g.DrawString(item.capdnompro + " " + item.capdtalpro, fNormal, b, cDesc, y);
                // Números alineados a la derecha
                g.DrawString(item.cdevpreuni.ToString("N2"), fNormal, b,
                             new XRect(cPrecio, y - 10, 70, alto), XStringFormats.TopRight);
                g.DrawString(item.cdevsubtot.ToString("N2"), fNormal, b,
                             new XRect(cSub, y - 10, 85, alto), XStringFormats.TopRight);
                y += alto;
            }

            // ---------- Total ----------
            g.DrawLine(XPens.Black, x, y - 8, x + ancho, y - 8);
            y += 6;
            g.DrawString("TOTAL Bs.:", fNegrita, b, cPrecio, y);
            g.DrawString(venta.cavtmontot.ToString("N2"), fNegrita, b,
                         new XRect(cSub, y - 10, 85, alto), XStringFormats.TopRight);
            y += alto + 8;
            g.DrawString("Son: " + LBTotalLiteral.Text, fNormal, b, x, y);

            g.Dispose();
            documento.Save(archivo);
            documento.Close();
        }

    }
}
