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
    public partial class CUProfesorListaDictados : Form
    {
        private string _userId;
        public string UserId { get { return _userId; } set { _userId = value; } }
        public CUProfesorListaDictados()
        {
            InitializeComponent();
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                CUProfesorListaInscripciones CUProfesorListaInscripciones = new CUProfesorListaInscripciones();

                int id = this.SelectedItem().IdCurso;

                CUProfesorListaInscripciones.CursoId = id;

                CUProfesorListaInscripciones.ShowDialog();

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
                this.dictadoDataGridView.DataSource = null;
                this.dictadoDataGridView.DataSource = await DictadoAPIClient.GetByProfesorAsync(int.Parse(UserId));

                if (this.dictadoDataGridView.Rows.Count > 0)
                {
                    this.dictadoDataGridView.Rows[0].Selected = true;
                    this.verCursoButton.Enabled = true;
                }
                else
                {
                    this.verCursoButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de dictados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.verCursoButton.Enabled = false;
            }
        }

        private DictadoDTO SelectedItem()
        {
            DictadoDTO dictado;

            dictado = (DictadoDTO)dictadoDataGridView.SelectedRows[0].DataBoundItem;

            return dictado;
        }



    }
}

