namespace WindowsForms
{
    partial class EspecialidadLista
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
            especialidadDataGridView = new DataGridView();
            agregarButton = new Button();
            eliminarButton = new Button();
            modificarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)especialidadDataGridView).BeginInit();
            SuspendLayout();
            // 
            // especialidadDataGridView
            // 
            especialidadDataGridView.AllowUserToOrderColumns = true;
            especialidadDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            especialidadDataGridView.Location = new Point(21, 18);
            especialidadDataGridView.Margin = new Padding(2, 1, 2, 1);
            especialidadDataGridView.MultiSelect = false;
            especialidadDataGridView.Name = "especialidadDataGridView";
            especialidadDataGridView.ReadOnly = true;
            especialidadDataGridView.RowHeadersWidth = 82;
            especialidadDataGridView.RowTemplate.Height = 41;
            especialidadDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            especialidadDataGridView.Size = new Size(751, 270);
            especialidadDataGridView.TabIndex = 0;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(691, 300);
            agregarButton.Margin = new Padding(2, 1, 2, 1);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(81, 22);
            agregarButton.TabIndex = 1;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(506, 300);
            eliminarButton.Margin = new Padding(2, 1, 2, 1);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(81, 22);
            eliminarButton.TabIndex = 2;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(598, 300);
            modificarButton.Margin = new Padding(2, 1, 2, 1);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(81, 22);
            modificarButton.TabIndex = 3;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // MateriaLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 402);
            Controls.Add(modificarButton);
            Controls.Add(eliminarButton);
            Controls.Add(agregarButton);
            Controls.Add(especialidadDataGridView);
            Margin = new Padding(2, 1, 2, 1);
            Name = "EspecialidadLista";
            Text = "Especialidades";
            Load += Especialidad_Load;
            ((System.ComponentModel.ISupportInitialize)especialidadDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView especialidadDataGridView;
        private Button agregarButton;
        private Button eliminarButton;
        private Button modificarButton;
    }
}