namespace WindowsForms
{
    partial class CUProfesorListaDictados
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
            dictadoDataGridView = new DataGridView();
            verCursoButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dictadoDataGridView).BeginInit();
            SuspendLayout();
            // 
            // dictadoDataGridView
            // 
            dictadoDataGridView.AllowUserToOrderColumns = true;
            dictadoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dictadoDataGridView.Location = new Point(21, 18);
            dictadoDataGridView.Margin = new Padding(2, 1, 2, 1);
            dictadoDataGridView.MultiSelect = false;
            dictadoDataGridView.Name = "dictadoDataGridView";
            dictadoDataGridView.ReadOnly = true;
            dictadoDataGridView.RowHeadersWidth = 82;
            dictadoDataGridView.RowTemplate.Height = 41;
            dictadoDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dictadoDataGridView.Size = new Size(751, 270);
            dictadoDataGridView.TabIndex = 0;
            // 
            // verCursoButton
            // 
            verCursoButton.Location = new Point(598, 300);
            verCursoButton.Margin = new Padding(2, 1, 2, 1);
            verCursoButton.Name = "verCursoButton";
            verCursoButton.Size = new Size(81, 22);
            verCursoButton.TabIndex = 3;
            verCursoButton.Text = "Ver Curso";
            verCursoButton.UseVisualStyleBackColor = true;
            verCursoButton.Click += modificarButton_Click;
            // 
            // CUProfesorLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 402);
            Controls.Add(verCursoButton);
            Controls.Add(dictadoDataGridView);
            Margin = new Padding(2, 1, 2, 1);
            Name = "CUProfesorLista";
            Text = "Cursos";
            Load += Cursos_Load;
            ((System.ComponentModel.ISupportInitialize)dictadoDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dictadoDataGridView;
        private Button verCursoButton;
    }
}