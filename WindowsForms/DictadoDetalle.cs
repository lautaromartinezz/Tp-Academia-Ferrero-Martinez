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
    public partial class DictadoDetalle : Form
    {
        private DictadoDTO dictado;
        private FormMode mode;

        public DictadoDTO Dictado
        {
            get { return dictado; }
            set
            {
                dictado = value;
                this.SetDictado();
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
        public DictadoDetalle()
        {
            InitializeComponent();

            Mode = FormMode.Add;

        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateDictado())
            {
                try
                {
                    this.Dictado.Cargo = cargoTextBox.Text;
                    this.Dictado.IdProfesor = int.Parse(idProfesorTextBox.Text);
                    this.Dictado.IdCurso = int.Parse(idCursoTextBox.Text);


                    //El Detalle se esta llevando la responsabilidad de llamar al servicio
                    //pero tal vez deberia ser solo una vista y que esta responsabilidad quede
                    //en la Lista o tal vez en un Presenter o Controler

                    if (this.Mode == FormMode.Update)
                    {
                        await DictadoAPIClient.UpdateAsync(this.Dictado);
                    }
                    else
                    {
                        await DictadoAPIClient.AddAsync(this.Dictado);
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

        private void SetDictado()
        {
            this.idTextBox.Text = this.Dictado.Id.ToString();
            this.cargoTextBox.Text = this.Dictado.Cargo;
            this.idProfesorTextBox.Text = this.Dictado.IdProfesor.ToString();
            this.idCursoTextBox.Text = this.Dictado.IdCurso.ToString();

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

        private bool ValidateDictado()
        {
            bool isValid = true;

            errorProvider.SetError(cargoTextBox, string.Empty);
            errorProvider.SetError(idProfesorTextBox, string.Empty);
            errorProvider.SetError(idCursoTextBox, string.Empty);




            if (this.cargoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(cargoTextBox, "La situacion es Requerido");
            }
            if (this.idProfesorTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(idProfesorTextBox, "El Profesor es Requerido");
            }
            if (this.idCursoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(idProfesorTextBox, "El Curso es Requerido");
            }

            return isValid;
        }
    }
}
