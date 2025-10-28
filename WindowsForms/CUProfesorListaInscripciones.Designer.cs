namespace WindowsForms
{
    partial class CUProfesorListaInscripciones
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
            inscripcionDataGridView = new DataGridView();
            modificarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)inscripcionDataGridView).BeginInit();
            SuspendLayout();
            // 
            // inscripcionDataGridView
            // 
            inscripcionDataGridView.AllowUserToOrderColumns = true;
            inscripcionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inscripcionDataGridView.Location = new Point(21, 18);
            inscripcionDataGridView.Margin = new Padding(2, 1, 2, 1);
            inscripcionDataGridView.MultiSelect = false;
            inscripcionDataGridView.Name = "inscripcionDataGridView";
            inscripcionDataGridView.ReadOnly = true;
            inscripcionDataGridView.RowHeadersWidth = 82;
            inscripcionDataGridView.RowTemplate.Height = 41;
            inscripcionDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            inscripcionDataGridView.Size = new Size(751, 270);
            inscripcionDataGridView.TabIndex = 0;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(598, 300);
            modificarButton.Margin = new Padding(2, 1, 2, 1);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(107, 24);
            modificarButton.TabIndex = 3;
            modificarButton.Text = "Modificar Nota";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // CUProfesorListaInscripciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 402);
            Controls.Add(modificarButton);
            Controls.Add(inscripcionDataGridView);
            Margin = new Padding(2, 1, 2, 1);
            Name = "CUProfesorListaInscripciones";
            Text = "Alumnos inscriptos";
            Load += Inscripcion_Load;
            ((System.ComponentModel.ISupportInitialize)inscripcionDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView inscripcionDataGridView;
        private Button modificarButton;
    }
}