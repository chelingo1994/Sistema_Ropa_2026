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
    public partial class FRMFondo_2 : DevComponents.DotNetBar.OfficeForm
    {
        #region Variables
        public ausuari usuario = new ausuari();
        public aperson persona = new aperson();
        #endregion
        #region Constructor
        public FRMFondo_2()
        {
            InitializeComponent();
        }
        #endregion
        #region Eventos
        private void TMReloj_Tick(object sender, EventArgs e)
        {
            LBFecha.Text = DateTime.Now.ToString("F");
        }

        private void FRMFondo_2_Load(object sender, EventArgs e)
        {
            TMReloj.Enabled = true;
            LBUsuario.Text ="Usuario:"+ 
                            persona.capsnomper+" "+
                            persona.capsapepat+" "+
                            persona.capsapemat;
        }

        private void FRMFondo_2_FormClosed(object sender, FormClosedEventArgs e)
        {
            TMReloj.Enabled = false;
        }
        #endregion
    }
}
