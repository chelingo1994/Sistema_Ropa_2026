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
    public partial class FRMCategoris_Listar : DevComponents.DotNetBar.OfficeForm
    {
        #region Variables
        private acatego categoria = new acatego();
        private List<acatego> lista_categorias = new List<acatego>();
        #endregion

        #region Constructor

        public FRMCategoris_Listar()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista_categorias.Clear();
            lista_categorias = categoria.Lista("cacenomcat like '%" + TXTFiltrar.Text + "%' limit " +
                                           IINFilas.Value.ToString()
                                           );
            foreach (acatego a in lista_categorias)
            {
                DTGLista.Rows.Add();
                DTGLista[0, DTGLista.Rows.Count - 1].Value = a.pacecodcat;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = a.cacenomcat;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = a.caceestcat;

            }

        }
        #endregion

        #region Eventos
        #endregion

        private void FRMCategorisListar_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ActualizarGrid();
        }

        private void BTNNuevaCategoria_Click(object sender, EventArgs e)
        {

            FRMCategoriaRegistrar a = new FRMCategoriaRegistrar();


            a.modificar = false;
            a.ShowDialog();
            if (a.actualizar)
            {
                ActualizarGrid();
            }
        }

        private void DTGLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (DTGLista.SelectedRows.Count > 0)
                {
                    FRMCategoriaRegistrar F1 = new FRMCategoriaRegistrar();
                    F1.modificar = true;
                    F1.codCatMod = DTGLista[0, e.RowIndex].Value.ToString();
                    F1.ShowDialog();
                    if (F1.actualizar)
                    {
                        ActualizarGrid();
                    }
                }
            }
        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                FRMCategoriaRegistrar F1 = new FRMCategoriaRegistrar();
                F1.modificar = true;
                F1.codCatMod = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                F1.ShowDialog();
                if (F1.actualizar)
                {
                    ActualizarGrid();
                }
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                FRMCategoriaRegistrar F1 = new FRMCategoriaRegistrar();
                F1.modificar = true;
                F1.codCatMod = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                F1.ShowDialog();
                if (F1.actualizar)
                {
                    ActualizarGrid();
                }
            }
        }

        private void habilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (DTGLista.SelectedRows.Count > 0)
            {

                categoria.pacecodcat = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (categoria.ObtenerDatos())
                {
                    categoria.caceestcat = true;
                    if (categoria.Modificar())
                    {
                        MessageBox.Show("Categoria  Habilitada correctamente");
                        ActualizarGrid();
                    }
                }
            }
        }

        private void inhabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (DTGLista.SelectedRows.Count > 0)
            {

                categoria.pacecodcat = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (categoria.ObtenerDatos())
                {
                    categoria.caceestcat = false;
                    if (categoria.Modificar())
                    {
                        MessageBox.Show("Categoria  Inhabilitada correctamente");
                        ActualizarGrid();
                    }
                }
            }
        }

        private void CMSMenu_Opening(object sender, CancelEventArgs e)
        {
            categoria.pacecodcat = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
            if (categoria.ObtenerDatos())
            {

                if (categoria.caceestcat)
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

        private void TXTFiltrar_Enter(object sender, EventArgs e)
        {
            TXTFiltrar.SelectAll();
        }
    }
}
