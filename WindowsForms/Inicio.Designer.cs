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
            label1 = new Label();
            materiaLabel = new Label();
            materiaButton = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // usuarioButton
            // 
            usuarioButton.Location = new Point(163, 214);
            usuarioButton.Name = "usuarioButton";
            usuarioButton.Size = new Size(114, 40);
            usuarioButton.TabIndex = 0;
            usuarioButton.Text = "Usuarios";
            usuarioButton.UseVisualStyleBackColor = true;
            usuarioButton.Click += usuarioButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F);
            label1.Location = new Point(92, 175);
            label1.Name = "label1";
            label1.Size = new Size(265, 36);
            label1.TabIndex = 1;
            label1.Text = "Ver todos los usuarios";
            // 
            // materiaLabel
            // 
            materiaLabel.AutoSize = true;
            materiaLabel.Font = new Font("Segoe UI", 19F);
            materiaLabel.Location = new Point(421, 175);
            materiaLabel.Name = "materiaLabel";
            materiaLabel.Size = new Size(263, 36);
            materiaLabel.TabIndex = 3;
            materiaLabel.Text = "Ver todas las materias";
            // 
            // materiaButton
            // 
            materiaButton.Location = new Point(492, 214);
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
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(materiaLabel);
            Controls.Add(materiaButton);
            Controls.Add(label1);
            Controls.Add(usuarioButton);
            Name = "Inicio";
            Text = "Academia";
            Load += Inicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button usuarioButton;
        private Label label1;
        private Label materiaLabel;
        private Button materiaButton;
        private Button btnClose;
    }
}