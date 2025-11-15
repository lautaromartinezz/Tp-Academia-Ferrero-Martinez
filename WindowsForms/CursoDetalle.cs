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
        private async Task LoadComboBox()
        {
            try
            {
                var materias = await MateriaAPIClient.GetAllAsync();
                materiaComboBox.DataSource = materias;
                materiaComboBox.DisplayMember = "Descripcion";
                materiaComboBox.ValueMember = "Id";
                var comisiones = await ComisionAPIClient.GetAllAsync();
                comisionComboBox.DataSource = comisiones;
                comisionComboBox.DisplayMember = "Descripcion";
                comisionComboBox.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las materias o comisiones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateCurso())
            {
                try
                {
                    this.Curso.AnioCalendario = this.anioCalendarioTimePicker.Value;
                    this.Curso.Cupo = int.Parse(cupoTextBox.Text);
                    this.Curso.IdComision = (int)comisionComboBox.SelectedValue;
                    this.Curso.IdMateria = (int)materiaComboBox.SelectedValue;

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
            this.comisionComboBox.SelectedValue = this.Curso.IdComision;
            this.materiaComboBox.SelectedValue = this.Curso.IdMateria;
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
            errorProvider.SetError(materiaComboBox, string.Empty);
            errorProvider.SetError(comisionComboBox, string.Empty);


            if (this.cupoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(cupoTextBox, "La descripcion es Requerido");
            }
            if (this.materiaComboBox.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(materiaComboBox, "La materia es Requerida");
            }
            if (this.comisionComboBox.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(comisionComboBox, "La comision es Requerida");
            }

            return isValid;
        }

        private async void CursoDetalle_Load(object sender, EventArgs e) 
        {
            await LoadComboBox();
            if (this.Mode == FormMode.Update)
            {
                SetCurso();
            }
        }
        
    }
}
