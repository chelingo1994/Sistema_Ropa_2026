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
    public partial class FRM_Persona_Listar : DevComponents.DotNetBar.OfficeForm
    {
        #region Variables
        private aperson persona = new aperson();
        private List<aperson> lista_personas = new List<aperson>();
        #endregion
        public FRM_Persona_Listar()
        {
            InitializeComponent();
        }

        private void FRM_Persona_Listar_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            ActualizarGrid();
        }

        private void BTNNuevo_Click(object sender, EventArgs e)
        {
            FRM_Persona_Registrar a= new FRM_Persona_Registrar();
            a.ShowDialog();
       
            a.modificar = false;
            a.ShowDialog();
            if (a.actualizar)
            {
                ActualizarGrid();
            }
        }

        #region Métodos
        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista_personas.Clear();
            lista_personas = persona.Lista("capsnumcid like '%" + TXTFiltrar.Text + "%' or " +
                                           "capsapepat like '%" + TXTFiltrar.Text + "%' or " +
                                           "capsapemat like '%" + TXTFiltrar.Text + "%' or " +
                                           "capsnomper like '%" + TXTFiltrar.Text + "%' limit " +
                                           IINFilas.Value.ToString()
                                           );
            foreach (aperson a in lista_personas)
            {
                DTGLista.Rows.Add();
                
                DTGLista[0, DTGLista.Rows.Count - 1].Value = a.capsnumcid;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = a.capsnomper;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = a.capsapepat;
                DTGLista[3, DTGLista.Rows.Count - 1].Value = a.capsapemat;
                DTGLista[4, DTGLista.Rows.Count - 1].Value = a.capsfecnac;
                DTGLista[5, DTGLista.Rows.Count - 1].Value = a.capsnumcel;
                if (a.capssexper)
                {
                    DTGLista[6, DTGLista.Rows.Count - 1].Value = "M";
                }
                else {
                    DTGLista[6, DTGLista.Rows.Count - 1].Value = "F";
                }
                
                DTGLista[7, DTGLista.Rows.Count - 1].Value = a.capsestper;
                
            }

        }
        #endregion

        #region Eventos
        

        private void FRMPersona_Lista_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
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

        private void BTNFiltrar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        #endregion

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                FRM_Persona_Registrar F1 = new FRM_Persona_Registrar();
                F1.modificar = true;
                F1.codPerMod = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                F1.ShowDialog();
                if (F1.actualizar)
                {
                    ActualizarGrid();
                }
            }
        }
    }
}
