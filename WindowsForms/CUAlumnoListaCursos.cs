using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API.Clients;
using DTOs;

namespace WindowsForms
{
    public partial class CUAlumnoListaCursos : Form
    {
        private string _userId;
        public string UserId { get { return _userId; } set { _userId = value; } }
        public CUAlumnoListaCursos()
        {
            InitializeComponent();
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void crearInscButton_Click(object sender, EventArgs e)
        {
            try
            {
                int idCurso = this.SelectedItem().Id;

                InscripcionDTO dto = new InscripcionDTO
                {
                    IdCurso = idCurso,
                    IdAlumno = int.Parse(this.UserId),
                    Situacion = "Inscripto",
                    Nota = 0
                };

                await InscripcionAPIClient.AddAsync(dto);

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el dictado para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetAllAndLoad()
        {
            try
            {
                this.cursoDataGridView.DataSource = null;
                this.cursoDataGridView.DataSource = await InscripcionAPIClient.GetWithoutInscAsync(int.Parse(UserId));

                if (this.cursoDataGridView.Rows.Count > 0)
                {
                    this.cursoDataGridView.Rows[0].Selected = true;
                    this.inscButton.Enabled = true;
                }
                else
                {
                    this.inscButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de cursos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.inscButton.Enabled = false;
            }
        }

        private CursoDTO SelectedItem()
        {
            CursoDTO curso;

            curso = (CursoDTO)cursoDataGridView.SelectedRows[0].DataBoundItem;

            return curso;
        }

    }
}
