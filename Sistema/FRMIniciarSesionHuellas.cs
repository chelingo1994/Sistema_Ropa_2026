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
    public partial class FRMIniciarSesionHuellas : DevComponents.DotNetBar.OfficeForm
    {


        #region varialbes
        public ausuari usuario = new ausuari();
        public aperson persona = new aperson();
        public bool loginExitoso = false;
        public bool actualizarPassword = false;
        private lusuari lusuario = new lusuari();
        private List<lusuari> listaUsuarios = new List<lusuari>();
        #endregion

        #region Constructor
        public FRMIniciarSesionHuellas()
        {
            InitializeComponent();
        }
        #endregion

        private void VCHuella_OnComplete(object Control, DPFP.FeatureSet FeatureSet, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            listaUsuarios = lusuario.Lista("cauaestusu=true");
            DPFP.Verification.Verification Ver = new DPFP.Verification.Verification();
            DPFP.Verification.Verification.Result Res = new DPFP.Verification.Verification.Result();
            DPFP.Template T = new DPFP.Template();
            bool ban = false;
            foreach (lusuari u in listaUsuarios)
            {
                if (u.cauanumhu1 > 0)
                {
                    T = new DPFP.Template();
                    T.DeSerialize(Convert.FromBase64String(u.cauacodhu1));
                    Ver.Verify(FeatureSet, T, ref Res);
                    if (Res.Verified)
                    {
                        ban = true;
                        lusuario = u;
                        break;
                    }
                }
                if (u.cauanumhu2 > 0)
                {
                    T = new DPFP.Template();
                    T.DeSerialize(Convert.FromBase64String(u.cauacodhu2));
                    Ver.Verify(FeatureSet, T, ref Res);
                    if (Res.Verified)
                    {
                        ban = true;
                        lusuario = u;
                        break;
                    }
                }
                if (u.cauanumhu3 > 0)
                {
                    T = new DPFP.Template();
                    T.DeSerialize(Convert.FromBase64String(u.cauacodhu3));
                    Ver.Verify(FeatureSet, T, ref Res);
                    if (Res.Verified)
                    {
                        ban = true;
                        lusuario = u;
                        break;
                    }
                }
                if (u.cauanumhu4 > 0)
                {
                    T = new DPFP.Template();
                    T.DeSerialize(Convert.FromBase64String(u.cauacodhu4));
                    Ver.Verify(FeatureSet, T, ref Res);
                    if (Res.Verified)
                    {
                        ban = true;
                        lusuario = u;
                        break;
                    }
                }
                if (ban)
                {
                    MessageBox.Show("Bienvenido " + lusuario.capsnomper +
                                              " " + lusuario.capsapepat +
                                              " " + lusuario.capsapemat, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usuario.pauacodusu = lusuario.pauacodusu;
                    usuario.ObtenerDatos();
                    persona.papscodper = lusuario.papscodper;
                    persona.ObtenerDatos();
                    loginExitoso = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Huella no identificada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
