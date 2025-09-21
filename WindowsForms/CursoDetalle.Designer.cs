namespace WindowsForms
{
    partial class CursoDetalle
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
            anioCalendarioLabel = new Label();
            aceptarButton = new Button();
            errorProvider = new ErrorProvider(components);
            cancelarButton = new Button();
            cupoLabel = new Label();
            cupoTextBox = new TextBox();
            idMateriaLabel = new Label();
            idLabel = new Label();
            idTextBox = new TextBox();
            idComisionLabel = new Label();
            idComisionTextBox = new TextBox();
            idMateriaTextBox = new TextBox();
            anioCalendarioTimePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // anioCalendarioLabel
            // 
            anioCalendarioLabel.AutoSize = true;
            anioCalendarioLabel.Location = new Point(24, 51);
            anioCalendarioLabel.Margin = new Padding(2, 0, 2, 0);
            anioCalendarioLabel.Name = "anioCalendarioLabel";
            anioCalendarioLabel.Size = new Size(89, 15);
            anioCalendarioLabel.TabIndex = 1;
            anioCalendarioLabel.Text = "Año Calendario";
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
            // 
            // cupoLabel
            // 
            cupoLabel.AutoSize = true;
            cupoLabel.Location = new Point(24, 82);
            cupoLabel.Margin = new Padding(2, 0, 2, 0);
            cupoLabel.Name = "cupoLabel";
            cupoLabel.Size = new Size(36, 15);
            cupoLabel.TabIndex = 5;
            cupoLabel.Text = "Cupo";
            // 
            // cupoTextBox
            // 
            cupoTextBox.Location = new Point(131, 82);
            cupoTextBox.Margin = new Padding(2, 1, 2, 1);
            cupoTextBox.Name = "cupoTextBox";
            cupoTextBox.Size = new Size(110, 23);
            cupoTextBox.TabIndex = 20;
            // 
            // idMateriaLabel
            // 
            idMateriaLabel.AutoSize = true;
            idMateriaLabel.Location = new Point(24, 147);
            idMateriaLabel.Margin = new Padding(2, 0, 2, 0);
            idMateriaLabel.Name = "idMateriaLabel";
            idMateriaLabel.Size = new Size(69, 15);
            idMateriaLabel.TabIndex = 7;
            idMateriaLabel.Text = "Materia (ID)";
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
            // idComisionLabel
            // 
            idComisionLabel.AutoSize = true;
            idComisionLabel.Location = new Point(24, 111);
            idComisionLabel.Margin = new Padding(2, 0, 2, 0);
            idComisionLabel.Name = "idComisionLabel";
            idComisionLabel.Size = new Size(80, 15);
            idComisionLabel.TabIndex = 13;
            idComisionLabel.Text = "Comision (ID)";
            // 
            // idComisionTextBox
            // 
            idComisionTextBox.Location = new Point(131, 111);
            idComisionTextBox.Margin = new Padding(2, 1, 2, 1);
            idComisionTextBox.Name = "idComisionTextBox";
            idComisionTextBox.Size = new Size(110, 23);
            idComisionTextBox.TabIndex = 30;
            // 
            // idMateriaTextBox
            // 
            idMateriaTextBox.Location = new Point(131, 147);
            idMateriaTextBox.Margin = new Padding(2, 1, 2, 1);
            idMateriaTextBox.Name = "idMateriaTextBox";
            idMateriaTextBox.Size = new Size(110, 23);
            idMateriaTextBox.TabIndex = 71;
            // 
            // anioCalendarioTimePicker
            // 
            anioCalendarioTimePicker.Location = new Point(131, 51);
            anioCalendarioTimePicker.Name = "anioCalendarioTimePicker";
            anioCalendarioTimePicker.Size = new Size(200, 23);
            anioCalendarioTimePicker.TabIndex = 72;
            // 
            // CursoDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 236);
            Controls.Add(anioCalendarioTimePicker);
            Controls.Add(idMateriaTextBox);
            Controls.Add(idComisionLabel);
            Controls.Add(idComisionTextBox);
            Controls.Add(idLabel);
            Controls.Add(idTextBox);
            Controls.Add(idMateriaLabel);
            Controls.Add(cupoLabel);
            Controls.Add(cupoTextBox);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(anioCalendarioLabel);
            Margin = new Padding(2, 1, 2, 1);
            Name = "CursoDetalle";
            Text = "Curso";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descripcionTextBox;
        private Label anioCalendarioLabel;
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Label cupoLabel;
        private TextBox cupoTextBox;
        private Label idMateriaLabel;
        private Label idLabel;
        private TextBox idTextBox;
        private Label idComisionLabel;
        private TextBox idComisionTextBox;
        private TextBox idMateriaTextBox;
        private DateTimePicker anioCalendarioTimePicker;
    }
}
