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
    public partial class ModuloDetalle : Form
    {
        private FormMode mode;
        private ModuloDTO modulo;

        public ModuloDetalle()
        {
            InitializeComponent();
        }

        public FormMode Mode
        {
            get => mode; set
            {
                mode = value;

                if (mode == FormMode.Add)
                {
                    this.idTextBox.Visible = false;
                    this.idLabel.Visible = false;
             
                }
                else
                {
                    this.idTextBox.Visible = true;
                    this.idLabel.Visible = true;
                }
            }
        }
        public ModuloDTO Curso
        {
            get => modulo; set
            {
                modulo = value;
                this.descTextBox.Text = modulo.Descripcion;
                this.ejecutaTextBox.Text = modulo.Ejecuta;
                this.idTextBox.Text = modulo.Id.ToString();
            }
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            if (validarModulo() == true)
            {
                try
                {
                    this.Curso.Descripcion = this.descTextBox.Text;
                    this.Curso.Ejecuta = this.ejecutaTextBox.Text;

                    if (FormMode.Update == mode)
                    {
                        await ModuloAPIClient.PutAsync(this.Curso);
                    }
                    else
                    {
                        await ModuloAPIClient.PostAsync(this.Curso);
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    {
                        MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK);
                        this.Close();
                    }
                }
            }
               
        }

        private bool validarModulo()
        {
            this.errorProvider1.SetError(descTextBox, "");
            this.errorProvider1.SetError(ejecutaTextBox, "");

            if (this.descTextBox.Text.Length == 0)
            {
                this.errorProvider1.SetError(descTextBox, "La descripcion es requerida");
                return false;
            }
            if(this.ejecutaTextBox.Text.Length == 0)
            {
                this.errorProvider1.SetError(ejecutaTextBox, "El ejecuta es requerido");
                return false;
            }

            return true;

        }
    }
}
