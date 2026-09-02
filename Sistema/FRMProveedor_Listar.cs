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
    public partial class FRMProveedor_Listar : DevComponents.DotNetBar.OfficeForm
    {

        #region Variables
        private aprovee proveedor = new aprovee();
        private List<aprovee> lista_proveedores = new List<aprovee>();
        #endregion
        #region Constructor

        public FRMProveedor_Listar()
        {
            InitializeComponent();
        }
        #endregion
        #region Metodos
        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista_proveedores.Clear();
            lista_proveedores = proveedor.Lista("capvrazsoc like '%" + TXTFiltrar.Text + "%' limit " +
                                           IINFilas.Value.ToString()
                                           );
            foreach (aprovee a in lista_proveedores)
            {
                DTGLista.Rows.Add();
                DTGLista[0, DTGLista.Rows.Count - 1].Value = a.papvcodpro;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = a.capvrazsoc;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = a.capvnuidtr;
                DTGLista[3, DTGLista.Rows.Count - 1].Value = a.capvestpro;

            }

        }
        #endregion

        #region Eventos

        #endregion

        private void FRMProveedor_Listar_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ActualizarGrid();
        }

        private void BTNNuevoProveedor_Click(object sender, EventArgs e)
        {
            FRMProveedor_Registrar a = new FRMProveedor_Registrar();

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
                    FRMProveedor_Registrar F1 = new FRMProveedor_Registrar();
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

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void BTNModificarProveedor_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                FRMProveedor_Registrar F1 = new FRMProveedor_Registrar();
                F1.modificar = true;
                F1.codProMod = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
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
                FRMProveedor_Registrar F1 = new FRMProveedor_Registrar();
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

                proveedor.papvcodpro = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (proveedor.ObtenerDatos())
                {
                    proveedor.capvestpro = true;
                    if (proveedor.Modificar())
                    {
                        MessageBox.Show("Proveedor Habilitado correctamente");
                        ActualizarGrid();
                    }
                }
            }
        }

        private void inhabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (DTGLista.SelectedRows.Count > 0)
            {

                proveedor.papvcodpro = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (proveedor.ObtenerDatos())
                {
                    proveedor.capvestpro = false;
                    if (proveedor.Modificar())
                    {
                        MessageBox.Show("Proveedor Inhabilitado correctamente");
                        ActualizarGrid();
                    }
                }
            }
        }

        private void CMSMenu_Opening(object sender, CancelEventArgs e)
        {
            proveedor.papvcodpro = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
            if (proveedor.ObtenerDatos())
            {

                if (proveedor.capvestpro)
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
