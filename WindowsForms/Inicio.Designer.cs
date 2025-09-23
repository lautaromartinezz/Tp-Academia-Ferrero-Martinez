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
            btnClose.Location = new Point(694, 403);
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
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(800, 450);
            Controls.Add(bttnCursos);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(materiaButton);
            Controls.Add(usuarioButton);
            Name = "Inicio";
            Text = "Academia";
            Load += Inicio_Load;
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
    }
}