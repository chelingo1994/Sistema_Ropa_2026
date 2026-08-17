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
                else {
                    DTGLista[7, DTGLista.Rows.Count - 1].Value = "F";
                }
                
                DTGLista[8, DTGLista.Rows.Count - 1].Value = a.capsestper;
                
            }

        }
        #endregion

        #region Eventos

        private void FRM_Persona_Listar_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            ActualizarGrid();
        }

        private void BTNNuevo_Click(object sender, EventArgs e)
        {
            FRM_Persona_Registrar a = new FRM_Persona_Registrar();


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

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void inhabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (DTGLista.SelectedRows.Count > 0)
            {

                persona.papscodper = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (persona.ObtenerDatos())
                {
                    persona.capsestper = false;
                    if (persona.Modificar())
                    {
                        MessageBox.Show("Persona Inhabilitada correctamente");
                        ActualizarGrid();
                    }
                }
            }
        }

        private void habilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {

                persona.papscodper = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (persona.ObtenerDatos())
                {
                    persona.capsestper = true;
                    if (persona.Modificar())
                    {
                        MessageBox.Show("Persona habilitada correctamente");
                        ActualizarGrid();
                    }
                }
            }
        }

        private void CMSMenu_Opening(object sender, CancelEventArgs e)
        {
            persona.papscodper = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
            if (persona.ObtenerDatos())
            {

                if (persona.capsestper)
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

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void TXTFiltrar_Enter(object sender, EventArgs e)
        {
            TXTFiltrar.SelectAll();
        }

        #endregion


    }
}
