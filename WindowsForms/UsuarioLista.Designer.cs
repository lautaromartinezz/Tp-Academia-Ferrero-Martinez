namespace WindowsForms
{
    partial class UsuarioLista
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usuarioDataGridView = new DataGridView();
            agregarButton = new Button();
            eliminarButton = new Button();
            modificarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)usuarioDataGridView).BeginInit();
            SuspendLayout();
            // 
            // usuarioDataGridView
            // 
            usuarioDataGridView.AllowUserToOrderColumns = true;
            usuarioDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usuarioDataGridView.Location = new Point(21, 18);
            usuarioDataGridView.Margin = new Padding(2, 1, 2, 1);
            usuarioDataGridView.MultiSelect = false;
            usuarioDataGridView.Name = "usuarioDataGridView";
            usuarioDataGridView.ReadOnly = true;
            usuarioDataGridView.RowHeadersWidth = 82;
            usuarioDataGridView.RowTemplate.Height = 41;
            usuarioDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            usuarioDataGridView.Size = new Size(751, 270);
            usuarioDataGridView.TabIndex = 0;
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
            // UsuarioLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 402);
            Controls.Add(modificarButton);
            Controls.Add(eliminarButton);
            Controls.Add(agregarButton);
            Controls.Add(usuarioDataGridView);
            Margin = new Padding(2, 1, 2, 1);
            Name = "UsuarioLista";
            Text = "Usuarios";
            Load += Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)usuarioDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView usuarioDataGridView;
        private Button agregarButton;
        private Button eliminarButton;
        private Button modificarButton;
    }
}