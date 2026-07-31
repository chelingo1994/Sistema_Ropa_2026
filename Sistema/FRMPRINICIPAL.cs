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
        public FRMPRINICIPAL()
        {
            InitializeComponent();
        }

        private void FRMPRINICIPAL_Load(object sender, EventArgs e)
        {
            FRMSPLASH banner = new FRMSPLASH();
            banner.ShowDialog();
            this.Opacity = 1;
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
                MessageBox.Show("Bienvenido al sisteam "+a.persona.capsnomper);
            }
        }
    }
}
