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
    public enum FormMode
    {
        Add,
        Update
    }

    public partial class UsuarioDetalle : Form
    {
        private UsuarioDTO usuario;
        private FormMode mode;

        public UsuarioDTO Usuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
                this.SetUsuario();
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

        public UsuarioDetalle()
        {
            InitializeComponent();

            Mode = FormMode.Add;
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateUsuario())
            {
                try
                {
                    this.Usuario.Nombre = nombreTextBox.Text;
                    this.Usuario.NombreUsuario = usuarioTextBox.Text;
                    this.Usuario.Apellido = apellidoTextBox.Text;
                    this.Usuario.Email = emailTextBox.Text;
                    this.Usuario.Habilitado = habilitadoCheckBox.Checked;

                    //El Detalle se esta llevando la responsabilidad de llamar al servicio
                    //pero tal vez deberia ser solo una vista y que esta responsabilidad quede
                    //en la Lista o tal vez en un Presenter o Controler

                    if (this.Mode == FormMode.Update)
                    {
                        await UsuarioAPIClient.UpdateAsync(this.Usuario);
                    }
                    else
                    {
                        await UsuarioAPIClient.AddAsync(this.Usuario);
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

        private void SetUsuario()
        {
            this.idTextBox.Text = this.Usuario.Id.ToString();
            this.nombreTextBox.Text = this.Usuario.Nombre;
            this.usuarioTextBox.Text = this.Usuario.NombreUsuario;
            this.apellidoTextBox.Text = this.Usuario.Apellido;
            this.emailTextBox.Text = this.Usuario.Email;
            this.habilitadoCheckBox.Checked = this.Usuario.Habilitado;
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

        private bool ValidateUsuario()
        {
            bool isValid = true;

            errorProvider.SetError(nombreTextBox, string.Empty);
            errorProvider.SetError(usuarioTextBox, string.Empty);
            errorProvider.SetError(apellidoTextBox, string.Empty);
            errorProvider.SetError(emailTextBox, string.Empty);

            if (this.nombreTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(nombreTextBox, "El Nombre es Requerido");
            }

            if (this.usuarioTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(usuarioTextBox, "El Usuario es Requerido");
            }
            if (this.apellidoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(usuarioTextBox, "El Apellido es Requerido");
            }

            if (this.emailTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(emailTextBox, "El Email es Requerido");
            }
            else if (!EsEmailValido(this.emailTextBox.Text))
            {
                isValid = false;
                errorProvider.SetError(emailTextBox, "El formato del Email no es válido");
            }

            return isValid;
        }

        private static bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
