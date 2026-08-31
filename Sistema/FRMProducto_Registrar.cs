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
    public partial class FRMProducto_Registrar : DevComponents.DotNetBar.OfficeForm
    {
        #region Variables
        private aproduc producto = new aproduc();
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

        public FRMProducto_Registrar()
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



            if (TXTMarca.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca Marca del Producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTMarca.Focus();
                respuesta = false;
            }

           

            
            
            else if (TXTalla.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca la talla del Producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTalla.Focus();
                respuesta = false;
            }
            else if (TXTNombre.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el nombre del Producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTNombre.Focus();
                respuesta = false;
            }

            
            else if (TXTColor.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el color del Producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTColor.Focus();
                respuesta = false;
            }
            else if (TXTMaterial.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el material del Producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTMaterial.Focus();
                respuesta = false;
            }
            else if (TXTPrecio.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el precio del Producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTPrecio.Focus();
                respuesta = false;
            }
            else if (TXTPrecioMin.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el precio mínimo del Producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTPrecioMin.Focus();
                respuesta = false;
            }
            else if (TXTPrecio.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el precio del Producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTPrecio.Focus();
                respuesta = false;
            }

            return respuesta;
        }

        private void LimpiarCasillas()
        {
            SWBEstado.Value = true;
            SWBSexo.Value = true;
            TXTNombre.Text = "";
            TXTMarca.Text = "";
            TXTalla.Text = "";
            TXTColor.Text = "";
            TXTMaterial.Text = "";
            TXTPrecio.Text = "";
            TXTPrecioMin.Text = "";

        }

        private void JalarDatos()
        {
            producto.papdcodpro = this.codProMod;
            producto.ObtenerDatos();
            SWBEstado.Value = producto.capdestpro;
            CBCategoria.SelectedValue = producto.fapdcodcat;


            TXTMarca.Text = producto.capdmarpro;
            TXTalla.Text = producto.capdtalpro;
            TXTNombre.Text = producto.capdnompro;
            TXTColor.Text = producto.capdcolpro;
            TXTDescripcion.Text = producto.capdmatpro;
            TXTPrecio.Text = producto.capdprvepr.ToString();
            TXTPrecioMin.Text=producto.capdprmipr.ToString();
            TXTStock.Text = producto.capdstopro.ToString();
            TXTDescripcion.Text=producto.capddespro.ToString();
            SWBSexo.Value = producto.capdgenpro;
            TXTModelo.Text = producto.capdmodpro;
            TXTMaterial.Text = producto.capdmatpro;
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
            lproduc categoria = new lproduc();

            List<lproduc> lista = categoria.ListaCategorias();

            CBCategoria.DataSource = lista;
            CBCategoria.DisplayMember = "cacenomcat";
            CBCategoria.ValueMember = "pacecodcat";
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


            CargarCategorias();
            if (this.modificar)
            {
                JalarDatos();
                BTNGuardar.Text = "&Modificar";
                this.Text = "Modificar Producto";
                GBDatos.Text = "Modificar Producto";
                TXTNombre.Focus();
            }
            else
            {
                LimpiarCasillas();
                BTNGuardar.Text = "&Guardar";
                this.Text = "Registrar Producto";
                GBDatos.Text = "Registrar Producto";
                TXTNombre.Focus();
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
                producto.capdgenpro = SWBSexo.Value;
                producto.fapdcodcat = CBCategoria.SelectedValue.ToString();
                producto.capdtalpro = TXTalla.Text;
                producto.capdmarpro = TXTMarca.Text;
                producto.capdmodpro = TXTModelo.Text;
                producto.capdnompro = TXTNombre.Text;
                producto.capdcolpro = TXTColor.Text;
                producto.capdmatpro = TXTMaterial.Text;
                producto.capdprvepr = Decimal.Parse(TXTPrecio.Text);
                producto.capdprmipr = Decimal.Parse(TXTPrecioMin.Text);
                producto.capddespro = TXTDescripcion.Text;
                producto.capdcodbar = "";
                producto.capdstopro = int.Parse(TXTStock.Text);

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

        private void TXTPrecioMin_KeyDown(object sender, KeyEventArgs e)
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
    }
}
