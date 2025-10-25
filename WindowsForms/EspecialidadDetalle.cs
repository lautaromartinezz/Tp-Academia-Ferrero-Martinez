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
    public partial class EspecialidadDetalle : Form
    {
        private EspecialidadDTO especialidad;
        private FormMode mode;

        public EspecialidadDTO Especialidad
        {
            get { return especialidad; }
            set
            {
                especialidad = value;
                this.SetEspecialidad();
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

        public EspecialidadDetalle()
        {
            InitializeComponent();

            Mode = FormMode.Add;
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateEspecialidad())
            {
                try
                {
                    this.Especialidad.DescEspecialidad = descEspecialidadTextBox.Text;

                    //El Detalle se esta llevando la responsabilidad de llamar al servicio
                    //pero tal vez deberia ser solo una vista y que esta responsabilidad quede
                    //en la Lista o tal vez en un Presenter o Controler

                    if (this.Mode == FormMode.Update)
                    {
                        await EspecialidadAPIClient.UpdateAsync(this.Especialidad);
                    }
                    else
                    {
                        await EspecialidadAPIClient.AddAsync(this.Especialidad);
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

        private void SetEspecialidad()
        {
            this.idTextBox.Text = this.Especialidad.Id.ToString();
            this.descEspecialidadTextBox.Text = this.Especialidad.DescEspecialidad;
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

        private bool ValidateEspecialidad()
        {
            bool isValid = true;

            errorProvider.SetError(descEspecialidadTextBox, string.Empty);



            if (this.descEspecialidadTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(descEspecialidadTextBox, "La descripcion es requerida");
            }

            return isValid;
        }

    }
}
