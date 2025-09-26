using DTOs;
using API.Clients;

namespace WindowsForms
{
    public partial class MateriaLista : Form
    {
        public MateriaLista()
        {            
            InitializeComponent();
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            MateriaDetalle materiaDetalle = new MateriaDetalle();

            MateriaDTO materiaNuevo = new MateriaDTO();

            materiaDetalle.Mode = FormMode.Add;
            materiaDetalle.Materia = materiaNuevo;

            materiaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                MateriaDetalle materiaDetalle = new MateriaDetalle();
               
                int id = this.SelectedItem().Id;

                MateriaDTO materia = await MateriaAPIClient.GetAsync(id);

                materiaDetalle.Mode = FormMode.Update;
                materiaDetalle.Materia = materia;

                materiaDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar materia para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {

            try
            {
                int id = this.SelectedItem().Id;
                
                var result = MessageBox.Show($"¿Está seguro que desea eliminar el materia con Id {id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    await MateriaAPIClient.DeleteAsync(id);
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
                this.materiaDataGridView.DataSource = null;
                this.materiaDataGridView.DataSource = await MateriaAPIClient.GetAllAsync();

                if (this.materiaDataGridView.Rows.Count > 0)
                {
                    this.materiaDataGridView.Rows[0].Selected = true;
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
                MessageBox.Show($"Error al cargar la lista de materias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private MateriaDTO SelectedItem()
        {
            MateriaDTO materia;

            materia = (MateriaDTO)materiaDataGridView.SelectedRows[0].DataBoundItem;

            return materia;
        }


    }
}
