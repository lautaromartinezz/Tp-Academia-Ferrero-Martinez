namespace WindowsForms
{
    partial class EspecialidadDetalle
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


        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            aceptarButton = new Button();
            errorProvider = new ErrorProvider(components);
            cancelarButton = new Button();
            idLabel = new Label();
            idTextBox = new TextBox();
            descEspecialidadLabel = new Label();
            descEspecialidadTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(189, 117);
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
            cancelarButton.Location = new Point(274, 117);
            cancelarButton.Margin = new Padding(2, 1, 2, 1);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(81, 22);
            cancelarButton.TabIndex = 70;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
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
            // descEspecialidadLabel
            // 
            descEspecialidadLabel.AutoSize = true;
            descEspecialidadLabel.Location = new Point(26, 57);
            descEspecialidadLabel.Name = "descEspecialidadLabel";
            descEspecialidadLabel.Size = new Size(69, 15);
            descEspecialidadLabel.TabIndex = 71;
            descEspecialidadLabel.Text = "Descripcion";
            // 
            // descEspecialidadTextBox
            // 
            descEspecialidadTextBox.Location = new Point(131, 54);
            descEspecialidadTextBox.Name = "descEspecialidadTextBox";
            descEspecialidadTextBox.Size = new Size(110, 23);
            descEspecialidadTextBox.TabIndex = 72;
            // 
            // EspecialidadDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 149);
            Controls.Add(descEspecialidadTextBox);
            Controls.Add(descEspecialidadLabel);
            Controls.Add(idLabel);
            Controls.Add(idTextBox);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Margin = new Padding(2, 1, 2, 1);
            Name = "EspecialidadDetalle";
            Text = "Curso";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        private TextBox descripcionTextBox;
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Label idLabel;
        private TextBox idTextBox;
        private Label descEspecialidadLabel;
        private TextBox descEspecialidadTextBox;
    }
}