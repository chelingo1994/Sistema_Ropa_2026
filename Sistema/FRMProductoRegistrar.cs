using Accord.Video;
using Accord.Video.DirectShow;
using DevComponents.DotNetBar.Controls;
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
    public partial class FRMProductoRegistrar : DevComponents.DotNetBar.OfficeForm
    {
        #region Variables
        private bool lectorCBHabilitado = false;
        public aproduc producto = new aproduc();
        private xnumcor correlativo = new xnumcor();
        public bool modificar = false;
        public String codProMod = "";
        public bool actualizar = false;


        private FilterInfoCollection dispositivos;
        private VideoCaptureDevice camara;

        private Bitmap ultimoFrame;
        private Bitmap fotoCapturada;
        private bool TieneFoto = false;

        private readonly object frameLock = new object();
        private bool cerrandoCamara = false;


        #endregion

        #region Constructor

        public FRMProductoRegistrar()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private void IniciarCamaraOBS()
        {
            bool camaraEncontrada = false;

            try
            {
                dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                foreach (FilterInfo dispositivo in dispositivos)
                {
                    // Ampliamos un poco la búsqueda por si se llama "OBS Virtual Camera" u otro similar
                    if (dispositivo.Name.Contains("OBS") || dispositivo.Name.Contains("Virtual"))
                    {
                        camara = new VideoCaptureDevice(dispositivo.MonikerString);
                        camara.NewFrame += Camara_NewFrame;
                        camara.Start();
                        camaraEncontrada = true;
                        return; // Sale del método porque ya encontró e inició la cámara
                    }
                }

                // Si el ciclo termina y no cambió la variable, significa que no encontró la cámara
                if (!camaraEncontrada)
                {
                    MostrarSinCamara();
                }
            }
            catch
            {
                MostrarSinCamara();
            }
        }

        // Método auxiliar para manejar visualmente la falta de cámara
        private void MostrarSinCamara()
        {
            MessageBox.Show("No hay una cámara OBS o virtual activada/disponible.",
                            "Advertencia de Cámara",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

            // Asignar la imagen por defecto al PictureBox donde se vería la cámara
            if (PBCaptura != null)
            {
                PBCaptura.Image = Resources.NoImage;
            }
        }
        private bool VerificarIntegridad()
        {
            // ==========================================
            // MARCA
            // ==========================================
            if (string.IsNullOrWhiteSpace(CBMarca.Text))
            {
                MessageBox.Show(
                    "Introduzca la marca del producto.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CBMarca.Focus();
                return false;
            }

            // ==========================================
            // TALLA
            // ==========================================
            if (string.IsNullOrWhiteSpace(CBTalla.Text))
            {
                MessageBox.Show(
                    "Introduzca la talla del producto.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CBTalla.Focus();
                return false;
            }

            // ==========================================
            // NOMBRE DEL PRODUCTO
            // ==========================================
            if (string.IsNullOrWhiteSpace(CBNombreProducto.Text))
            {
                MessageBox.Show(
                    "Introduzca el nombre del producto.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CBNombreProducto.Focus();
                return false;
            }

            // ==========================================
            // COLOR
            // ==========================================
            if (string.IsNullOrWhiteSpace(CBColor.Text))
            {
                MessageBox.Show(
                    "Introduzca el color del producto.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CBColor.Focus();
                return false;
            }

            // ==========================================
            // MATERIAL
            // ==========================================
            if (string.IsNullOrWhiteSpace(CBMaterial.Text))
            {
                MessageBox.Show(
                    "Introduzca el material del producto.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CBMaterial.Focus();
                return false;
            }

            // ==========================================
            // GÉNERO
            // ==========================================
            if (CBGenero.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(CBGenero.Text))
            {
                MessageBox.Show(
                    "Seleccione el género del producto.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CBGenero.Focus();
                return false;
            }

            // ==========================================
            // CATEGORÍA
            // ==========================================
            if (CBCategoria.SelectedIndex == -1 ||
                CBCategoria.SelectedValue == null)
            {
                MessageBox.Show(
                    "Seleccione la categoría del producto.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CBCategoria.Focus();
                return false;
            }

            // ==========================================
            // PRECIO DE VENTA
            // ==========================================
            decimal precioVenta;

            if (string.IsNullOrWhiteSpace(DIPPrecio.Text))
            {
                MessageBox.Show(
                    "Introduzca el precio de venta del producto.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                DIPPrecio.Focus();
                return false;
            }

            if (!decimal.TryParse(DIPPrecio.Text, out precioVenta))
            {
                MessageBox.Show(
                    "El precio de venta no es válido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                DIPPrecio.Focus();
                return false;
            }

            if (precioVenta <= 0)
            {
                MessageBox.Show(
                    "El precio de venta debe ser mayor a cero.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                DIPPrecio.Focus();
                return false;
            }

            // ==========================================
            // PRECIO MÍNIMO
            // ==========================================
            decimal precioMinimo;

            if (string.IsNullOrWhiteSpace(DIPPrecioMin.Text))
            {
                MessageBox.Show(
                    "Introduzca el precio mínimo del producto.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                DIPPrecioMin.Focus();
                return false;
            }

            if (!decimal.TryParse(DIPPrecioMin.Text, out precioMinimo))
            {
                MessageBox.Show(
                    "El precio mínimo no es válido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                DIPPrecioMin.Focus();
                return false;
            }

            if (precioMinimo < 0)
            {
                MessageBox.Show(
                    "El precio mínimo no puede ser negativo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                DIPPrecioMin.Focus();
                return false;
            }

            // El precio mínimo no puede ser mayor
            // que el precio de venta.
            if (precioMinimo > precioVenta)
            {
                MessageBox.Show(
                    "El precio mínimo no puede ser mayor al precio de venta.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                DIPPrecioMin.Focus();
                return false;
            }

            // ==========================================
            // CÓDIGO DE BARRAS
            // ==========================================
            string codigoBarras = LBLCodigoDeBarras.Text.Trim();

            // Estos textos NO son códigos reales.
            if (codigoBarras == "SIN CÓDIGO" ||
                codigoBarras == "LECTOR ACTIVO")
            {
                codigoBarras = "";
            }

            // El código de barras es OPCIONAL.
            // Solo comprobamos duplicidad si existe uno.
            if (!string.IsNullOrWhiteSpace(codigoBarras))
            {
                string codigoProductoActual = "";

                // Si estamos modificando,
                // excluimos el producto actual.
                if (this.modificar)
                {
                    codigoProductoActual = this.codProMod;
                }

                aproduc productoValidacion = new aproduc();

                if (productoValidacion.ExisteCodigoBarras(
                        codigoBarras,
                        codigoProductoActual))
                {
                    MessageBox.Show(
                        "El código de barras '" + codigoBarras +
                        "' ya está registrado en otro producto.",
                        "Código de barras duplicado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    LBLCodigoDeBarras.BackColor = Color.Salmon;
                    LBLCodigoDeBarras.Focus();

                    return false;
                }

                LBLCodigoDeBarras.BackColor = Color.LightBlue;
            }

            // ==========================================
            // TODO CORRECTO
            // ==========================================
            return true;
        }



        private void LimpiarCasillas()
        {
            SWBEstado.Value = true;

            CBGenero.SelectedIndex = -1;
            CBCategoria.SelectedIndex = -1;

            CBNombreProducto.Text = "";
            CBMarca.Text = "";
            CBTalla.Text = "";
            CBColor.Text = "";
            CBMaterial.Text = "";
            CBModelo.Text = "";

            DIPPrecio.Text = "";
            DIPPrecioMin.Text = "";

            TXTDescripcion.Text = "";

            // El nuevo producto comienza sin código
            LBLCodigoDeBarras.Text = "SIN CÓDIGO";
            LBLCodigoDeBarras.BackColor = Color.Salmon;

            // El nuevo producto comienza sin fotografía
            TieneFoto = false;

            if (PBPrevi != null)
            {
                PBPrevi.Image = Resources.NoImage;
            }

            // El stock NO se modifica desde aquí.
            // Si este formulario registra un producto nuevo,
            // el stock se establecerá en 0 al guardar.
        }


        private void JalarDatos()
        {
            producto.papdcodpro = this.codProMod;
            producto.ObtenerDatos();
            SWBEstado.Value = producto.capdestpro;
            CBCategoria.SelectedValue = producto.fapdcodcat;


            CBMarca.Text = producto.capdmarpro;
            CBTalla.Text = producto.capdtalpro;
            CBNombreProducto.Text = producto.capdnompro;
            CBColor.Text = producto.capdcolpro;
            CBMaterial.Text = producto.capdmatpro;
            DIPPrecio.Text = producto.capdprvepr.ToString();
            DIPPrecioMin.Text = producto.capdprmipr.ToString();
            TXTDescripcion.Text=producto.capddespro.ToString();
            CBGenero.Text = producto.capdgenpro;
            CBModelo.Text = producto.capdmodpro;
            CBMaterial.Text = producto.capdmatpro;
            LBLCodigoDeBarras.Text = producto.capdcodbar;
            IIPStock.Text = producto.capdstopro.ToString();
            if (producto.capdfotpro == "")
            {
                TieneFoto = false;
                PBPrevi.Image = Resources.NoImage;
            }
            else
            {
                TieneFoto = true;
                PBPrevi.Image = MetodosGenerales.ConvertBase64StringToImage(producto.capdfotpro);
            }
        }

        private void CargarCategorias()
        {
            acatego categoria = new acatego();

            List<acatego> lista = categoria.Lista("caceestcat = true order by cacenomcat");

            CBCategoria.DataSource = lista;
            CBCategoria.DisplayMember = "cacenomcat";
            CBCategoria.ValueMember = "pacecodcat";
            CBCategoria.SelectedIndex = -1;
        }

        private void CargarCombos(String campo,ComboBox combo)
        {
            
            List<string> listacampo=new List<string>();
            combo.Items.Clear();
            listacampo =producto.ComboProducto(campo);
            combo.DataSource = listacampo;
            combo.SelectedIndex = -1;

        }
        #endregion

        #region EventosCamara
        private void Camara_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                if (cerrandoCamara)
                    return;

                Bitmap frame = (Bitmap)eventArgs.Frame.Clone();

                lock (frameLock)
                {
                    if (cerrandoCamara)
                    {
                        frame.Dispose();
                        return;
                    }

                    ultimoFrame?.Dispose();
                    ultimoFrame = frame;
                }

                if (PBCaptura.IsDisposed || !PBCaptura.IsHandleCreated)
                    return;

                PBCaptura.BeginInvoke(new Action(() =>
                {
                    if (cerrandoCamara ||
                        PBCaptura.IsDisposed ||
                        !PBCaptura.IsHandleCreated)
                        return;

                    Bitmap copia = null;

                    lock (frameLock)
                    {
                        if (ultimoFrame != null)
                            copia = (Bitmap)ultimoFrame.Clone();
                    }

                    if (copia == null)
                        return;

                    Image anterior = PBCaptura.Image;
                    PBCaptura.Image = copia;

                    if (anterior != null)
                        anterior.Dispose();
                }));
            }
            catch
            {
                // La cámara continúa con el siguiente frame
            }
        }



        private void ApagarCamara()
        {
            cerrandoCamara = true;

            try
            {
                if (camara != null)
                {
                    camara.NewFrame -= Camara_NewFrame;

                    if (camara.IsRunning)
                    {
                        camara.SignalToStop();
                        camara.WaitForStop();
                    }

                    camara = null;
                }
            }
            catch
            {
            }

            lock (frameLock)
            {
                ultimoFrame?.Dispose();
                ultimoFrame = null;
            }

            // Liberar imagen mostrada en la cámara
            if (PBCaptura != null && !PBCaptura.IsDisposed)
            {
                Image imagen = PBCaptura.Image;
                PBCaptura.Image = null;

                if (imagen != null && imagen != Resources.NoImage)
                    imagen.Dispose();
            }
        }

        #endregion

        #region Eventos
        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRMProductoRegistrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(
                "¿Está seguro que desea cerrar el formulario?",
                "Pregunta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            ApagarCamara();
        }



        private void FRMProductoRegistrar_Load(object sender, EventArgs e)
        {
            IIPStock.Enabled = false;

            IniciarCamaraOBS();

            CargarCombos("capdmarpro", CBMarca);
            CargarCombos("capdtalpro", CBTalla);
            CargarCombos("capdmodpro", CBModelo);
            CargarCombos("capdcolpro", CBColor);
            CargarCombos("capdmatpro", CBMaterial);
            CargarCombos("capdnompro", CBNombreProducto);

            CargarCategorias();

            if (this.modificar)
            {
                JalarDatos();

                BTNGuardar.Text = "&Modificar";
                this.Text = "Modificar Producto";
                GBDatos.Text = "Modificar Producto";

                CBNombreProducto.Focus();
            }
            else
            {
                LimpiarCasillas();

                IIPStock.Text = "0";

                BTNGuardar.Text = "&Guardar";
                this.Text = "Registrar Producto";
                GBDatos.Text = "Registrar Producto";

                CBNombreProducto.Focus();
            }
        }


        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            if (!VerificarIntegridad())
            {
                return;
            }

            producto = new aproduc();

            // ==========================================
            // CÓDIGO DEL PRODUCTO
            // ==========================================
            if (!this.modificar)
            {
                // Generar correlativo
                correlativo.pxnctipcor = "aproduc";

                if (correlativo.ObtenerSiguiente())
                {
                    producto.papdcodpro =
                        correlativo.pxnctipcor + "-" +
                        correlativo.cxncnumcor.ToString("D12");
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo generar el código del producto.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }
            }
            else
            {
                producto.papdcodpro = this.codProMod;
            }

            // ==========================================
            // DATOS DEL PRODUCTO
            // ==========================================
            producto.capdestpro = SWBEstado.Value;

            producto.capdgenpro = CBGenero.Text;

            producto.fapdcodcat =
                CBCategoria.SelectedValue.ToString();

            producto.capdtalpro = CBTalla.Text.Trim();

            producto.capdmarpro = CBMarca.Text.Trim();

            producto.capdmodpro = CBModelo.Text.Trim();

            producto.capdnompro =
                CBNombreProducto.Text.Trim();

            producto.capdcolpro =
                CBColor.Text.Trim();

            producto.capdmatpro =
                CBMaterial.Text.Trim();

            producto.capdprvepr =
                Decimal.Parse(DIPPrecio.Text);

            producto.capdprmipr =
                Decimal.Parse(DIPPrecioMin.Text);

            producto.capddespro =
                TXTDescripcion.Text.Trim();

            // ==========================================
            // CÓDIGO DE BARRAS
            // ==========================================
            string codigoBarras =
                LBLCodigoDeBarras.Text.Trim();

            // Si no hay código, guardar vacío.
            if (codigoBarras == "SIN CÓDIGO" ||
                codigoBarras == "LECTOR ACTIVO")
            {
                codigoBarras = "";
            }

            producto.capdcodbar = codigoBarras;

            // ==========================================
            // STOCK
            // ==========================================
            // IMPORTANTE:
            //
            // Producto NUEVO:
            //     Stock = 0
            //
            // Producto EXISTENTE:
            //     NO modificar stock.
            //
            if (!this.modificar)
            {
                producto.capdstopro = 0;
            }

            // ==========================================
            // FOTOGRAFÍA
            // ==========================================
            if (TieneFoto && PBPrevi.Image != null)
            {
                producto.capdfotpro =
                    MetodosGenerales.ConvertImageToBase64String(
                        PBPrevi.Image);
            }
            else
            {
                // En producto nuevo sin foto
                producto.capdfotpro = "";
            }

            // ==========================================
            // GUARDAR NUEVO PRODUCTO
            // ==========================================
            if (!this.modificar)
            {
                if (producto.Grabar())
                {
                    MessageBox.Show(
                        "Producto guardado correctamente.",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarCasillas();

                    this.actualizar = true;

                    this.FormClosing -=
                        FRMProductoRegistrar_FormClosing;

                    ApagarCamara();

                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "El producto no se pudo guardar.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            // ==========================================
            // MODIFICAR PRODUCTO
            // ==========================================
            else
            {
                if (producto.Modificar())
                {
                    MessageBox.Show(
                        "Producto modificado correctamente.",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarCasillas();

                    this.actualizar = true;

                    this.FormClosing -=
                        FRMProductoRegistrar_FormClosing;

                    ApagarCamara();

                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "El producto no se pudo modificar.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }


        private void TXTMarca_KeyDown(object sender, KeyEventArgs e)
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

        private void TXTalla_KeyDown(object sender, KeyEventArgs e)
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

        private void TXTModelo_KeyDown(object sender, KeyEventArgs e)
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

        private void TXTColor_KeyDown(object sender, KeyEventArgs e)
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

        private void TXTMaterial_KeyDown(object sender, KeyEventArgs e)
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

        

        private void TXTPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false;

            // Números del teclado numérico
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
                teclaValida = true;

            // Números de la fila superior
            else if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && !e.Shift)
                teclaValida = true;

            // Teclas de edición
            else if (
                e.KeyCode == Keys.Back ||
                e.KeyCode == Keys.Delete ||
                e.KeyCode == Keys.Left ||
                e.KeyCode == Keys.Right)
                teclaValida = true;

            // Coma
            else if (e.KeyCode == Keys.Oemcomma)
                teclaValida = true;

            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void TXTPrecioMin_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false;

            // Números del teclado numérico
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
                teclaValida = true;

            // Números de la fila superior
            else if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && !e.Shift)
                teclaValida = true;

            // Teclas de edición
            else if (
                e.KeyCode == Keys.Back ||
                e.KeyCode == Keys.Delete ||
                e.KeyCode == Keys.Left ||
                e.KeyCode == Keys.Right)
                teclaValida = true;

            // Coma
            else if (e.KeyCode == Keys.Oemcomma)
                teclaValida = true;

            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }
        }

        #endregion

        private void BTNCapturarFoto_Click(object sender, EventArgs e)
        {
            Bitmap foto = null;

            lock (frameLock)
            {
                if (ultimoFrame != null)
                {
                    foto = (Bitmap)ultimoFrame.Clone();
                }
            }

            if (foto == null)
            {
                MessageBox.Show(
                    "No hay una imagen disponible para capturar.",
                    "Cámara",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Liberar fotografía anterior
            if (PBPrevi.Image != null)
            {
                PBPrevi.Image.Dispose();
                PBPrevi.Image = null;
            }

            PBPrevi.Image = foto;

            TieneFoto = true;
        }



        private void BTNAbrirFoto_Click(object sender, EventArgs e)
        {
            if (OFDElegirImagen.ShowDialog() == DialogResult.OK)
            {
                PBPrevi.ImageLocation =
                    OFDElegirImagen.FileName;

                TieneFoto = true;
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
                    LBLCodigoDeBarras.BackColor = Color.LightBlue;
                }
                lectorCBHabilitado = false;
                CBModelo.Focus();
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
