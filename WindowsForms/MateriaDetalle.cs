using DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using API.Clients;

namespace WindowsForms
{
    public partial class MateriaDetalle : Form
    {
        private MateriaDTO materia;
        private FormMode mode;

        public MateriaDTO Materia
        {
            get { return materia; }
            set
            {
                materia = value;
                this.SetMateria();
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

        public MateriaDetalle()
        {
            InitializeComponent();

            Mode = FormMode.Add;
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateMateria())
            {
                try
                {
                    this.Materia.Descripcion = descripcionTextBox.Text;
                    this.Materia.HsSemanales = int.Parse(hsSemanalesTextBox.Text);
                    this.Materia.HsTotales = int.Parse(hsTotalesTextBox.Text);
                    this.Materia.IdPlan = int.Parse(idPlanTextBox.Text);

                    //El Detalle se esta llevando la responsabilidad de llamar al servicio
                    //pero tal vez deberia ser solo una vista y que esta responsabilidad quede
                    //en la Lista o tal vez en un Presenter o Controler

                    if (this.Mode == FormMode.Update)
                    {
                        await MateriaAPIClient.UpdateAsync(this.Materia);
                    }
                    else
                    {
                        await MateriaAPIClient.AddAsync(this.Materia);
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

        private void SetMateria()
        {
            this.idTextBox.Text = this.Materia.Id.ToString();
            this.descripcionTextBox.Text = this.Materia.Descripcion;
            this.hsSemanalesTextBox.Text = this.Materia.HsSemanales.ToString();
            this.hsTotalesTextBox.Text = this.Materia.HsTotales.ToString();
            this.idPlanTextBox.Text = this.Materia.IdPlan.ToString();
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

        private bool ValidateMateria()
        {
            bool isValid = true;

            errorProvider.SetError(descripcionTextBox, string.Empty);
            errorProvider.SetError(hsSemanalesTextBox, string.Empty);
            errorProvider.SetError(hsTotalesTextBox, string.Empty);
            errorProvider.SetError(idPlanTextBox, string.Empty);



            if (this.descripcionTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(descripcionTextBox, "La descripcion es Requerido");
            }

            if (this.hsSemanalesTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(hsSemanalesTextBox, "Las horas semanales es Requerido");
            }
            if (this.hsTotalesTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(hsSemanalesTextBox, "Las horas totales es Requerido");
            }
            if (this.idPlanTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(idPlanTextBox, "El IDPlan totales es Requerido");
            }

            return isValid;
        }

    }
}
