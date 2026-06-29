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
    public partial class FRMUsuario_Lista : DevComponents.DotNetBar.OfficeForm
    {
        #region variables
        private lusuari usuario = new lusuari();
        private List<lusuari> lista_usuarios = new List<lusuari>();
        #endregion

        #region Constructor
        public FRMUsuario_Lista()
        {
            InitializeComponent();
        }
        #endregion
        private void FRMUsuario_Lista_Load(object sender, EventArgs e)
        {

        }

        private void BTNNuevoUsuario_Click(object sender, EventArgs e)
        {
            FRMUsuario_Registrar a = new FRMUsuario_Registrar();
            a.Show();
        }

        #region Metodos
        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista_usuarios.Clear();
            lista_usuarios = usuario.Lista("capsnumcid like '%" + TXTFiltrar.Text + "%' or " +
                                           "capsapepat like '%" + TXTFiltrar.Text + "%' or " +
                                           "capsapemat like '%" + TXTFiltrar.Text + "%' or " +
                                           "capsnomper like '%" + TXTFiltrar.Text + "%' limit " +
                                           IINFilas.Value.ToString()
                                           );
            foreach (lusuari a in lista_usuarios)
            {
                //modificar a la tabla datagrid de listar usuarios
                DTGLista.Rows.Add();
                DTGLista[0, DTGLista.Rows.Count - 1].Value = a.papscodper;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = a.capsnumcid;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = a.capsnomper;
                DTGLista[3, DTGLista.Rows.Count - 1].Value = a.capsapepat;
                DTGLista[4, DTGLista.Rows.Count - 1].Value = a.capsapemat;
                DTGLista[5, DTGLista.Rows.Count - 1].Value = a.capsfecnac;
                DTGLista[6, DTGLista.Rows.Count - 1].Value = a.capsnumcel;
                if (a.capssexper)
                {
                    DTGLista[7, DTGLista.Rows.Count - 1].Value = "M";
                }
                else
                {
                    DTGLista[7, DTGLista.Rows.Count - 1].Value = "F";
                }

                DTGLista[8, DTGLista.Rows.Count - 1].Value = a.capsestper;

            }

        }
        #endregion
    }
}
