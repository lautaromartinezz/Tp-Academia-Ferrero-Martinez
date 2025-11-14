using Academia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsForms
{
        public enum TipoUsuario
        {
            Admin,
            Profesor,
            Alumno
        }
    public partial class Inicio : Form
    {
        private TipoUsuario mode;
        private string _userId;

        public string UserId { get { return _userId; } set { _userId = value; } }
        public TipoUsuario Mode
        {
            get
            {
                return mode;
            }
            set
            {
                SetTipoUsuario(value);
            }
        }
        public Inicio()
        {
            InitializeComponent();

        }
        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UsuarioLista usuarioLista = new UsuarioLista();
            usuarioLista.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MateriaLista materiaLista = new MateriaLista();
            materiaLista.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CursoLista cursoLista = new CursoLista();
            cursoLista.Show();
        }
        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlanLista planLista = new PlanLista();
            planLista.Show();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void modulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuloLista m = new ModuloLista();
            m.Show();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EspecialidadLista esp = new EspecialidadLista();
            esp.Show();
        }

        private void comisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComisionLista com = new ComisionLista();
            com.Show();
        }

        private void inscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InscripcionLista ins = new InscripcionLista();
            ins.Show();
        }

        private void dictadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DictadoLista dic = new DictadoLista();
            dic.Show();
        }

        private void SetTipoUsuario(TipoUsuario value)
        {
            mode = value;

            if (Mode == TipoUsuario.Admin)
            {

                alumnoToolStripMenuItem.Visible = false;
                profesorToolStripMenuItem.Visible = false;
            }

            if (Mode == TipoUsuario.Profesor)
            {

                adminToolStripMenuItem.Visible = false;
                alumnoToolStripMenuItem.Visible = false;


            }

            if (Mode == TipoUsuario.Alumno)
            {
                adminToolStripMenuItem.Visible = false;
                profesorToolStripMenuItem.Visible = false;

            }
        }

        private void cargarNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CUProfesorListaDictados profList = new CUProfesorListaDictados();
            profList.UserId = this.UserId;
            profList.Show();
        }

        private void inscribirseACursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CUAlumnoListaCursos profList = new CUAlumnoListaCursos();
            profList.UserId = this.UserId;
            profList.Show();
        }


    }
}
