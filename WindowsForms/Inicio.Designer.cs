namespace WindowsForms
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClose = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            materiasToolStripMenuItem1 = new ToolStripMenuItem();
            materiasToolStripMenuItem = new ToolStripMenuItem();
            cursosToolStripMenuItem = new ToolStripMenuItem();
            planesToolStripMenuItem = new ToolStripMenuItem();
            modulosToolStripMenuItem = new ToolStripMenuItem();
            especialidadesToolStripMenuItem = new ToolStripMenuItem();
            comisionesToolStripMenuItem = new ToolStripMenuItem();
            inscripcionesToolStripMenuItem = new ToolStripMenuItem();
            dictadosToolStripMenuItem = new ToolStripMenuItem();
            profesorToolStripMenuItem = new ToolStripMenuItem();
            cargarNotasToolStripMenuItem = new ToolStripMenuItem();
            alumnoToolStripMenuItem = new ToolStripMenuItem();
            inscribirseACursoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(276, 332);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 35);
            btnClose.TabIndex = 4;
            btnClose.Text = "Cerrar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(145, 20);
            label1.Name = "label1";
            label1.Size = new Size(101, 32);
            label1.TabIndex = 5;
            label1.Text = "Gestión";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, profesorToolStripMenuItem, alumnoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(382, 24);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { materiasToolStripMenuItem1, materiasToolStripMenuItem, cursosToolStripMenuItem, planesToolStripMenuItem, modulosToolStripMenuItem, especialidadesToolStripMenuItem, comisionesToolStripMenuItem, inscripcionesToolStripMenuItem, dictadosToolStripMenuItem });
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(55, 20);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // materiasToolStripMenuItem1
            // 
            materiasToolStripMenuItem1.Name = "materiasToolStripMenuItem1";
            materiasToolStripMenuItem1.Size = new Size(180, 22);
            materiasToolStripMenuItem1.Text = "Usuarios";
            materiasToolStripMenuItem1.Click += usuariosToolStripMenuItem1_Click;
            // 
            // materiasToolStripMenuItem
            // 
            materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            materiasToolStripMenuItem.Size = new Size(180, 22);
            materiasToolStripMenuItem.Text = "Materias";
            materiasToolStripMenuItem.Click += materiasToolStripMenuItem_Click;
            // 
            // cursosToolStripMenuItem
            // 
            cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            cursosToolStripMenuItem.Size = new Size(180, 22);
            cursosToolStripMenuItem.Text = "Cursos";
            cursosToolStripMenuItem.Click += cursosToolStripMenuItem_Click;
            // 
            // planesToolStripMenuItem
            // 
            planesToolStripMenuItem.Name = "planesToolStripMenuItem";
            planesToolStripMenuItem.Size = new Size(180, 22);
            planesToolStripMenuItem.Text = "Planes";
            planesToolStripMenuItem.Click += planesToolStripMenuItem_Click;
            // 
            // modulosToolStripMenuItem
            // 
            modulosToolStripMenuItem.Name = "modulosToolStripMenuItem";
            modulosToolStripMenuItem.Size = new Size(180, 22);
            modulosToolStripMenuItem.Text = "Modulos";
            modulosToolStripMenuItem.Click += modulosToolStripMenuItem_Click;
            // 
            // especialidadesToolStripMenuItem
            // 
            especialidadesToolStripMenuItem.Name = "especialidadesToolStripMenuItem";
            especialidadesToolStripMenuItem.Size = new Size(180, 22);
            especialidadesToolStripMenuItem.Text = "Especialidades";
            especialidadesToolStripMenuItem.Click += especialidadesToolStripMenuItem_Click;
            // 
            // comisionesToolStripMenuItem
            // 
            comisionesToolStripMenuItem.Name = "comisionesToolStripMenuItem";
            comisionesToolStripMenuItem.Size = new Size(180, 22);
            comisionesToolStripMenuItem.Text = "Comisiones";
            comisionesToolStripMenuItem.Click += comisionesToolStripMenuItem_Click;
            // 
            // inscripcionesToolStripMenuItem
            // 
            inscripcionesToolStripMenuItem.Name = "inscripcionesToolStripMenuItem";
            inscripcionesToolStripMenuItem.Size = new Size(180, 22);
            inscripcionesToolStripMenuItem.Text = "Inscripciones";
            inscripcionesToolStripMenuItem.Click += inscripcionesToolStripMenuItem_Click;
            // 
            // dictadosToolStripMenuItem
            // 
            dictadosToolStripMenuItem.Name = "dictadosToolStripMenuItem";
            dictadosToolStripMenuItem.Size = new Size(180, 22);
            dictadosToolStripMenuItem.Text = "Dictados";
            dictadosToolStripMenuItem.Click += dictadosToolStripMenuItem_Click;
            // 
            // profesorToolStripMenuItem
            // 
            profesorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cargarNotasToolStripMenuItem });
            profesorToolStripMenuItem.Name = "profesorToolStripMenuItem";
            profesorToolStripMenuItem.Size = new Size(63, 20);
            profesorToolStripMenuItem.Text = "Profesor";
            // 
            // cargarNotasToolStripMenuItem
            // 
            cargarNotasToolStripMenuItem.Name = "cargarNotasToolStripMenuItem";
            cargarNotasToolStripMenuItem.Size = new Size(180, 22);
            cargarNotasToolStripMenuItem.Text = "Cargar Notas";
            cargarNotasToolStripMenuItem.Click += cargarNotasToolStripMenuItem_Click;
            // 
            // alumnoToolStripMenuItem
            // 
            alumnoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inscribirseACursoToolStripMenuItem });
            alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            alumnoToolStripMenuItem.Size = new Size(62, 20);
            alumnoToolStripMenuItem.Text = "Alumno";
            // 
            // inscribirseACursoToolStripMenuItem
            // 
            inscribirseACursoToolStripMenuItem.Name = "inscribirseACursoToolStripMenuItem";
            inscribirseACursoToolStripMenuItem.Size = new Size(180, 22);
            inscribirseACursoToolStripMenuItem.Text = "Inscribirse a Curso";
            inscribirseACursoToolStripMenuItem.Click += inscribirseACursoToolStripMenuItem_Click;
            // 
            // reporteCursosButton
            // 
            reporteCursosButton.Location = new Point(252, 55);
            reporteCursosButton.Name = "reporteCursosButton";
            reporteCursosButton.Size = new Size(118, 40);
            reporteCursosButton.TabIndex = 15;
            reporteCursosButton.Text = "Reporte Cursos";
            reporteCursosButton.UseVisualStyleBackColor = true;
            reporteCursosButton.Click += button2_Click;
            // 
            // reportePlanesButton
            // 
            reportePlanesButton.Location = new Point(252, 101);
            reportePlanesButton.Name = "reportePlanesButton";
            reportePlanesButton.Size = new Size(118, 40);
            reportePlanesButton.TabIndex = 16;
            reportePlanesButton.Text = "Reporte Planes";
            reportePlanesButton.UseVisualStyleBackColor = true;
            reportePlanesButton.Click += reportePlanesButton_Click_1;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(382, 379);
            Controls.Add(reporteCursosButton);
            Controls.Add(reportePlanesButton);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Academia";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label label1;
        private Button reportePlanesButton;
        private Button reporteCursosButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem profesorToolStripMenuItem;
        private ToolStripMenuItem materiasToolStripMenuItem1;
        private ToolStripMenuItem materiasToolStripMenuItem;
        private ToolStripMenuItem cursosToolStripMenuItem;
        private ToolStripMenuItem planesToolStripMenuItem;
        private ToolStripMenuItem modulosToolStripMenuItem;
        private ToolStripMenuItem especialidadesToolStripMenuItem;
        private ToolStripMenuItem comisionesToolStripMenuItem;
        private ToolStripMenuItem inscripcionesToolStripMenuItem;
        private ToolStripMenuItem dictadosToolStripMenuItem;
        private ToolStripMenuItem cargarNotasToolStripMenuItem;
        private ToolStripMenuItem alumnoToolStripMenuItem;
        private ToolStripMenuItem inscribirseACursoToolStripMenuItem;
    }
}