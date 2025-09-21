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
    public partial class CursoDetalle : Form
    {
        private CursoDTO curso;
        private FormMode mode;

        public CursoDTO Curso
        {
            get { return curso; }
            set
            {
                curso = value;
                this.SetCurso();
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

        public CursoDetalle()
        {
            InitializeComponent();

            Mode = FormMode.Add;
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateCurso())
            {
                try
                {
                    this.Curso.AnioCalendario = anioCalendarioTimePicker.Value;
                    this.Curso.Cupo = int.Parse(cupoTextBox.Text);
                    this.Curso.IdComision = int.Parse(idComisionTextBox.Text);
                    this.Curso.IdMateria = int.Parse(idMateriaTextBox.Text);

                    //El Detalle se esta llevando la responsabilidad de llamar al servicio
                    //pero tal vez deberia ser solo una vista y que esta responsabilidad quede
                    //en la Lista o tal vez en un Presenter o Controler

                    if (this.Mode == FormMode.Update)
                    {
                        await CursoAPIClient.UpdateAsync(this.Curso);
                    }
                    else
                    {
                        await CursoAPIClient.AddAsync(this.Curso);
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

        private void SetCurso()
        {
            this.idTextBox.Text = this.Curso.Id.ToString();
            this.cupoTextBox.Text = this.Curso.Cupo.ToString();
            this.idComisionTextBox.Text = this.Curso.IdComision.ToString();
            this.idMateriaTextBox.Text = this.Curso.IdMateria.ToString();
            this.anioCalendarioTimePicker.Value = this.Curso.AnioCalendario;
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

        private bool ValidateCurso()
        {
            bool isValid = true;

            errorProvider.SetError(cupoTextBox, string.Empty);
            errorProvider.SetError(idComisionTextBox, string.Empty);
            errorProvider.SetError(idMateriaTextBox, string.Empty);



            if (this.cupoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(cupoTextBox, "La descripcion es Requerido");
            }

            if (this.idComisionTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(idComisionTextBox, "Las horas semanales es Requerido");
            }
            if (this.idMateriaTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(idMateriaTextBox, "Las horas totales es Requerido");
            }

            return isValid;
        }

    }
}
