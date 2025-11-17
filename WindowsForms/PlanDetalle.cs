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
    public partial class PlanDetalle : Form
    {
        private PlanDTO plan;
        private FormMode mode;

        public PlanDTO Plan
        {
            get { return plan; }
            set
            {
                plan = value;
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

        public PlanDetalle()
        {
            InitializeComponent();

            Mode = FormMode.Add;
        }

        private async Task LoadComboBox()
        {
            try
            {
                var especialidades = await EspecialidadAPIClient.GetAllAsync();
                especialidadComboBox.DataSource = especialidades;
                especialidadComboBox.DisplayMember = "DescEspecialidad";
                especialidadComboBox.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            if (this.ValidatePlan())
            {
                try
                {
                    this.Plan.Descripcion = descTextBox.Text;
                    this.Plan.IdEspecialidad = (int)especialidadComboBox.SelectedValue;

                    //El Detalle se esta llevando la responsabilidad de llamar al servicio
                    //pero tal vez deberia ser solo una vista y que esta responsabilidad quede
                    //en la Lista o tal vez en un Presenter o Controler

                    if (this.Mode == FormMode.Update)
                    {
                        await PlanAPIClient.UpdateAsync(this.Plan);
                    }
                    else
                    {
                        await PlanAPIClient.AddAsync(this.Plan);
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

        private void SetPlan()
        {
            this.idTextBox.Text = this.Plan.Id.ToString();
            this.descTextBox.Text = this.Plan.Descripcion;
            this.especialidadComboBox.SelectedValue = this.Plan.IdEspecialidad;
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

        private bool ValidatePlan()
        {
            bool isValid = true;

            errorProvider.SetError(descTextBox, string.Empty);
            errorProvider.SetError(especialidadComboBox, string.Empty);



            if (this.descTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(descTextBox, "La descripcion es Requerido");
            }

            if (this.especialidadComboBox.SelectedValue == null)
            {
                isValid = false;
                errorProvider.SetError(especialidadComboBox, "El id Especiliadad es Requerido");
            }

            return isValid;
        }

        private async void PlanDetalle_Load(object sender, EventArgs e)
        {
            await LoadComboBox();
            if (this.Mode == FormMode.Add)
            {
                this.SetPlan();
            }
        }
    }
}
