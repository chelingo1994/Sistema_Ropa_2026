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
    public partial class FRMPersona_Buscar : DevComponents.DotNetBar.OfficeForm
    {

        #region variables
        public aperson persona = new aperson();
        private List<aperson> lista_personas = new List<aperson>();
        public bool seleccionadorOK=false;
        #endregion

        #region Constructor
        public FRMPersona_Buscar()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos

        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista_personas.Clear();
            String soloUsuario = "papscodper not in (select papscodper from aperson,ausuari where papscodper=fauacodper order by papscodper)";
            lista_personas = persona.Lista(soloUsuario + " and (capsnumcid like '%" + TXTFiltrar.Text + "%' or " +
                                           "capsapepat like '%" + TXTFiltrar.Text + "%' or " +
                                           "capsapemat like '%" + TXTFiltrar.Text + "%' or " +
                                           "capsnomper like '%" + TXTFiltrar.Text + "%') and capsestper=true " + 
                                           "limit " +
                                           IINFilas.Value.ToString()
                                           );
            foreach (aperson a in lista_personas)
            {
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

        private void FRMPersona_Buscar_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void BTNBuscar_Enter(object sender, EventArgs e)
        {
            TXTFiltrar.SelectAll();
        }

        

        private void BTNSeleccionarPersona_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count==1)
            {
                persona.papscodper = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (persona.ObtenerDatos())
                {
                    seleccionadorOK = true;
                    this.Close();
                }
            }
        }

        private void DTGLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (DTGLista.SelectedRows.Count > 0)
                {
                    FRM_Persona_Registrar F1 = new FRM_Persona_Registrar();
                    F1.modificar = true;
                    F1.codPerMod = DTGLista[0, e.RowIndex].Value.ToString();
                    F1.ShowDialog();
                    if (F1.actualizar)
                    {
                        ActualizarGrid();
                    }
                }
            }
        }

        private void BTNAgregarPersona_Click(object sender, EventArgs e)
        {
            FRM_Persona_Registrar a=new FRM_Persona_Registrar();
            a.ShowDialog();
            if (a.actualizar)
            {
                ActualizarGrid();
            }
        }
    }
}
