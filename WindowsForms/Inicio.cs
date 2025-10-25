using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Academia;

namespace WindowsForms
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void usuarioButton_Click(object sender, EventArgs e)
        {
            UsuarioLista usuarioLista = new UsuarioLista();
            usuarioLista.Show();
        }

        private void materiaButton_Click(object sender, EventArgs e)
        {
            MateriaLista materiaLista = new MateriaLista();
            materiaLista.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CursoLista cursoLista = new CursoLista();
            cursoLista.Show();
        }
        private void bttnCursos_Click(object sender, EventArgs e)
        {
            PlanLista planLista = new PlanLista();
            planLista.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            formLogin appLogin = new formLogin();
            DialogResult diagRes = appLogin.ShowDialog();
            if (diagRes != DialogResult.OK)
            {
                this.Dispose();
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ModulosButton_Click(object sender, EventArgs e)
        {
            ModuloLista m = new ModuloLista();
            m.Show();
        }

        private void especialidadButton_Click(object sender, EventArgs e)
        {
            EspecialidadLista esp = new EspecialidadLista();
            esp.Show();
        }
    }
}
