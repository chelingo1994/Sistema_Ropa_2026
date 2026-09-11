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
            bool respuesta = true;
            //aperson persona2 = new aperson();
            //persona2.capsnumcid = TXTCi.Text;



            if (CBMarca.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca Marca del Producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CBMarca.Focus();
                respuesta = false;
            }

           

            
            
            else if (CBTalla.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca la talla del Producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CBTalla.Focus();
                respuesta = false;
            }
            else if (CBNombreProducto.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el nombre del Producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CBNombreProducto.Focus();
                respuesta = false;
            }

            
            else if (CBColor.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el color del Producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CBColor.Focus();
                respuesta = false;
            }
            else if (CBMaterial.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el material del Producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CBMaterial.Focus();
                respuesta = false;
            }
            else if (IIPPrecio.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el precio del Producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IIPPrecio.Focus();
                respuesta = false;
            }
            else if (IIPPrecioMin.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el precio mínimo del Producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IIPPrecioMin.Focus();
                respuesta = false;
            }
            

            return respuesta;
        }

        private void LimpiarCasillas()
        {
            SWBEstado.Value = true;
            CBGenero.SelectedText = "";
            CBNombreProducto.Text = "";
            CBMarca.Text = "";
            CBTalla.Text = "";
            CBColor.Text = "";
            CBMaterial.Text = "";
            IIPPrecio.Text = "";
            IIPPrecioMin.Text = "";

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
            IIPPrecio.Text = producto.capdprvepr.ToString();
            IIPPrecioMin.Text=producto.capdprmipr.ToString();
            TXTDescripcion.Text=producto.capddespro.ToString();
            CBGenero.SelectedText = producto.capdgenpro.ToString();
            CBModelo.Text = producto.capdmodpro;
            CBMaterial.Text = producto.capdmatpro;
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
            PBCaptura.Image = (Bitmap)eventArgs.Frame.Clone();

            /*Bitmap frame = (Bitmap)eventArgs.Frame.Clone();

            ultimoFrame?.Dispose();
            ultimoFrame = (Bitmap)frame.Clone();

            PBCaptura.Invoke(new Action(() =>
            {
                PBCaptura.Image?.Dispose();
                PBCaptura.Image = frame;
            }));*/
        }

        private void ApagarCamara()
        {
            // Solo intenta detenerla si el objeto fue instanciado y está corriendo
            if (camara != null && camara.IsRunning == true)
            {
                camara.Stop();
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

            if (MessageBox.Show("¿Está seguro que desea cerrar el formulario?",
                               "Pregunta",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                ApagarCamara();
            }
        }

        private void FRMProductoRegistrar_Load(object sender, EventArgs e)
        {

            IniciarCamaraOBS();

            CargarCombos("capdgenpro", CBGenero);
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
                BTNGuardar.Text = "&Guardar";
                this.Text = "Registrar Producto";
                GBDatos.Text = "Registrar Producto";
                CBNombreProducto.Focus();
            }
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            if (VerificarIntegridad())
            {
                producto = new aproduc();

                if (!this.modificar)
                {
                    //Generar el correlativo
                    correlativo.pxnctipcor = "aproduc";
                    if (correlativo.ObtenerSiguiente())
                    {
                        producto.papdcodpro = correlativo.pxnctipcor + "-" +
                                             correlativo.cxncnumcor.ToString("D12");
                    }
                }
                else
                {
                    producto.papdcodpro = this.codProMod;
                }
                producto.capdestpro = SWBEstado.Value;
                producto.capdgenpro = CBGenero.SelectedItem.ToString();
                producto.fapdcodcat = CBCategoria.SelectedValue.ToString();
                producto.capdtalpro = CBTalla.Text;
                producto.capdmarpro = CBMarca.Text;
                producto.capdmodpro = CBModelo.Text;
                producto.capdnompro = CBNombreProducto.Text;
                producto.capdcolpro = CBColor.Text;
                producto.capdmatpro = CBMaterial.Text;
                producto.capdprvepr = Decimal.Parse(IIPPrecio.Text);
                producto.capdprmipr = Decimal.Parse(IIPPrecioMin.Text);
                producto.capddespro = TXTDescripcion.Text;
                producto.capdcodbar = "";
                producto.capdstopro = 0;

                //Fotografia del producto
                if (TieneFoto)
                {
                    producto.capdfotpro = MetodosGenerales.ConvertImageToBase64String(PBPrevi.Image);
                }
                else
                {
                    producto.capdfotpro = "";
                }

                if (!this.modificar)
                {
                    if (producto.Grabar())
                    {
                        MessageBox.Show("Persona guardada correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMProductoRegistrar_FormClosing;
                        ApagarCamara();
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
                    if (producto.Modificar())
                    {
                        MessageBox.Show("Persona modificada correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMProductoRegistrar_FormClosing;
                        ApagarCamara();
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

        private void TXTStock_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false;
            if ((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9))
                teclaValida = true;
            else if ((e.KeyCode >= Keys.D0) && (e.KeyCode <= Keys.D9) && !e.Shift)
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
            PBPrevi.Image = PBCaptura.Image;
            TieneFoto = true;
        }

        private void BTNAbrirFoto_Click(object sender, EventArgs e)
        {
            if (OFDElegirImagen.ShowDialog() == DialogResult.OK)
            {
                PBPrevi.ImageLocation = OFDElegirImagen.FileName;
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
