namespace WindowsForms
{
    partial class InscripcionDetalle
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
            components = new System.ComponentModel.Container();
            aceptarButton = new Button();
            errorProvider = new ErrorProvider(components);
            cancelarButton = new Button();
            notaLabel = new Label();
            notaTextBox = new TextBox();
            idAlumnoLabel = new Label();
            idLabel = new Label();
            idTextBox = new TextBox();
            situacionLabel = new Label();
            SituacionTextBox = new TextBox();
            idCursoLabel = new Label();
            alumnoComboBox = new ComboBox();
            cursoComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(239, 199);
            aceptarButton.Margin = new Padding(2, 1, 2, 1);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(81, 22);
            aceptarButton.TabIndex = 60;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(331, 199);
            cancelarButton.Margin = new Padding(2, 1, 2, 1);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(81, 22);
            cancelarButton.TabIndex = 70;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // notaLabel
            // 
            notaLabel.AutoSize = true;
            notaLabel.Location = new Point(24, 49);
            notaLabel.Margin = new Padding(2, 0, 2, 0);
            notaLabel.Name = "notaLabel";
            notaLabel.Size = new Size(33, 15);
            notaLabel.TabIndex = 5;
            notaLabel.Text = "Nota";
            // 
            // notaTextBox
            // 
            notaTextBox.Location = new Point(131, 46);
            notaTextBox.Margin = new Padding(2, 1, 2, 1);
            notaTextBox.Name = "notaTextBox";
            notaTextBox.Size = new Size(110, 23);
            notaTextBox.TabIndex = 20;
            // 
            // idAlumnoLabel
            // 
            idAlumnoLabel.AutoSize = true;
            idAlumnoLabel.Location = new Point(24, 114);
            idAlumnoLabel.Margin = new Padding(2, 0, 2, 0);
            idAlumnoLabel.Name = "idAlumnoLabel";
            idAlumnoLabel.Size = new Size(72, 15);
            idAlumnoLabel.TabIndex = 7;
            idAlumnoLabel.Text = "Alumno (ID)";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(24, 15);
            idLabel.Margin = new Padding(2, 0, 2, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(17, 15);
            idLabel.TabIndex = 11;
            idLabel.Text = "Id";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(131, 15);
            idTextBox.Margin = new Padding(2, 1, 2, 1);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(110, 23);
            idTextBox.TabIndex = 0;
            idTextBox.TabStop = false;
            // 
            // situacionLabel
            // 
            situacionLabel.AutoSize = true;
            situacionLabel.Location = new Point(24, 83);
            situacionLabel.Margin = new Padding(2, 0, 2, 0);
            situacionLabel.Name = "situacionLabel";
            situacionLabel.Size = new Size(56, 15);
            situacionLabel.TabIndex = 13;
            situacionLabel.Text = "Situacion";
            // 
            // SituacionTextBox
            // 
            SituacionTextBox.Location = new Point(131, 80);
            SituacionTextBox.Margin = new Padding(2, 1, 2, 1);
            SituacionTextBox.Name = "SituacionTextBox";
            SituacionTextBox.Size = new Size(110, 23);
            SituacionTextBox.TabIndex = 30;
            // 
            // idCursoLabel
            // 
            idCursoLabel.AutoSize = true;
            idCursoLabel.Location = new Point(24, 149);
            idCursoLabel.Margin = new Padding(2, 0, 2, 0);
            idCursoLabel.Name = "idCursoLabel";
            idCursoLabel.Size = new Size(60, 15);
            idCursoLabel.TabIndex = 72;
            idCursoLabel.Text = "Curso (ID)";
            // 
            // alumnoComboBox
            // 
            alumnoComboBox.FormattingEnabled = true;
            alumnoComboBox.Location = new Point(131, 111);
            alumnoComboBox.Name = "alumnoComboBox";
            alumnoComboBox.Size = new Size(109, 23);
            alumnoComboBox.TabIndex = 73;
            // 
            // cursoComboBox
            // 
            cursoComboBox.FormattingEnabled = true;
            cursoComboBox.Location = new Point(131, 146);
            cursoComboBox.Name = "cursoComboBox";
            cursoComboBox.Size = new Size(110, 23);
            cursoComboBox.TabIndex = 74;
            // 
            // InscripcionDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 236);
            Controls.Add(cursoComboBox);
            Controls.Add(alumnoComboBox);
            Controls.Add(idCursoLabel);
            Controls.Add(situacionLabel);
            Controls.Add(SituacionTextBox);
            Controls.Add(idLabel);
            Controls.Add(idTextBox);
            Controls.Add(idAlumnoLabel);
            Controls.Add(notaLabel);
            Controls.Add(notaTextBox);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Margin = new Padding(2, 1, 2, 1);
            Name = "InscripcionDetalle";
            Text = "Curso";
            Load += InscripcionDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descripcionTextBox;
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Label notaLabel;
        private TextBox notaTextBox;
        private Label idAlumnoLabel;
        private Label idLabel;
        private TextBox idTextBox;
        private Label situacionLabel;
        private TextBox SituacionTextBox;
        private Label idCursoLabel;
        private ComboBox cursoComboBox;
        private ComboBox alumnoComboBox;
    }
}