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
            usuarioButton = new Button();
            materiaButton = new Button();
            btnClose = new Button();
            label1 = new Label();
            button1 = new Button();
            bttnCursos = new Button();
            ModulosButton = new Button();
            especialidadButton = new Button();
            comButton = new Button();
            inscripcionBttn = new Button();
            dictadoBttn = new Button();
            profesorBttn = new Button();
            alumnoBttn = new Button();
            reporteCursosButton = new Button();
            SuspendLayout();
            // 
            // usuarioButton
            // 
            usuarioButton.Location = new Point(12, 55);
            usuarioButton.Name = "usuarioButton";
            usuarioButton.Size = new Size(114, 40);
            usuarioButton.TabIndex = 0;
            usuarioButton.Text = "Usuarios";
            usuarioButton.UseVisualStyleBackColor = true;
            usuarioButton.Click += usuarioButton_Click;
            // 
            // materiaButton
            // 
            materiaButton.Location = new Point(12, 101);
            materiaButton.Name = "materiaButton";
            materiaButton.Size = new Size(114, 40);
            materiaButton.TabIndex = 2;
            materiaButton.Text = "Materias";
            materiaButton.UseVisualStyleBackColor = true;
            materiaButton.Click += materiaButton_Click;
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
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 32);
            label1.TabIndex = 5;
            label1.Text = "Gestión";
            // 
            // button1
            // 
            button1.Location = new Point(12, 147);
            button1.Name = "button1";
            button1.Size = new Size(114, 38);
            button1.TabIndex = 6;
            button1.Text = "Cursos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bttnCursos
            // 
            bttnCursos.Location = new Point(12, 191);
            bttnCursos.Name = "bttnCursos";
            bttnCursos.Size = new Size(114, 38);
            bttnCursos.TabIndex = 7;
            bttnCursos.Text = "Planes";
            bttnCursos.UseVisualStyleBackColor = true;
            bttnCursos.Click += bttnCursos_Click;
            // 
            // ModulosButton
            // 
            ModulosButton.Location = new Point(12, 235);
            ModulosButton.Name = "ModulosButton";
            ModulosButton.Size = new Size(114, 34);
            ModulosButton.TabIndex = 8;
            ModulosButton.Text = "Modulos";
            ModulosButton.UseVisualStyleBackColor = true;
            ModulosButton.Click += ModulosButton_Click;
            // 
            // especialidadButton
            // 
            especialidadButton.Location = new Point(12, 275);
            especialidadButton.Name = "especialidadButton";
            especialidadButton.Size = new Size(114, 34);
            especialidadButton.TabIndex = 9;
            especialidadButton.Text = "Especialidades";
            especialidadButton.UseVisualStyleBackColor = true;
            especialidadButton.Click += especialidadButton_Click;
            // 
            // comButton
            // 
            comButton.Location = new Point(12, 315);
            comButton.Name = "comButton";
            comButton.Size = new Size(114, 34);
            comButton.TabIndex = 10;
            comButton.Text = "Comisiones";
            comButton.UseVisualStyleBackColor = true;
            comButton.Click += comButton_Click;
            // 
            // inscripcionBttn
            // 
            inscripcionBttn.Location = new Point(132, 55);
            inscripcionBttn.Name = "inscripcionBttn";
            inscripcionBttn.Size = new Size(114, 40);
            inscripcionBttn.TabIndex = 11;
            inscripcionBttn.Text = "Inscripciones";
            inscripcionBttn.UseVisualStyleBackColor = true;
            inscripcionBttn.Click += inscripcionBttn_Click;
            // 
            // dictadoBttn
            // 
            dictadoBttn.Location = new Point(132, 101);
            dictadoBttn.Name = "dictadoBttn";
            dictadoBttn.Size = new Size(114, 40);
            dictadoBttn.TabIndex = 12;
            dictadoBttn.Text = "Dictado";
            dictadoBttn.UseVisualStyleBackColor = true;
            dictadoBttn.Click += dictadoBttn_Click;
            // 
            // profesorBttn
            // 
            profesorBttn.Location = new Point(132, 147);
            profesorBttn.Name = "profesorBttn";
            profesorBttn.Size = new Size(114, 38);
            profesorBttn.TabIndex = 13;
            profesorBttn.Text = "Agregar Notas";
            profesorBttn.UseVisualStyleBackColor = true;
            profesorBttn.Click += profesorBttn_Click;
            // 
            // alumnoBttn
            // 
            alumnoBttn.Location = new Point(132, 191);
            alumnoBttn.Name = "alumnoBttn";
            alumnoBttn.Size = new Size(114, 38);
            alumnoBttn.TabIndex = 14;
            alumnoBttn.Text = "Inscribirse a Curso";
            alumnoBttn.UseVisualStyleBackColor = true;
            alumnoBttn.Click += alumnoBttn_Click;
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
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(382, 379);
            Controls.Add(reporteCursosButton);
            Controls.Add(alumnoBttn);
            Controls.Add(profesorBttn);
            Controls.Add(dictadoBttn);
            Controls.Add(inscripcionBttn);
            Controls.Add(comButton);
            Controls.Add(especialidadButton);
            Controls.Add(ModulosButton);
            Controls.Add(bttnCursos);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(materiaButton);
            Controls.Add(usuarioButton);
            Name = "Inicio";
            Text = "Academia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button usuarioButton;
        private Button materiaButton;
        private Button btnClose;
        private Label label1;
        private Button button1;
        private Button bttnCursos;
        private Button ModulosButton;
        private Button especialidadButton;
        private Button comButton;
        private Button inscripcionBttn;
        private Button dictadoBttn;
        private Button profesorBttn;
        private Button alumnoBttn;
        private Button reporteCursosButton;
    }
}