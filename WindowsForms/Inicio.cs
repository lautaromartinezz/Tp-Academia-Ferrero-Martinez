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
    }
}
