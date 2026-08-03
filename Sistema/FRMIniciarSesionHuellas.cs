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
        #endregion

        #region Constructor
        public FRMIniciarSesionHuellas()
        {
            InitializeComponent();
        }
        #endregion

        private void VCHuella_OnComplete(object Control, DPFP.FeatureSet FeatureSet, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            MessageBox.Show("Huella capturada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
