namespace WindowsForms
{
    partial class DictadoDetalle
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
            idProfesorLabel = new Label();
            idLabel = new Label();
            idTextBox = new TextBox();
            idCursoLabel = new Label();
            cargoTextBox = new TextBox();
            cargoLabel = new Label();
            profesorComboBox = new ComboBox();
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
            // idProfesorLabel
            // 
            idProfesorLabel.AutoSize = true;
            idProfesorLabel.Location = new Point(24, 83);
            idProfesorLabel.Margin = new Padding(2, 0, 2, 0);
            idProfesorLabel.Name = "idProfesorLabel";
            idProfesorLabel.Size = new Size(73, 15);
            idProfesorLabel.TabIndex = 7;
            idProfesorLabel.Text = "Profesor (ID)";
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
            // idCursoLabel
            // 
            idCursoLabel.AutoSize = true;
            idCursoLabel.Location = new Point(24, 118);
            idCursoLabel.Margin = new Padding(2, 0, 2, 0);
            idCursoLabel.Name = "idCursoLabel";
            idCursoLabel.Size = new Size(60, 15);
            idCursoLabel.TabIndex = 72;
            idCursoLabel.Text = "Curso (ID)";
            // 
            // cargoTextBox
            // 
            cargoTextBox.Location = new Point(131, 55);
            cargoTextBox.Margin = new Padding(2, 1, 2, 1);
            cargoTextBox.Name = "cargoTextBox";
            cargoTextBox.Size = new Size(110, 23);
            cargoTextBox.TabIndex = 74;
            // 
            // cargoLabel
            // 
            cargoLabel.AutoSize = true;
            cargoLabel.Location = new Point(25, 58);
            cargoLabel.Margin = new Padding(2, 0, 2, 0);
            cargoLabel.Name = "cargoLabel";
            cargoLabel.Size = new Size(39, 15);
            cargoLabel.TabIndex = 75;
            cargoLabel.Text = "Cargo";
            // 
            // profesorComboBox
            // 
            profesorComboBox.FormattingEnabled = true;
            profesorComboBox.Location = new Point(131, 82);
            profesorComboBox.Name = "profesorComboBox";
            profesorComboBox.Size = new Size(110, 23);
            profesorComboBox.TabIndex = 76;
            // 
            // cursoComboBox
            // 
            cursoComboBox.FormattingEnabled = true;
            cursoComboBox.Location = new Point(131, 112);
            cursoComboBox.Name = "cursoComboBox";
            cursoComboBox.Size = new Size(109, 23);
            cursoComboBox.TabIndex = 77;
            // 
            // DictadoDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 236);
            Controls.Add(cursoComboBox);
            Controls.Add(profesorComboBox);
            Controls.Add(cargoLabel);
            Controls.Add(cargoTextBox);
            Controls.Add(idCursoLabel);
            Controls.Add(idLabel);
            Controls.Add(idTextBox);
            Controls.Add(idProfesorLabel);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Margin = new Padding(2, 1, 2, 1);
            Name = "DictadoDetalle";
            Text = "Curso";
            Load += DictadoDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descripcionTextBox;
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Label idProfesorLabel;
        private Label idLabel;
        private TextBox idTextBox;
        private Label idCursoLabel;
        private Label cargoLabel;
        private TextBox cargoTextBox;
        private ComboBox cursoComboBox;
        private ComboBox profesorComboBox;
    }
}