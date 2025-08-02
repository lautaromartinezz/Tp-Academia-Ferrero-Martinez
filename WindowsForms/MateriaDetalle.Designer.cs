namespace WindowsForms
{
    partial class MateriaDetalle
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
            descripcionTextBox = new TextBox();
            nombreLabel = new Label();
            aceptarButton = new Button();
            errorProvider = new ErrorProvider(components);
            cancelarButton = new Button();
            hsSemanalesLabel = new Label();
            hsSemanalesTextBox = new TextBox();
            idPlanLabel = new Label();
            idLabel = new Label();
            idTextBox = new TextBox();
            hsTotalesLabel = new Label();
            hsTotalesTextBox = new TextBox();
            idPlanTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // descripcionTextBox
            // 
            descripcionTextBox.Location = new Point(131, 51);
            descripcionTextBox.Margin = new Padding(2, 1, 2, 1);
            descripcionTextBox.Name = "descripcionTextBox";
            descripcionTextBox.Size = new Size(110, 23);
            descripcionTextBox.TabIndex = 10;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(24, 51);
            nombreLabel.Margin = new Padding(2, 0, 2, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(69, 15);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Descripcion";
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
            // hsSemanalesLabel
            // 
            hsSemanalesLabel.AutoSize = true;
            hsSemanalesLabel.Location = new Point(24, 82);
            hsSemanalesLabel.Margin = new Padding(2, 0, 2, 0);
            hsSemanalesLabel.Name = "hsSemanalesLabel";
            hsSemanalesLabel.Size = new Size(97, 15);
            hsSemanalesLabel.TabIndex = 5;
            hsSemanalesLabel.Text = "Horas Semanales";
            // 
            // hsSemanalesTextBox
            // 
            hsSemanalesTextBox.Location = new Point(131, 82);
            hsSemanalesTextBox.Margin = new Padding(2, 1, 2, 1);
            hsSemanalesTextBox.Name = "hsSemanalesTextBox";
            hsSemanalesTextBox.Size = new Size(110, 23);
            hsSemanalesTextBox.TabIndex = 20;
            // 
            // idPlanLabel
            // 
            idPlanLabel.AutoSize = true;
            idPlanLabel.Location = new Point(24, 147);
            idPlanLabel.Margin = new Padding(2, 0, 2, 0);
            idPlanLabel.Name = "idPlanLabel";
            idPlanLabel.Size = new Size(44, 15);
            idPlanLabel.TabIndex = 7;
            idPlanLabel.Text = "ID Plan";
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
            // hsTotalesLabel
            // 
            hsTotalesLabel.AutoSize = true;
            hsTotalesLabel.Location = new Point(24, 111);
            hsTotalesLabel.Margin = new Padding(2, 0, 2, 0);
            hsTotalesLabel.Name = "hsTotalesLabel";
            hsTotalesLabel.Size = new Size(77, 15);
            hsTotalesLabel.TabIndex = 13;
            hsTotalesLabel.Text = "Horas Totales";
            // 
            // hsTotalesTextBox
            // 
            hsTotalesTextBox.Location = new Point(131, 111);
            hsTotalesTextBox.Margin = new Padding(2, 1, 2, 1);
            hsTotalesTextBox.Name = "hsTotalesTextBox";
            hsTotalesTextBox.Size = new Size(110, 23);
            hsTotalesTextBox.TabIndex = 30;
            // 
            // idPlanTextBox
            // 
            idPlanTextBox.Location = new Point(131, 147);
            idPlanTextBox.Margin = new Padding(2, 1, 2, 1);
            idPlanTextBox.Name = "idPlanTextBox";
            idPlanTextBox.Size = new Size(110, 23);
            idPlanTextBox.TabIndex = 71;
            // 
            // MateriaDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 236);
            Controls.Add(idPlanTextBox);
            Controls.Add(hsTotalesLabel);
            Controls.Add(hsTotalesTextBox);
            Controls.Add(idLabel);
            Controls.Add(idTextBox);
            Controls.Add(idPlanLabel);
            Controls.Add(hsSemanalesLabel);
            Controls.Add(hsSemanalesTextBox);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(nombreLabel);
            Controls.Add(descripcionTextBox);
            Margin = new Padding(2, 1, 2, 1);
            Name = "MateriaDetalle";
            Text = "Materia";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descripcionTextBox;
        private Label nombreLabel;
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Label hsSemanalesLabel;
        private TextBox hsSemanalesTextBox;
        private Label idPlanLabel;
        private Label idLabel;
        private TextBox idTextBox;
        private Label hsTotalesLabel;
        private TextBox hsTotalesTextBox;
        private TextBox idPlanTextBox;
    }
}