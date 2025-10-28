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
    public enum FormModeInsc
    {
        Add,
        Update,
        Profesor
    }
    public partial class InscripcionDetalle : Form
    {
        private InscripcionDTO inscripcion;
        private FormModeInsc mode;

        public InscripcionDTO Inscripcion
        {
            get { return inscripcion; }
            set
            {
                inscripcion = value;
                this.SetInscripcion();
            }
        }

        public FormModeInsc Mode
        {
            get
            {
                return mode;
            }
            set
            {
                SetFormModeInsc(value);
            }
        }
        public InscripcionDetalle()
        {
            InitializeComponent();
            Mode = FormModeInsc.Add;

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

                    if (this.Mode == FormModeInsc.Update || this.Mode == FormModeInsc.Profesor)
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

        private void SetFormModeInsc(FormModeInsc value)
        {
            mode = value;

            if (Mode == FormModeInsc.Add)
            {
                idLabel.Visible = false;
                idTextBox.Visible = false;

            }

            if (Mode == FormModeInsc.Update)
            {
                idLabel.Visible = true;
                idTextBox.Visible = true;

            }
            if(Mode == FormModeInsc.Profesor)
            {
                idLabel.Visible = false;
                idTextBox.Visible = false;
                idAlumnoTextBox.Visible = false;
                idAlumnoLabel.Visible = false;
                idCursoLabel.Visible = false;
                idCursoTextBox.Visible = false;
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
