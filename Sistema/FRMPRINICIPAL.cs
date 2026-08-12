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
using System.Windows.Forms.VisualStyles;

namespace Sistema
{
    public partial class FRMPRINICIPAL : DevComponents.DotNetBar.OfficeForm
    {
        #region Variables
        public ausuari usuario = new ausuari();
        public aperson persona = new aperson();
        #endregion
        #region Constructor
        public FRMPRINICIPAL()
        {
            InitializeComponent();
        }
        #endregion
        #region Eventos
        private void FRMPRINICIPAL_Load(object sender, EventArgs e)
        {
            FRMSPLASH banner = new FRMSPLASH();
            banner.ShowDialog();
            this.Opacity = 1;
            Estado_1();
        }

        private void BTNPersonas_Click(object sender, EventArgs e)
        {
            foreach (Form s in this.MdiChildren)
            {
                s.Close();
            }
            FRM_Persona_Listar a=new FRM_Persona_Listar();
            a.MdiParent = this;
            a.Show();
        }

        private void BTNUsuario_Click(object sender, EventArgs e)
        {

            foreach (Form s in this.MdiChildren)
            {
                s.Close();
            }
            FRMUsuario_Lista a = new FRMUsuario_Lista();
            a.MdiParent = this;
            a.Show();
        }

        private void BTNIniciarSesion_Click(object sender, EventArgs e)
        {
            FRMIniciar_Sesion a=new FRMIniciar_Sesion();
            a.ShowDialog();
            if (a.actualizarPassword)
            {
                FRMModificar_Password b = new FRMModificar_Password();
                b.usuario = a.usuario;
                b.persona = a.persona;
                b.ShowDialog();
            }

            if (a.loginExitoso)
            {
                //MessageBox.Show("Bienvenido al sisteam "+a.persona.capsnomper);
                
                this.usuario = a.usuario; 
                this.persona = a.persona;
                Estado_2();
            }
        }

        private void BTNIniciarSesionHuellas_Click(object sender, EventArgs e)
        {
            FRMIniciarSesionHuellas a = new FRMIniciarSesionHuellas();
            a.ShowDialog();
            if (a.loginExitoso)
            {
                //MessageBox.Show("Bienvenido al sisteam "+a.persona.capsnomper);
                this.usuario = a.usuario;
                this.persona = a.persona;
                Estado_2();
            }
            
        }
        #endregion
        #region Metodos
        private void Estado_1()
        {
            foreach (Form s in this.MdiChildren)
            {
                s.Close();
            }
            FRMFondo_1 a = new FRMFondo_1();
            a.MdiParent = this;
            a.Show();
            BTNCambiarPassword.Enabled = false;
            BTNCerrarSesion.Enabled = false;
            RTIAdministracion.Visible = false;
            PNLAdministracion.Hide();
        }
        private void Estado_2()
        {
            foreach (Form s in this.MdiChildren)
            {
                s.Close();
            }
            FRMFondo_2 a = new FRMFondo_2();
            BTNIniciarSesion.Enabled = false;
            a.MdiParent = this;
            a.persona = this.persona;
            a.usuario = this.usuario;
            a.Show();
            BTNCambiarPassword.Enabled = true;
            BTNCerrarSesion.Enabled = true;
            //RTIAdministracion.Enabled = true;
            PNLAdministracion.Show();
            RTIAdministracion.Visible = true;
        }
        #endregion

        private void BTNCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la sesión actual?", "Validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Estado_1();
                BTNIniciarSesion.Enabled = true;
            }
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del sistema?", "Validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
