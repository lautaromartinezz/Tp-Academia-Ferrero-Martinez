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
    public partial class ModuloLista : Form
    {
        public ModuloLista()
        {
            InitializeComponent();
            LoadAllModulosAsync();
        }

        private void EditarModulo_Click(object sender, EventArgs e)
        {
            try
            {
                ModuloDetalle moduloDetalle = new ModuloDetalle();

                moduloDetalle.Curso = this.GetModuloSelected();
                moduloDetalle.Mode = FormMode.Update;

                moduloDetalle.ShowDialog();

                this.LoadAllModulosAsync();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private ModuloDTO GetModuloSelected()
        {
            ModuloDTO modulo = (ModuloDTO)ModuloDataGridView.SelectedRows[0].DataBoundItem;

            return modulo;

        }

        private async void LoadAllModulosAsync()
        {
            //this.ModuloDataGridView.DataSource = null;
            this.ModuloDataGridView.DataSource = await ModuloAPIClient.GetAllAsync();
            try
            {
                if (this.ModuloDataGridView.Rows.Count > 0)
                {
                    this.ModuloDataGridView.Rows[0].Selected = true;
                    this.EditarModulo.Enabled = true;
                    this.AgregarButton.Enabled = true;
                }
                else
                {
                    this.EditarModulo.Enabled = false;
                    this.AgregarButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.EditarModulo.Enabled = false;
                this.AgregarButton.Enabled = false;
            }

        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            ModuloDetalle moduloDetalle = new ModuloDetalle();

            moduloDetalle.Mode = FormMode.Add;
            moduloDetalle.Curso = new ModuloDTO();

            moduloDetalle.ShowDialog();

            this.LoadAllModulosAsync();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            try{ModuloAPIClient.DeleteAsync(this.GetModuloSelected().Id);

                this.LoadAllModulosAsync();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
