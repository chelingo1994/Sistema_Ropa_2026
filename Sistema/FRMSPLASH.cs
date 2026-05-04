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
    public partial class FRMSPLASH : Form
    {
        bool bandera = false;
        public FRMSPLASH()
        {
            InitializeComponent();
        }

        private void FRMRELOJ_Tick(object sender, EventArgs e)
        {
            if (!bandera && this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            if ( this.Opacity==1)
            {
                bandera = true;
            }
            if (bandera && this.Opacity>0)
            {
                this.Opacity -= 0.05;
            }
            if (bandera && this.Opacity==0)
            {
                this.Close();
            }
        }

        private void FRMSPLASH_Load(object sender, EventArgs e)
        {
          FRMRELOJ.Enabled = true;
        }
    }
}
