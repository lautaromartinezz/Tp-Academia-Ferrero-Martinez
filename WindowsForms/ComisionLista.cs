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
    public partial class ComisionLista : Form
    {
        public ComisionLista()
        {
            InitializeComponent();
        }
        private void Comision_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            ComisionDetalle comisionDetalle = new ComisionDetalle();

            ComisionDTO comNueva = new ComisionDTO() { };

            comisionDetalle.Mode = FormMode.Add;
            comisionDetalle.Comision = comNueva;

            comisionDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                ComisionDetalle comisionDetalle = new ComisionDetalle();

                int id = this.SelectedItem().Id;

                ComisionDTO comision = await ComisionAPIClient.GetAsync(id);

                comisionDetalle.Mode = FormMode.Update;
                comisionDetalle.Comision = comision;

                comisionDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la comision para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {

            try
            {
                int id = this.SelectedItem().Id;

                var result = MessageBox.Show($"¿Está seguro que desea eliminar la comision con Id {id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await ComisionAPIClient.DeleteAsync(id);
                    this.GetAllAndLoad();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"111Error al eliminar comision: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetAllAndLoad()
        {
            try
            {
                this.comDataGridView.DataSource = null;
                this.comDataGridView.DataSource = await ComisionAPIClient.GetAllAsync();

                if (this.comDataGridView.Rows.Count > 0)
                {
                    this.comDataGridView.Rows[0].Selected = true;
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
                MessageBox.Show($"Error al cargar la lista de comisions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private ComisionDTO SelectedItem()
        {
            ComisionDTO comision;

            comision = (ComisionDTO)comDataGridView.SelectedRows[0].DataBoundItem;

            return comision;
        }
    }
}
