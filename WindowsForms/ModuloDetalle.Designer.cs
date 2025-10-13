namespace WindowsForms
{
    partial class ModuloDetalle
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
            idLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            idTextBox = new TextBox();
            descTextBox = new TextBox();
            ejecutaTextBox = new TextBox();
            aceptarButton = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(66, 12);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(17, 15);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 60);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 105);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Ejecuta";
            // 
            // idTextBox
            // 
            idTextBox.Enabled = false;
            idTextBox.Location = new Point(89, 12);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(100, 23);
            idTextBox.TabIndex = 3;
            // 
            // descTextBox
            // 
            descTextBox.Location = new Point(89, 60);
            descTextBox.Name = "descTextBox";
            descTextBox.Size = new Size(100, 23);
            descTextBox.TabIndex = 4;
            // 
            // ejecutaTextBox
            // 
            ejecutaTextBox.Location = new Point(89, 102);
            ejecutaTextBox.Name = "ejecutaTextBox";
            ejecutaTextBox.Size = new Size(100, 23);
            ejecutaTextBox.TabIndex = 5;
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(208, 163);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(75, 23);
            aceptarButton.TabIndex = 6;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ModuloDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 200);
            Controls.Add(aceptarButton);
            Controls.Add(ejecutaTextBox);
            Controls.Add(descTextBox);
            Controls.Add(idTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(idLabel);
            Name = "ModuloDetalle";
            Text = "ModuloDetalle";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idLabel;
        private Label label2;
        private Label label3;
        private TextBox idTextBox;
        private TextBox descTextBox;
        private TextBox ejecutaTextBox;
        private Button aceptarButton;
        private ErrorProvider errorProvider1;
    }
}