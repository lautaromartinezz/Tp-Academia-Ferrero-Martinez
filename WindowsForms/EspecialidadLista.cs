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
    public partial class EspecialidadLista : Form
    {
        public EspecialidadLista()
        {
            InitializeComponent();
        }

        private void Especialidad_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            EspecialidadDetalle especialidadDetalle = new EspecialidadDetalle();

            EspecialidadDTO especialidadNuevo = new EspecialidadDTO() { };

            especialidadDetalle.Mode = FormMode.Add;
            especialidadDetalle.Especialidad = especialidadNuevo;

            especialidadDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                EspecialidadDetalle especialidadDetalle = new EspecialidadDetalle();

                int id = this.SelectedItem().Id;

                EspecialidadDTO especialidad = await EspecialidadAPIClient.GetAsync(id);

                especialidadDetalle.Mode = FormMode.Update;
                especialidadDetalle.Especialidad = especialidad;

                especialidadDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el especialidad para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {

            try
            {
                int id = this.SelectedItem().Id;

                var result = MessageBox.Show($"¿Está seguro que desea eliminar el especialidad con Id {id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await EspecialidadAPIClient.DeleteAsync(id);
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
                this.especialidadDataGridView.DataSource = null;
                this.especialidadDataGridView.DataSource = await EspecialidadAPIClient.GetAllAsync();

                if (this.especialidadDataGridView.Rows.Count > 0)
                {
                    this.especialidadDataGridView.Rows[0].Selected = true;
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
                MessageBox.Show($"Error al cargar la lista de especialidads: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private EspecialidadDTO SelectedItem()
        {
            EspecialidadDTO especialidad;

            especialidad = (EspecialidadDTO)especialidadDataGridView.SelectedRows[0].DataBoundItem;

            return especialidad;
        }

    }
}
