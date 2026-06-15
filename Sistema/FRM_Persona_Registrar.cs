
using CapaRN;
using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Video;
using Accord.Video.DirectShow;


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


        private FilterInfoCollection dispositivos;
        private VideoCaptureDevice camara;

        private Bitmap ultimoFrame;
        private Bitmap fotoCapturada;
        #endregion

        #region constructor
        public FRM_Persona_Registrar()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private void IniciarCamaraOBS()
        {
            dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo dispositivo in dispositivos)
            {
                if (dispositivo.Name.Contains("OBS"))
                {
                    camara = new VideoCaptureDevice(dispositivo.MonikerString);

                    camara.NewFrame += Camara_NewFrame;
                    camara.Start();

                    return;
                }
            }

            MessageBox.Show("No se encontró OBS Virtual Camera");
        }
        private bool VerificarIntegridad()
        {
            bool respuesta = true;

            persona.capsnumcid = TXTCi.Text;

            if (TXTCi.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el CI de la persona", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCi.Focus();
                respuesta = false;
            }

            else if (DTINacimiento.Value> DateTime.Now)
            {
                MessageBox.Show("Introduzca Fecha de Nacimiento valida de la Persona", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DTINacimiento.Focus();
                respuesta = false;
            }
            else if (DTINacimiento.Value > DateTime.Now)
            {
                MessageBox.Show("Introduzca Fecha de Nacimiento valida de la Persona", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DTINacimiento.Focus();
                respuesta = false;
            }
            else if (TXTApPa.Text.Replace(" ","")=="" && TXTApMa.Text.Replace(" ", "") == "") 
            {
                MessageBox.Show("Introduzca uno de los apellidos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTApPa.Focus();
                respuesta = false;
            }
            else if (TXTNombre.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca nombres", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTNombre.Focus();
                respuesta = false;
            }
            else if (TXTCorreo.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca un correo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCi.Focus();
                respuesta = false;
            }

            else if (!xgeneral.emailIsValid(TXTCorreo.Text))
            {
                MessageBox.Show("Introduzca un correo valido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCorreo.Focus();
                respuesta = false;
            }
            else if (TXTDireccion.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca una direccion", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCi.Focus();
                respuesta = false;
            }
            else if (TXTCelular.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca un celular", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCelular.Focus();
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
            persona.papscodper = this.codPerMod;
            persona.ObtenerDatos();
            SWBEstado.Value = persona.capsestper;
            TXTCi.Text = persona.capsnumcid;

            
            TXTApPa.Text=persona.capsapepat;
            TXTApMa.Text= persona.capsapemat;
            TXTNombre.Text= persona.capsnomper;
            TXTCelular.Text= persona.capsnumcel ;
             TXTCorreo.Text= persona.capscorele ;
             TXTDireccion.Text= persona.capsdirper ;
             DTINacimiento.Value= persona.capsfecnac ;
             
             SWBSexo.Value= persona.capssexper ;
        }


        #endregion

        #region Eventos



        #endregion

        private void Camara_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();

            ultimoFrame?.Dispose();
            ultimoFrame = (Bitmap)frame.Clone();

            PBPrevi.Invoke(new Action(() =>
            {
                PBPrevi.Image?.Dispose();
                PBPrevi.Image = frame;
            }));
        }

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

            IniciarCamaraOBS();



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
                        persona.papscodper = correlativo.pxnctipcor + "-" +
                                             correlativo.cxncnumcor.ToString("D12");
                    }
                }
                else
                {
                    persona.papscodper = this.codPerMod;
                }
                persona.capsnumcid = TXTCi.Text;
                persona.capsapepat = TXTApPa.Text;
                persona.capsapemat = TXTApMa.Text;
                persona.capsnomper = TXTNombre.Text;
                persona.capsnumcel = TXTCelular.Text;
                persona.capscorele = TXTCorreo.Text;
                persona.capsdirper = TXTDireccion.Text;
                persona.capsfecnac = DTINacimiento.Value;
                persona.capsestper = SWBEstado.Value;
                persona.capssexper = SWBSexo.Value;

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
            else if ((!e.Shift && e.KeyCode == Keys.Oemplus) ||
                     e.KeyCode == Keys.Add)
                teclaValida = true;
            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void BTNAbrirFoto_Click(object sender, EventArgs e)
        {
            if (OFDElegirImagen.ShowDialog()==DialogResult.OK)
            {
                PBPrevi.ImageLocation = OFDElegirImagen.FileName;
            }
            
        }
    }
}
