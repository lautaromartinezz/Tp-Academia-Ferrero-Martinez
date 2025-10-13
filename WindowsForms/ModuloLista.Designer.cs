namespace WindowsForms
{
    partial class ModuloLista
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
            ModuloDataGridView = new DataGridView();
            AgregarButton = new Button();
            EditarModulo = new Button();
            EliminarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ModuloDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ModuloDataGridView
            // 
            ModuloDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ModuloDataGridView.Location = new Point(32, 26);
            ModuloDataGridView.Name = "ModuloDataGridView";
            ModuloDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ModuloDataGridView.Size = new Size(603, 266);
            ModuloDataGridView.TabIndex = 0;
            // 
            // AgregarButton
            // 
            AgregarButton.Location = new Point(660, 345);
            AgregarButton.Name = "AgregarButton";
            AgregarButton.Size = new Size(111, 46);
            AgregarButton.TabIndex = 1;
            AgregarButton.Text = "Agregar Modulo";
            AgregarButton.UseVisualStyleBackColor = true;
            AgregarButton.Click += AgregarButton_Click;
            // 
            // EditarModulo
            // 
            EditarModulo.Location = new Point(544, 345);
            EditarModulo.Name = "EditarModulo";
            EditarModulo.Size = new Size(110, 46);
            EditarModulo.TabIndex = 2;
            EditarModulo.Text = "Editar Modulo";
            EditarModulo.UseVisualStyleBackColor = true;
            EditarModulo.Click += EditarModulo_Click;
            // 
            // EliminarButton
            // 
            EliminarButton.Location = new Point(434, 345);
            EliminarButton.Name = "EliminarButton";
            EliminarButton.Size = new Size(104, 46);
            EliminarButton.TabIndex = 3;
            EliminarButton.Text = "Eliminar Modulo";
            EliminarButton.UseVisualStyleBackColor = true;
            EliminarButton.Click += EliminarButton_Click;
            // 
            // ModuloLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 432);
            Controls.Add(EliminarButton);
            Controls.Add(EditarModulo);
            Controls.Add(AgregarButton);
            Controls.Add(ModuloDataGridView);
            Name = "ModuloLista";
            Text = "ModuloLista";
            ((System.ComponentModel.ISupportInitialize)ModuloDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ModuloDataGridView;
        private Button AgregarButton;
        private Button EditarModulo;
        private Button EliminarButton;
    }
}