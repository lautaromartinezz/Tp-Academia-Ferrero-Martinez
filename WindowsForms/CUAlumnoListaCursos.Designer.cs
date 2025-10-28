namespace WindowsForms
{
    partial class CUAlumnoListaCursos
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
            cursoDataGridView = new DataGridView();
            inscButton = new Button();
            ((System.ComponentModel.ISupportInitialize)cursoDataGridView).BeginInit();
            SuspendLayout();
            // 
            // cursoDataGridView
            // 
            cursoDataGridView.AllowUserToOrderColumns = true;
            cursoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cursoDataGridView.Location = new Point(21, 18);
            cursoDataGridView.Margin = new Padding(2, 1, 2, 1);
            cursoDataGridView.MultiSelect = false;
            cursoDataGridView.Name = "cursoDataGridView";
            cursoDataGridView.ReadOnly = true;
            cursoDataGridView.RowHeadersWidth = 82;
            cursoDataGridView.RowTemplate.Height = 41;
            cursoDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cursoDataGridView.Size = new Size(751, 270);
            cursoDataGridView.TabIndex = 0;
            // 
            // inscButton
            // 
            inscButton.Location = new Point(598, 300);
            inscButton.Margin = new Padding(2, 1, 2, 1);
            inscButton.Name = "inscButton";
            inscButton.Size = new Size(81, 22);
            inscButton.TabIndex = 3;
            inscButton.Text = "Inscribirse";
            inscButton.UseVisualStyleBackColor = true;
            inscButton.Click += crearInscButton_Click;
            // 
            // CUAlumnoListaCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 402);
            Controls.Add(inscButton);
            Controls.Add(cursoDataGridView);
            Margin = new Padding(2, 1, 2, 1);
            Name = "CUAlumnoListaCursos";
            Text = "Cursos";
            Load += Cursos_Load;
            ((System.ComponentModel.ISupportInitialize)cursoDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView cursoDataGridView;
        private Button inscButton;
    }
}