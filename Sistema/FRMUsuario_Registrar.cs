using CapaRN;
using DevComponents.DotNetBar.Controls;
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
    public partial class FRMUsuario_Registrar : Form
    {
        #region Variables
        private aperson persona=new aperson();
        private ausuari usuario = new ausuari();
        private xnumcor correlativo = new xnumcor();
        public bool modificar = false;
        public String codUsuMod = "";
        public bool actualizar = false;
        public bool personaok = false;


        #endregion
        #region Constructor
        public FRMUsuario_Registrar()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        

        
        private bool VerificarIntegridad()
        {
            bool respuesta = true;
            ausuari usuario2 = new ausuari();
            usuario2.cauanomlog = TXTNombreLogin.Text;


            if (TXTNombreLogin.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el Login del Usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCi.Focus();
                respuesta = false;
            }

            else if (usuario2.ObtenerDatosLogin(modificar, usuario.cauanomlog))
            {
                MessageBox.Show("Ya existe ese Login Registrado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTNombreLogin.Focus();
                respuesta = false;
            }


            return respuesta;
        }

        private void LimpiarCasillas()
        {
            SWBEstado.Value = true;
            TXTCi.Text = "";
            TXTNombres.Text = "Nombre Completo";
            TXTNombreLogin.Text = "";
            TXTNombreLogin.Focus();
            DPEHuellas.EnrolledFingerMask = 0;
        }

        private void JalarDatos()
        {
            usuario.pauacodusu = this.codUsuMod;
            usuario.ObtenerDatos();
            persona.papscodper = usuario.fauacodper;
            persona.ObtenerDatos();
            SWBEstado.Value = usuario.cauaestusu;
            TXTCi.Text = persona.capsnumcid;
            DPEHuellas.EnrolledFingerMask = usuario.cauamashue;
            TXTNombres.Text = persona.capsapepat+" "+
                              persona.capsapemat+" "+
                              persona.capsnomper;
            TXTNombreLogin.Text = usuario.cauanomlog;
        }






        #endregion

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRMUsuario_Registrar_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FRMUsuario_Registrar_Load(object sender, EventArgs e)
        {
            



            if (this.modificar)
            {
                JalarDatos();
                BTNGuardar.Text = "&Modificar";
                this.Text = "Modificar Usuario";
                //GBDatos.Text = "Modificar Usuario";
                TXTCi.Focus();
            }
            else
            {
                LimpiarCasillas();
                BTNGuardar.Text = "&Guardar";
                this.Text = "Registrar Usuario";
                //GBDatos.Text = "Registrar Persona";
                TXTCi.Focus();
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

        //FALTA AGREGAR GROUP PANEL GENERAL

        private void TXTNombres_KeyDown(object sender, KeyEventArgs e)
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

        private void TXTNombreLogin_KeyDown(object sender, KeyEventArgs e)
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

        private void buttonX1_Click(object sender, EventArgs e)
        {
            FRMPersona_Buscar a=new FRMPersona_Buscar();
            a.ShowDialog();
            if (a.seleccionadorOK)
            {
                this.persona = a.persona;
                this.personaok = true;
                TXTCi.Text = persona.capsnumcid;
                TXTNombres.Text= persona.capsapepat + " " +
                           persona.capsapemat + " " +
                           persona.capsnomper;
            }
            else {
                this.personaok = false;
                TXTCi.Text = "";
                TXTNombres.Text = "Nombre Completo";
            }
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            if (VerificarIntegridad())
            {
                

                if (!this.modificar)
                {
                    //Generar el correlativo
                    correlativo.pxnctipcor = "ausuari";
                    if (correlativo.ObtenerSiguiente())
                    {
                        usuario.pauacodusu = correlativo.pxnctipcor + "-" +
                                             correlativo.cxncnumcor.ToString("D12");
                    }
                }
                else
                {
                    usuario.pauacodusu = this.codUsuMod;
                }
                usuario.cauaestusu = SWBEstado.Value;
                usuario.cauanomlog = TXTNombreLogin.Text;
                if (!modificar)
                {
                    usuario.cauaactcla = false;

                    usuario.cauamashue = DPEHuellas.EnrolledFingerMask;
                    
                    usuario.fauacodper = persona.papscodper;
                }
                

                

                if (!this.modificar)
                {
                    if (usuario.Grabar())
                    {
                        MessageBox.Show("Usuario guardado correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMUsuario_Registrar_FormClosing;
                        
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
                    if (usuario.Modificar())
                    {
                        MessageBox.Show("Usuario modificado correctamente!!",
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMUsuario_Registrar_FormClosing;
                       
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no se pudo modificar!!",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                    }
                }
            }
        }

       

        private void DPEHuellas_OnDelete(object Control, int FingerMask, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            if (usuario.cauanumhu1 == FingerMask)
            {
                usuario.cauanumhu1 = 0;
                usuario.cauacodhu1 = "";
            }
            else if (usuario.cauanumhu2 == FingerMask)
            {
                usuario.cauanumhu2 = 0;
                usuario.cauacodhu2 = "";
            }
            else if (usuario.cauanumhu3 == FingerMask)
            {
                usuario.cauanumhu3 = 0;
                usuario.cauacodhu3 = "";
            }
            else if (usuario.cauanumhu4 == FingerMask)
            {
                usuario.cauanumhu4 = 0;
                usuario.cauacodhu4 = "";
            }
        }

        private void DPEHuellas_OnEnroll(object Control, int FingerMask, DPFP.Template Template, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {

            byte[] aux = new byte[1700];
            Template.Serialize(ref aux);
            string cadena = Convert.ToBase64String(aux);

            if (usuario.cauanumhu1 == 0)
            {
                usuario.cauanumhu1 = FingerMask;
                usuario.cauacodhu1 = cadena;
            }
            else if (usuario.cauanumhu2 == 0)
            {
                usuario.cauanumhu2 = FingerMask;
                usuario.cauacodhu2 = cadena;
            }
            else if (usuario.cauanumhu3 == 0)
            {
                usuario.cauanumhu3 = FingerMask;
                usuario.cauacodhu3 = cadena;
            }
            else if (usuario.cauanumhu4 == 0)
            {
                usuario.cauanumhu4 = FingerMask;
                usuario.cauacodhu4 = cadena;
            }
        }
    }
}
