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
    public partial class FRMProducto_Listar : DevComponents.DotNetBar.OfficeForm
    {
        #region Variables
        private lproduc lproductos = new lproduc();
        private aproduc producto = new aproduc();
        private List<lproduc> lista_productos = new List<lproduc>();
        #endregion

        #region Constructor
        public FRMProducto_Listar()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista_productos.Clear();
            lista_productos = lproductos.Lista("(capdnompro like '%" + TXTFiltrar.Text + "%') limit " +
                                           IINFilas.Value.ToString()
                                           );
            foreach (lproduc a in lista_productos)
            {
                //modificar a la tabla datagrid de listar usuarios
                DTGLista.Rows.Add();
                DTGLista[0, DTGLista.Rows.Count - 1].Value = a.papdcodpro;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = a.capdnompro;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = a.cacenomcat;
                DTGLista[3, DTGLista.Rows.Count - 1].Value = a.capdmodpro;
                DTGLista[4, DTGLista.Rows.Count - 1].Value = a.capdmarpro;
                DTGLista[5, DTGLista.Rows.Count - 1].Value = a.capdtalpro;
                DTGLista[6, DTGLista.Rows.Count - 1].Value = a.capdstopro;
                DTGLista[7, DTGLista.Rows.Count - 1].Value = a.capdprvepr;
                DTGLista[8, DTGLista.Rows.Count - 1].Value = a.capdestpro;



            }
        #endregion

            #region Eventos

            #endregion


        }

        private void FRMProductoListar_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ActualizarGrid();
        }

        private void BTNNuevaCategoria_Click(object sender, EventArgs e)
        {
            FRMProducto_Registrar a = new FRMProducto_Registrar();

            a.ShowDialog();
            if (a.actualizar)
            {
                ActualizarGrid();
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
                FRMProducto_Registrar F1 = new FRMProducto_Registrar();
                F1.modificar = true;
                F1.codProMod = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
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

                producto.papdcodpro = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (producto.ObtenerDatos())
                {
                    producto.capdestpro = true;
                    if (producto.Modificar())
                    {
                        MessageBox.Show("Producto habilitado correctamente");
                        ActualizarGrid();
                    }
                }
            }
        }

        private void inhabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (DTGLista.SelectedRows.Count > 0)
            {

                producto.papdcodpro = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (producto.ObtenerDatos())
                {
                    producto.capdestpro = false;
                    if (producto.Modificar())
                    {
                        MessageBox.Show("Producto inhabilitado correctamente");
                        ActualizarGrid();
                    }
                }
            }
        }

        private void CMSMenu_Opening(object sender, CancelEventArgs e)
        {
            producto.papdcodpro = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
            if (producto.ObtenerDatos())
            {

                if (producto.capdestpro)
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
            if (e.RowIndex >= 0)
            {
                if (DTGLista.SelectedRows.Count > 0)
                {
                    FRMProducto_Registrar F1 = new FRMProducto_Registrar();
                    F1.modificar = true;
                    F1.codProMod = DTGLista[0, e.RowIndex].Value.ToString();
                    F1.ShowDialog();
                    if (F1.actualizar)
                    {
                        ActualizarGrid();
                    }
                }
            }
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                FRMProducto_Registrar F1 = new FRMProducto_Registrar();
                F1.modificar = true;
                F1.codProMod = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                F1.ShowDialog();
                if (F1.actualizar)
                {
                    ActualizarGrid();
                }
            }
        }

        private void TXTFiltrar_Enter(object sender, EventArgs e)
        {
            TXTFiltrar.SelectAll();
        }
    }
}
