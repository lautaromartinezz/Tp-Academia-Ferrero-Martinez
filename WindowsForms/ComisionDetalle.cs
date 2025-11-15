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
    public partial class ComisionDetalle : Form
    {

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private ComisionDTO comision;
        private FormMode mode;

        public ComisionDTO Comision
        {
            get { return comision; }
            set
            {
                comision = value;
            }
        }

        public FormMode Mode
        {
            get
            {
                return mode;
            }
            set
            {
                SetFormMode(value);
            }
        }

        public ComisionDetalle()
        {
            InitializeComponent();
            Mode = FormMode.Add;
        }

        private async Task LoadComboBox()
        {
            try
            {
                var planes = await PlanAPIClient.GetAllAsync();
                planComboBox1.DataSource = planes;
                planComboBox1.DisplayMember = "Descripcion";
                planComboBox1.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los planes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateComision())
            {
                try
                {
                    this.Comision.AnioEspecialidad = int.Parse(anioEspTextBox.Text);
                    this.Comision.Descripcion = (descTextBox.Text);
                    this.Comision.IdPlan = (int)planComboBox1.SelectedValue;

                    //El Detalle se esta llevando la responsabilidad de llamar al servicio
                    //pero tal vez deberia ser solo una vista y que esta responsabilidad quede
                    //en la Lista o tal vez en un Presenter o Controler

                    if (this.Mode == FormMode.Update)
                    {
                        await ComisionAPIClient.UpdateAsync(this.Comision);
                    }
                    else
                    {
                        await ComisionAPIClient.AddAsync(this.Comision);
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetComision()
        {
            this.idTextBox.Text = this.Comision.Id.ToString();
            this.anioEspTextBox.Text = this.Comision.AnioEspecialidad.ToString();
            this.planComboBox1.SelectedValue = this.Comision.IdPlan;
            this.descTextBox.Text = this.Comision.Descripcion;
        }

        private void SetFormMode(FormMode value)
        {
            mode = value;

            if (Mode == FormMode.Add)
            {
                idLabel.Visible = false;
                idTextBox.Visible = false;

            }

            if (Mode == FormMode.Update)
            {
                idLabel.Visible = true;
                idTextBox.Visible = true;

            }
        }



        private bool ValidateComision()
        {
            bool isValid = true;

            errorProvider.SetError(anioEspTextBox, string.Empty);
            errorProvider.SetError(planComboBox1, string.Empty);
            errorProvider.SetError(descTextBox, string.Empty);



            if (this.anioEspTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(anioEspTextBox, "El año es Requerido");
            }

            if (this.planComboBox1.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(planComboBox1, "El plan es Requerido");
            }
            if (this.descTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(descTextBox, "La descripcion es Requerido");
            }

            return isValid;
        }

        private async void ComisionDetalle_Load(object sender, EventArgs e)
        {
            await LoadComboBox();         

            if (Mode == FormMode.Update)
                SetComision();              
        }
    }
}
