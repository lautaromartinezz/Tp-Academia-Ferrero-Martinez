using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOs;
using API.Clients;

namespace WindowsForms
{
    public partial class PlanLista : Form
    {
        public PlanLista()
        {
            InitializeComponent();
        }

        private void Planes_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            PlanDetalle planDetalle = new PlanDetalle();

            PlanDTO planNuevo = new PlanDTO();

            planDetalle.Mode = FormMode.Add;
            planDetalle.Plan = planNuevo;

            planDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                PlanDetalle planDetalle = new PlanDetalle();

                int id = this.SelectedItem().Id;

                PlanDTO plan = await PlanAPIClient.GetAsync(id);

                planDetalle.Mode = FormMode.Update;
                planDetalle.Plan = plan;

                planDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el plan para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {

            try
            {
                int id = this.SelectedItem().Id;

                var result = MessageBox.Show($"¿Está seguro que desea eliminar el plan con Id {id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await PlanAPIClient.DeleteAsync(id);
                    this.GetAllAndLoad();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar materia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetAllAndLoad()
        {
            try
            {
                this.planDataGridView.DataSource = null;
                this.planDataGridView.DataSource = await PlanAPIClient.GetAllAsync();

                if (this.planDataGridView.Rows.Count > 0)
                {
                    this.planDataGridView.Rows[0].Selected = true;
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
                MessageBox.Show($"Error al cargar la lista de planes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private PlanDTO SelectedItem()
        {
            PlanDTO plan;

            plan = (PlanDTO)planDataGridView.SelectedRows[0].DataBoundItem;

            return plan;
        }



    }
}
