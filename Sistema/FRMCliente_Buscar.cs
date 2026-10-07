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
    public partial class FRMCliente_Buscar : DevComponents.DotNetBar.OfficeForm
    {
        #region variables
        public aclient cliente = new aclient();
        private List<aclient> lista = new List<aclient>();
        public bool seleccionadoOk = false;
        public String condicion = "";
        #endregion
        public FRMCliente_Buscar()
        {
            InitializeComponent();
        }
        #region Metodos

        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista.Clear();
            lista = cliente.Lista("(cacerazsoc like '%" + TXTFiltrar.Text + "%' or " +
                                    "cacedirecc like '%" + TXTFiltrar.Text + "%' or " +
                                    "cacetelefo like '%" + TXTFiltrar.Text + "%') and caceestcli=true limit " +
                                    IINFilas.Value.ToString()
                                    );

            foreach (aclient a in lista)
            {
                DTGLista.Rows.Add();

                if (DTGLista.Rows.Count % 2 == 0)
                {
                    DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Gainsboro;
                }

                DTGLista[0, DTGLista.Rows.Count - 1].Value = a.pacecodcli;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = a.cacerazsoc;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = a.cacenuidtr;
                DTGLista[3, DTGLista.Rows.Count - 1].Value = a.cacedirecc;
                DTGLista[4, DTGLista.Rows.Count - 1].Value = a.cacetelefo;

            }

        }
        #endregion
        #region Eventos
        private void FRMCliente_Buscar_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void TXTFiltrar_Enter(object sender, EventArgs e)
        {
            TXTFiltrar.SelectAll();
        }

        private void BTNAgregarPersona_Click(object sender, EventArgs e)
        {
            FRMCliente_Registrar a = new FRMCliente_Registrar();
            a.ShowDialog();
            if (a.actualizar)
            {
                ActualizarGrid();
            }
        }

        private void BTNSeleccionarPersona_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count == 1)
            {
                cliente.pacecodcli = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (cliente.ObtenerDatos())
                {
                    seleccionadoOk = true;
                    this.Close();
                }
            }
        }

        private void DTGLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DTGLista.SelectedRows.Count == 1)
            {
                cliente.pacecodcli = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (cliente.ObtenerDatos())
                {
                    seleccionadoOk = true;
                    this.Close();
                }
            }
        }
        #endregion

    }

        
}

