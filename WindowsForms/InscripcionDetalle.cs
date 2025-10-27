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
    public partial class InscripcionDetalle : Form
    {
        private InscripcionDTO inscripcion;
        private FormMode mode;

        public InscripcionDTO Inscripcion
        {
            get { return inscripcion; }
            set
            {
                inscripcion = value;
                this.SetInscripcion();
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
        public InscripcionDetalle()
        {
            InitializeComponent();
            Mode = FormMode.Add;

        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateInscripcion())
            {
                try
                {
                    this.Inscripcion.Nota = int.Parse(notaTextBox.Text);
                    this.Inscripcion.Situacion= SituacionTextBox.Text;
                    this.Inscripcion.IdAlumno = int.Parse(idAlumnoTextBox.Text);
                    this.Inscripcion.IdCurso = int.Parse(idCursoTextBox.Text);


                    //El Detalle se esta llevando la responsabilidad de llamar al servicio
                    //pero tal vez deberia ser solo una vista y que esta responsabilidad quede
                    //en la Lista o tal vez en un Presenter o Controler

                    if (this.Mode == FormMode.Update)
                    {
                        await InscripcionAPIClient.UpdateAsync(this.Inscripcion);
                    }
                    else
                    {
                        await InscripcionAPIClient.AddAsync(this.Inscripcion);
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

        private void SetInscripcion()
        {
            this.idTextBox.Text = this.Inscripcion.Id.ToString();
            this.notaTextBox.Text = this.Inscripcion.Nota.ToString();
            this.SituacionTextBox.Text = this.Inscripcion.Situacion;
            this.idAlumnoTextBox.Text = this.Inscripcion.IdAlumno.ToString();
            this.idCursoTextBox.Text = this.Inscripcion.IdCurso.ToString();

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

        private bool ValidateInscripcion()
        {
            bool isValid = true;

            errorProvider.SetError(notaTextBox, string.Empty);
            errorProvider.SetError(SituacionTextBox, string.Empty);
            errorProvider.SetError(idAlumnoTextBox, string.Empty);
            errorProvider.SetError(idCursoTextBox, string.Empty);




            if (this.notaTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(notaTextBox, "La nota es Requerido");
            }

            if (this.SituacionTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(SituacionTextBox, "La situacion es Requerido");
            }
            if (this.idAlumnoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(idAlumnoTextBox, "El Alumno es Requerido");
            }
            if (this.idCursoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(idAlumnoTextBox, "El Curso es Requerido");
            }

            return isValid;
        }
    }
}
