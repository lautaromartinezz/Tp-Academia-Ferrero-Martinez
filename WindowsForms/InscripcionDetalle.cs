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

        private async Task LoadComboBox()
        {
            try
            {
                var alumnos = await PersonaAPIClient.GetAllAsync();
                alumnoComboBox.DataSource = alumnos;
                alumnoComboBox.DisplayMember = "Legajo";
                alumnoComboBox.ValueMember = "Id";
                var cursos = await CursoAPIClient.GetAllAsync();
                cursoComboBox.DataSource = cursos;
                cursoComboBox.DisplayMember = "AnioCalendario";
                cursoComboBox.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateInscripcion())
            {
                try
                {
                    this.Inscripcion.Nota = int.Parse(notaTextBox.Text);
                    this.Inscripcion.Situacion = SituacionTextBox.Text;
                    this.Inscripcion.IdAlumno = (int)alumnoComboBox.SelectedValue;
                    this.Inscripcion.IdCurso = (int)cursoComboBox.SelectedValue;


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
            this.alumnoComboBox.SelectedValue = this.Inscripcion.IdAlumno;
            this.cursoComboBox.SelectedValue = this.Inscripcion.IdCurso;

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
            if (Mode == FormModeInsc.Profesor)
            {
                idLabel.Visible = false;
                idTextBox.Visible = false;
                alumnoComboBox.Visible = false;
                idAlumnoLabel.Visible = false;
                idCursoLabel.Visible = false;
                cursoComboBox.Visible = false;
            }
        }

        private bool ValidateInscripcion()
        {
            bool isValid = true;

            errorProvider.SetError(notaTextBox, string.Empty);
            errorProvider.SetError(SituacionTextBox, string.Empty);
            errorProvider.SetError(alumnoComboBox, string.Empty);
            errorProvider.SetError(cursoComboBox, string.Empty);




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
            if (this.alumnoComboBox == null)
            {
                isValid = false;
                errorProvider.SetError(alumnoComboBox, "El Alumno es Requerido");
            }
            if (this.cursoComboBox == null)
            {
                isValid = false;
                errorProvider.SetError(cursoComboBox, "El Curso es Requerido");
            }

            return isValid;
        }

        private async void InscripcionDetalle_Load(object sender, EventArgs e)
        {
            await LoadComboBox();
            if (this.Mode == FormModeInsc.Update)
            {
                SetInscripcion();
            }
        }
    }
}
