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
    public partial class FRMIniciar_Sesion : DevComponents.DotNetBar.OfficeForm
    {
        #region varialbes
        ausuari usuario =new ausuari();
        #endregion

        

        #region Constructor
        
        public FRMIniciar_Sesion()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        
        private void BTNVerPassword_Click(object sender, EventArgs e)
        {
            if (TXTPassword.PasswordChar=='*')
            {
                TXTPassword.PasswordChar = '\0';
            }
            else
            {
                TXTPassword.PasswordChar = '*';
            }
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Metodos
        #endregion
    }
}
