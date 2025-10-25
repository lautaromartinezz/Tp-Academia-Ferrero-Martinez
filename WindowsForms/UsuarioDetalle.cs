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
        private PersonaDTO persona;
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
        public PersonaDTO Persona
        {
            get { return persona; }
            set
            {
                persona = value;
                this.SetPersona();
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
            if (this.ValidateUsuarioYPersona())
            {
                try
                {
                    this.Usuario.Id = int.Parse(idTextBox.Text);
                    this.Usuario.Nombre = nombreTextBox.Text;
                    this.Usuario.NombreUsuario = usuarioTextBox.Text;
                    this.Usuario.Apellido = apellidoTextBox.Text;
                    this.Usuario.Email = emailTextBox.Text;
                    this.Usuario.Habilitado = habilitadoCheckBox.Checked;
                    this.Usuario.Clave = claveTextBox.Text;
                    //if(idTextBox.Text != null)this.Persona.Id = int.Parse(idPersona.Text);
                    this.Persona.Direccion = DireccionTextBox.Text;
                    this.Persona.FechaNac = dateTimePicker1.Value;
                    this.Persona.Legajo = int.Parse(legajottextBox.Text);
                    this.Persona.TipoPersona = tipoPersonaTextBox.Text;
                    this.Persona.Telefono = TelefonoTextBox.Text;
                    this.Persona.Nombre = nombreTextBox.Text;
                    this.Persona.Apellido = apellidoTextBox.Text;
                    this.Persona.Email = emailTextBox.Text;

                    if (this.Mode == FormMode.Update)
                    {
                        await API.Clients.UsuarioAPIClient.UpdateAsync(this.Usuario);
                    }
                    else
                    {
                        await API.Clients.UsuarioAPIClient.AddAsync(this.Usuario, this.Persona);
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
            this.claveTextBox.Text = this.Usuario.Clave;
        }

        private void SetPersona()
        {
            this.DireccionTextBox.Text = this.Persona.Direccion;
            this.dateTimePicker1.Value = this.Persona.FechaNac;
            this.legajottextBox.Text = this.Persona.Legajo.ToString();
            this.tipoPersonaTextBox.Text = this.Persona.TipoPersona.ToString();
            this.TelefonoTextBox.Text = this.Persona.Telefono;
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

        private bool ValidateUsuarioYPersona()
        {
            bool isValid = true;

            errorProvider.SetError(nombreTextBox, string.Empty);
            errorProvider.SetError(usuarioTextBox, string.Empty);
            errorProvider.SetError(apellidoTextBox, string.Empty);
            errorProvider.SetError(emailTextBox, string.Empty);
            errorProvider.SetError(claveTextBox, string.Empty);
            errorProvider.SetError(DireccionTextBox, string.Empty);
            errorProvider.SetError(TelefonoTextBox, string.Empty);
            errorProvider.SetError(tipoPersonaTextBox, string.Empty);   
            errorProvider.SetError(legajottextBox, string.Empty);
            errorProvider.SetError(dateTimePicker1, string.Empty);

            if(this.DireccionTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(DireccionTextBox, "La Direccion es Requerida");  
            }
            if(this.TelefonoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(TelefonoTextBox, "El Telefono es Requerido");    
            }
            if(this.tipoPersonaTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(tipoPersonaTextBox, "El Tipo de Persona es Requerido");
            }
            if (this.legajottextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(legajottextBox, "El Legajo es Requerido");
            }
            
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
            if (this.claveTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(claveTextBox, "La contrasena es requerida");
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
