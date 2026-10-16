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
    public partial class FRMProducto_Buscar : DevComponents.DotNetBar.OfficeForm
    {
        #region variables
        public aproduc producto = new aproduc();
        private List<aproduc> lista = new List<aproduc>();
        public bool seleccionadoOk = false;
        public String condicion = "";
        #endregion
        public FRMProducto_Buscar()
        {
            InitializeComponent();
        }
        #region Metodos

        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista.Clear();
            lista = producto.Lista("(capdmodpro like '%" + TXTFiltrar.Text + "%' or " +
                                    "capdnompro like '%" + TXTFiltrar.Text + "%' or " +
                                    "capdmarpro like '%" + TXTFiltrar.Text + "%') and capdestpro=true limit " +
                                    IINFilas.Value.ToString()
                                    );

            foreach (aproduc a in lista)
            {
                DTGLista.Rows.Add();

                if (DTGLista.Rows.Count % 2 == 0)
                {
                    DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Gainsboro;
                }

                DTGLista[0, DTGLista.Rows.Count - 1].Value = a.papdcodpro;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = a.capdnompro;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = a.capdmodpro;
                DTGLista[3, DTGLista.Rows.Count - 1].Value = a.capdmarpro;
                DTGLista[4, DTGLista.Rows.Count - 1].Value = a.capdtalpro;
                DTGLista[5, DTGLista.Rows.Count - 1].Value = a.capdmatpro;
                DTGLista[6, DTGLista.Rows.Count - 1].Value = a.capdcolpro;
                DTGLista[7, DTGLista.Rows.Count - 1].Value = a.capdprvepr;

            }

        }
        #endregion

        private void FRMProducto_Buscar_Load(object sender, EventArgs e)
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

        private void BTNAgregarProducto_Click(object sender, EventArgs e)
        {
            FRMProveedor_Registrar a = new FRMProveedor_Registrar();
            a.ShowDialog();
            if (a.actualizar)
            {
                ActualizarGrid();
            }
        }

        private void BTNSeleccionarProducto_Click(object sender, EventArgs e)
        {

            if (DTGLista.SelectedRows.Count == 1)
            {
                producto.papdcodpro = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (producto.ObtenerDatos())
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
                producto.papdcodpro = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (producto.ObtenerDatos())
                {
                    seleccionadoOk = true;
                    this.Close();
                }
            }
        }
    }
}
