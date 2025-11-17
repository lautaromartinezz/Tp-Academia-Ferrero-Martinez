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

        private void comButton_Click(object sender, EventArgs e)
        {
            ComisionLista com = new ComisionLista();
            com.Show();
        }

        private void inscripcionBttn_Click(object sender, EventArgs e)
        {
            InscripcionLista ins = new InscripcionLista();
            ins.Show();
        }

        private void dictadoBttn_Click(object sender, EventArgs e)
        {
            DictadoLista dic = new DictadoLista();
            dic.Show();
        }

        private void SetTipoUsuario(TipoUsuario value)
        {
            mode = value;

            if (Mode == TipoUsuario.Admin)
            {
                profesorBttn.Visible = false;
                alumnoBttn.Visible = false;

            }

            if (Mode == TipoUsuario.Profesor)
            {
                button1.Visible = false;
                comButton.Visible = false;
                alumnoBttn.Visible = false;
                usuarioButton.Visible = false;
                comButton.Visible = false;
                inscripcionBttn.Visible = false;
                dictadoBttn.Visible = false;
                materiaButton.Visible = false;
                bttnCursos.Visible = false;
                especialidadButton.Visible = false;
                ModulosButton.Visible = false;

            }

            if (Mode == TipoUsuario.Alumno)
            {
                button1.Visible = false;
                comButton.Visible = false;
                profesorBttn.Visible = false;
                usuarioButton.Visible = false;
                comButton.Visible = false;
                inscripcionBttn.Visible = false;
                dictadoBttn.Visible = false;
                materiaButton.Visible = false;
                bttnCursos.Visible = false;
                especialidadButton.Visible = false;
                ModulosButton.Visible = false;

            }
        }

        private void profesorBttn_Click(object sender, EventArgs e)
        {
            CUProfesorListaDictados profList = new CUProfesorListaDictados();
            profList.UserId = this.UserId;
            profList.Show();
        }

        private void alumnoBttn_Click(object sender, EventArgs e)
        {
            CUAlumnoListaCursos profList = new CUAlumnoListaCursos();
            profList.UserId = this.UserId;
            profList.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReporteCursos reporte = new ReporteCursos();
            reporte.UserId = this.UserId;
            reporte.Show();
        }
    }
}
