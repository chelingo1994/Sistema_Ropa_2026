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
    public partial class FRMUsuario_Lista : DevComponents.DotNetBar.OfficeForm
    {
        public FRMUsuario_Lista()
        {
            InitializeComponent();
        }

        private void FRMUsuario_Lista_Load(object sender, EventArgs e)
        {

        }

        private void BTNNuevoUsuario_Click(object sender, EventArgs e)
        {
            FRMUsuario_Registrar a = new FRMUsuario_Registrar();
            a.Show();
        }
    }
}
