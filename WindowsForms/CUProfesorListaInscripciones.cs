using API.Clients;
using DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class CUProfesorListaInscripciones : Form
    {
        private int _cursoId;
        public int CursoId { get { return _cursoId; } set { _cursoId = value; } }
        public CUProfesorListaInscripciones()
        {
            InitializeComponent();
        }
        private void Inscripcion_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }



        private async void modificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                InscripcionDetalle inscripcionDetalle = new InscripcionDetalle();

                int id = this.SelectedItem().Id;

                InscripcionDTO inscripcion = await InscripcionAPIClient.GetAsync(id);

                inscripcionDetalle.Mode = FormModeInsc.Profesor;
                inscripcionDetalle.Inscripcion = inscripcion;

                inscripcionDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el inscripcion para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private async void GetAllAndLoad()
        {
            try
            {
                this.inscripcionDataGridView.DataSource = null;
                this.inscripcionDataGridView.DataSource = await InscripcionAPIClient.GetByCursoAsync(CursoId);

                if (this.inscripcionDataGridView.Rows.Count > 0)
                {
                    this.inscripcionDataGridView.Rows[0].Selected = true;
                    this.modificarButton.Enabled = true;
                }
                else
                {
                    this.modificarButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de inscripcions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.modificarButton.Enabled = false;
            }
        }

        private InscripcionDTO SelectedItem()
        {
            InscripcionDTO inscripcion;

            inscripcion = (InscripcionDTO)inscripcionDataGridView.SelectedRows[0].DataBoundItem;

            return inscripcion;
        }
    }
}
