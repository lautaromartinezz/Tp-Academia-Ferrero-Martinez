namespace WindowsForms
{
    partial class PlanDetalle
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
            descLabel = new Label();
            descTextBox = new TextBox();
            idLabel = new Label();
            idTextBox = new TextBox();
            idEspecialidadLabel = new Label();
            especialidadComboBox = new ComboBox();
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
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Location = new Point(24, 49);
            descLabel.Margin = new Padding(2, 0, 2, 0);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(69, 15);
            descLabel.TabIndex = 5;
            descLabel.Text = "Descripcion";
            // 
            // descTextBox
            // 
            descTextBox.Location = new Point(130, 46);
            descTextBox.Margin = new Padding(2, 1, 2, 1);
            descTextBox.Name = "descTextBox";
            descTextBox.Size = new Size(110, 23);
            descTextBox.TabIndex = 20;
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
            // idEspecialidadLabel
            // 
            idEspecialidadLabel.AutoSize = true;
            idEspecialidadLabel.Location = new Point(24, 78);
            idEspecialidadLabel.Margin = new Padding(2, 0, 2, 0);
            idEspecialidadLabel.Name = "idEspecialidadLabel";
            idEspecialidadLabel.Size = new Size(94, 15);
            idEspecialidadLabel.TabIndex = 13;
            idEspecialidadLabel.Text = "Especialidad (ID)";
            // 
            // especialidadComboBox
            // 
            especialidadComboBox.FormattingEnabled = true;
            especialidadComboBox.Location = new Point(130, 75);
            especialidadComboBox.Name = "especialidadComboBox";
            especialidadComboBox.Size = new Size(111, 23);
            especialidadComboBox.TabIndex = 71;
            // 
            // PlanDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 236);
            Controls.Add(especialidadComboBox);
            Controls.Add(idEspecialidadLabel);
            Controls.Add(idLabel);
            Controls.Add(idTextBox);
            Controls.Add(descLabel);
            Controls.Add(descTextBox);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Margin = new Padding(2, 1, 2, 1);
            Name = "PlanDetalle";
            Text = "Curso";
            Load += PlanDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descripcionTextBox;
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Label descLabel;
        private TextBox descTextBox;
        private Label idLabel;
        private TextBox idTextBox;
        private Label idEspecialidadLabel;
        private ComboBox especialidadComboBox;
    }
}
