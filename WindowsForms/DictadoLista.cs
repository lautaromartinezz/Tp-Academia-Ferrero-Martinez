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
    public partial class DictadoLista : Form
    {
        public DictadoLista()
        {
            InitializeComponent();
        }
        private void Dictado_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            DictadoDetalle dictadoDetalle = new DictadoDetalle();

            DictadoDTO dictadoNuevo = new DictadoDTO();

            dictadoDetalle.Mode = FormMode.Add;
            dictadoDetalle.Dictado = dictadoNuevo;

            dictadoDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                DictadoDetalle dictadoDetalle = new DictadoDetalle();

                int id = this.SelectedItem().Id;

                DictadoDTO dictado = await DictadoAPIClient.GetAsync(id);

                dictadoDetalle.Mode = FormMode.Update;
                dictadoDetalle.Dictado = dictado;

                dictadoDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el dictado para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {

            try
            {
                int id = this.SelectedItem().Id;

                var result = MessageBox.Show($"¿Está seguro que desea eliminar el dictado con Id {id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await DictadoAPIClient.DeleteAsync(id);
                    this.GetAllAndLoad();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"111Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetAllAndLoad()
        {
            try
            {
                this.dictadoDataGridView.DataSource = null;
                this.dictadoDataGridView.DataSource = await DictadoAPIClient.GetAllAsync();

                if (this.dictadoDataGridView.Rows.Count > 0)
                {
                    this.dictadoDataGridView.Rows[0].Selected = true;
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
                MessageBox.Show($"Error al cargar la lista de dictados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
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
