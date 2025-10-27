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
    public partial class InscripcionLista : Form
    {
        public InscripcionLista()
        {
            InitializeComponent();
        }

        private void Inscripcion_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            InscripcionDetalle inscripcionDetalle = new InscripcionDetalle();

            InscripcionDTO inscripcionNuevo = new InscripcionDTO();

            inscripcionDetalle.Mode = FormMode.Add;
            inscripcionDetalle.Inscripcion = inscripcionNuevo;

            inscripcionDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                InscripcionDetalle inscripcionDetalle = new InscripcionDetalle();

                int id = this.SelectedItem().Id;

                InscripcionDTO inscripcion = await InscripcionAPIClient.GetAsync(id);

                inscripcionDetalle.Mode = FormMode.Update;
                inscripcionDetalle.Inscripcion = inscripcion;

                inscripcionDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el inscripcion para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {

            try
            {
                int id = this.SelectedItem().Id;

                var result = MessageBox.Show($"¿Está seguro que desea eliminar el inscripcion con Id {id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await InscripcionAPIClient.DeleteAsync(id);
                    this.GetAllAndLoad();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"111Error al eliminar materia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetAllAndLoad()
        {
            try
            {
                this.inscripcionDataGridView.DataSource = null;
                this.inscripcionDataGridView.DataSource = await InscripcionAPIClient.GetAllAsync();

                if (this.inscripcionDataGridView.Rows.Count > 0)
                {
                    this.inscripcionDataGridView.Rows[0].Selected = true;
                    this.eliminarButton.Enabled = true;
                    this.modificarButton.Enabled = true;
                }
                else
                {
                    this.eliminarButton.Enabled = false;
                    this.modificarButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de inscripcions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.eliminarButton.Enabled = false;
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
