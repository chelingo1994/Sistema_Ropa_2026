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
        private lusuari listausuario = new lusuari();
        private ausuari usuario=new ausuari();
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

            this.WindowState = FormWindowState.Maximized;
            ActualizarGrid();
        }

        private void BTNNuevoUsuario_Click(object sender, EventArgs e)
        {
            FRMUsuario_Registrar a = new FRMUsuario_Registrar();
            
            a.ShowDialog();
            if (a.actualizar)
            {
                ActualizarGrid();
            }
        }

        #region Metodos
        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista_usuarios.Clear();
            lista_usuarios = listausuario.Lista("(capsnumcid like '%" + TXTFiltrar.Text + "%' or " +
                                           "capsapepat like '%" + TXTFiltrar.Text + "%' or " +
                                           "capsapemat like '%" + TXTFiltrar.Text + "%' or " +
                                           "capsnomper like '%" + TXTFiltrar.Text + "%') limit " +
                                           IINFilas.Value.ToString()
                                           );
            foreach (lusuari a in lista_usuarios)
            {
                //modificar a la tabla datagrid de listar usuarios
                DTGLista.Rows.Add();
                DTGLista[0, DTGLista.Rows.Count - 1].Value = a.pauacodusu;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = a.cauaestusu;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = a.capsnumcid;
                DTGLista[3, DTGLista.Rows.Count - 1].Value = a.capsapepat+" "+a.capsapemat+" "+a.capsnomper;
                DTGLista[4, DTGLista.Rows.Count - 1].Value = a.cauanomlog;
               
              

            }

        }
        

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                FRMUsuario_Registrar F1 = new FRMUsuario_Registrar();
                //F1.modificar = true;
                //F1.codPerMod = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                F1.ShowDialog();
                /*if (F1.actualizar)
                {
                    ActualizarGrid();
                }*/
            }
        }

        private void habilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (DTGLista.SelectedRows.Count > 0)
            {

                usuario.pauacodusu = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (usuario.ObtenerDatos())
                {
                    usuario.cauaestusu = true;
                    if (usuario.Modificar())
                    {
                        MessageBox.Show("Usuario habilitado correctamente");
                        ActualizarGrid();
                    }
                }
            }
        }

        private void inhabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (DTGLista.SelectedRows.Count > 0)
            {

                usuario.pauacodusu = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (usuario.ObtenerDatos())
                {
                    usuario.cauaestusu = false;
                    if (usuario.Modificar())
                    {
                        MessageBox.Show("Usuario Inhabilitada correctamente");
                        ActualizarGrid();
                    }
                }
            }
        }

        private void CMSMenu_Opening(object sender, CancelEventArgs e)
        {
            usuario.pauacodusu = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
            if (usuario.ObtenerDatos())
            {

                if (usuario.cauaestusu)
                {
                    CMSMenu.Items[2].Visible = false;
                    CMSMenu.Items[1].Visible = true;
                }
                else
                {
                    CMSMenu.Items[2].Visible = true;
                    CMSMenu.Items[1].Visible = false;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void DTGLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                if (DTGLista.SelectedRows.Count > 0)
                {
                    FRMUsuario_Registrar F1 = new FRMUsuario_Registrar();
                    F1.modificar = true;
                    F1.codUsuMod = DTGLista[0,e.RowIndex].Value.ToString();
                    F1.ShowDialog();
                    if (F1.actualizar)
                    {
                        ActualizarGrid();
                    }
                }
            }
            
        }

        private void TXTFiltrar_Enter(object sender, EventArgs e)
        {
            TXTFiltrar.SelectAll();
        }
        #endregion
    }
}
