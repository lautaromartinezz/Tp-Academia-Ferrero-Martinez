namespace WindowsForms
{
    partial class ComisionDetalle
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
            anioEspecialidadLabel = new Label();
            anioEspTextBox = new TextBox();
            idLabel = new Label();
            idTextBox = new TextBox();
            idPlanLabel = new Label();
            idPlanTextBox = new TextBox();
            descripcionLabel = new Label();
            descTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(181, 156);
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
            cancelarButton.Location = new Point(266, 156);
            cancelarButton.Margin = new Padding(2, 1, 2, 1);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(81, 22);
            cancelarButton.TabIndex = 70;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // anioEspecialidadLabel
            // 
            anioEspecialidadLabel.AutoSize = true;
            anioEspecialidadLabel.Location = new Point(24, 82);
            anioEspecialidadLabel.Margin = new Padding(2, 0, 2, 0);
            anioEspecialidadLabel.Name = "anioEspecialidadLabel";
            anioEspecialidadLabel.Size = new Size(97, 15);
            anioEspecialidadLabel.TabIndex = 5;
            anioEspecialidadLabel.Text = "Año Especialidad";
            // 
            // anioEspTextBox
            // 
            anioEspTextBox.Location = new Point(131, 79);
            anioEspTextBox.Margin = new Padding(2, 1, 2, 1);
            anioEspTextBox.Name = "anioEspTextBox";
            anioEspTextBox.Size = new Size(110, 23);
            anioEspTextBox.TabIndex = 20;
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
            // idPlanLabel
            // 
            idPlanLabel.AutoSize = true;
            idPlanLabel.Location = new Point(24, 111);
            idPlanLabel.Margin = new Padding(2, 0, 2, 0);
            idPlanLabel.Name = "idPlanLabel";
            idPlanLabel.Size = new Size(52, 15);
            idPlanLabel.TabIndex = 13;
            idPlanLabel.Text = "Plan (ID)";
            // 
            // idPlanTextBox
            // 
            idPlanTextBox.Location = new Point(131, 108);
            idPlanTextBox.Margin = new Padding(2, 1, 2, 1);
            idPlanTextBox.Name = "idPlanTextBox";
            idPlanTextBox.Size = new Size(110, 23);
            idPlanTextBox.TabIndex = 30;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new Point(24, 51);
            descripcionLabel.Margin = new Padding(2, 0, 2, 0);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new Size(69, 15);
            descripcionLabel.TabIndex = 71;
            descripcionLabel.Text = "Descripcion";
            descripcionLabel.Click += label1_Click;
            // 
            // descTextBox
            // 
            descTextBox.Location = new Point(131, 48);
            descTextBox.Margin = new Padding(2, 1, 2, 1);
            descTextBox.Name = "descTextBox";
            descTextBox.Size = new Size(110, 23);
            descTextBox.TabIndex = 72;
            // 
            // ComisionDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 188);
            Controls.Add(descTextBox);
            Controls.Add(descripcionLabel);
            Controls.Add(idPlanLabel);
            Controls.Add(idPlanTextBox);
            Controls.Add(idLabel);
            Controls.Add(idTextBox);
            Controls.Add(anioEspecialidadLabel);
            Controls.Add(anioEspTextBox);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Margin = new Padding(2, 1, 2, 1);
            Name = "ComisionDetalle";
            Text = "Curso";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descripcionTextBox;
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Label anioEspecialidadLabel;
        private TextBox anioEspTextBox;
        private Label idLabel;
        private TextBox idTextBox;
        private Label idPlanLabel;
        private TextBox idPlanTextBox;
        private TextBox descTextBox;
        private Label descripcionLabel;
    }
}