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
    public partial class FRMCliente_Listar : DevComponents.DotNetBar.OfficeForm
    {
        #region Variables
        private aclient cliente = new aclient();
        private List<aclient> lista_clientes = new List<aclient>();
        #endregion

        #region Constructor
        public FRMCliente_Listar()
        {
            InitializeComponent();
        }
        #endregion


        #region Metodos
        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista_clientes.Clear();
            lista_clientes = cliente.Lista("cacerazsoc like '%" + TXTFiltrar.Text + "%' limit " +
                                           IINFilas.Value.ToString()
                                           );
            foreach (aclient a in lista_clientes)
            {
                DTGLista.Rows.Add();
                DTGLista[0, DTGLista.Rows.Count - 1].Value = a.pacecodcli;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = a.cacerazsoc;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = a.cacenuidtr;
                DTGLista[3, DTGLista.Rows.Count - 1].Value = a.caceestcli;

            }

        }
        #endregion

        #region Eventos

        #endregion
        private void BTNNuevoCliente_Click(object sender, EventArgs e)
        {
            FRMCliente_Registrar a = new FRMCliente_Registrar();

            a.modificar = false;
            a.ShowDialog();
            if (a.actualizar)
            {
                ActualizarGrid();
            }
        }

        private void EPNLOpciones_Click(object sender, EventArgs e)
        {

        }

        private void FRMCliente_Listar_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ActualizarGrid();
        }

        private void DTGLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (DTGLista.SelectedRows.Count > 0)
                {
                    FRMCliente_Registrar F1 = new FRMCliente_Registrar();
                    F1.modificar = true;
                    F1.codCliMod = DTGLista[0, e.RowIndex].Value.ToString();
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

        private void BTNClienteModificar_Click(object sender, EventArgs e)
        {

            if (DTGLista.SelectedRows.Count > 0)
            {
                FRMCliente_Registrar F1 = new FRMCliente_Registrar();
                F1.modificar = true;
                F1.codCliMod = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
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
                FRMCliente_Registrar F1 = new FRMCliente_Registrar();
                F1.modificar = true;
                F1.codCliMod = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
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

                cliente.pacecodcli = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (cliente.ObtenerDatos())
                {
                    cliente.caceestcli = true;
                    if (cliente.Modificar())
                    {
                        MessageBox.Show("Cliente Habilitado correctamente");
                        ActualizarGrid();
                    }
                }
            }
        }

        private void inhabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {

                cliente.pacecodcli = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (cliente.ObtenerDatos())
                {
                    cliente.caceestcli = false;
                    if (cliente.Modificar())
                    {
                        MessageBox.Show("Cliente Inhabilitado correctamente");
                        ActualizarGrid();
                    }
                }
            }
        }

        private void CMSMenu_Opening(object sender, CancelEventArgs e)
        {
            cliente.pacecodcli = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
            if (cliente.ObtenerDatos())
            {

                if (cliente.caceestcli)
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
