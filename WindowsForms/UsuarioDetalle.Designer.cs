namespace WindowsForms
{
    partial class UsuarioDetalle
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
            nombreTextBox = new TextBox();
            nombreLabel = new Label();
            aceptarButton = new Button();
            errorProvider = new ErrorProvider(components);
            cancelarButton = new Button();
            usuarioLabel = new Label();
            usuarioTextBox = new TextBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            idLabel = new Label();
            idTextBox = new TextBox();
            apellidoLabel = new Label();
            apellidoTextBox = new TextBox();
            habilitadoLabel = new Label();
            habilitadoCheckBox = new CheckBox();
            claveLabel = new Label();
            claveTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            DireccionTextBox = new TextBox();
            TelefonoTextBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            legajottextBox = new TextBox();
            tipoPersonaTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(131, 51);
            nombreTextBox.Margin = new Padding(2, 1, 2, 1);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(110, 23);
            nombreTextBox.TabIndex = 10;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(24, 51);
            nombreLabel.Margin = new Padding(2, 0, 2, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(51, 15);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre";
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(256, 377);
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
            cancelarButton.Location = new Point(341, 377);
            cancelarButton.Margin = new Padding(2, 1, 2, 1);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(81, 22);
            cancelarButton.TabIndex = 70;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new Point(24, 82);
            usuarioLabel.Margin = new Padding(2, 0, 2, 0);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new Size(47, 15);
            usuarioLabel.TabIndex = 5;
            usuarioLabel.Text = "Usuario";
            // 
            // usuarioTextBox
            // 
            usuarioTextBox.Location = new Point(131, 82);
            usuarioTextBox.Margin = new Padding(2, 1, 2, 1);
            usuarioTextBox.Name = "usuarioTextBox";
            usuarioTextBox.Size = new Size(110, 23);
            usuarioTextBox.TabIndex = 20;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(24, 147);
            emailLabel.Margin = new Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(131, 147);
            emailTextBox.Margin = new Padding(2, 1, 2, 1);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(206, 23);
            emailTextBox.TabIndex = 40;
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
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new Point(24, 111);
            apellidoLabel.Margin = new Padding(2, 0, 2, 0);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new Size(51, 15);
            apellidoLabel.TabIndex = 13;
            apellidoLabel.Text = "Apellido";
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(131, 111);
            apellidoTextBox.Margin = new Padding(2, 1, 2, 1);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(110, 23);
            apellidoTextBox.TabIndex = 30;
            // 
            // habilitadoLabel
            // 
            habilitadoLabel.AutoSize = true;
            habilitadoLabel.Location = new Point(25, 178);
            habilitadoLabel.Name = "habilitadoLabel";
            habilitadoLabel.Size = new Size(62, 15);
            habilitadoLabel.TabIndex = 14;
            habilitadoLabel.Text = "Habilitado";
            // 
            // habilitadoCheckBox
            // 
            habilitadoCheckBox.AutoSize = true;
            habilitadoCheckBox.Location = new Point(131, 177);
            habilitadoCheckBox.Name = "habilitadoCheckBox";
            habilitadoCheckBox.Size = new Size(15, 14);
            habilitadoCheckBox.TabIndex = 50;
            habilitadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.Location = new Point(25, 205);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new Size(36, 15);
            claveLabel.TabIndex = 71;
            claveLabel.Text = "Clave";
            // 
            // claveTextBox
            // 
            claveTextBox.Location = new Point(131, 202);
            claveTextBox.Margin = new Padding(2, 1, 2, 1);
            claveTextBox.Name = "claveTextBox";
            claveTextBox.Size = new Size(110, 23);
            claveTextBox.TabIndex = 72;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 238);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 73;
            label1.Text = "Direccion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 264);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 74;
            label2.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 296);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 75;
            label3.Text = "Fecha Nacimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 323);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 76;
            label4.Text = "Legajo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 351);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 77;
            label5.Text = "Tipo Persona";
            // 
            // DireccionTextBox
            // 
            DireccionTextBox.Location = new Point(131, 235);
            DireccionTextBox.Margin = new Padding(2, 1, 2, 1);
            DireccionTextBox.Name = "DireccionTextBox";
            DireccionTextBox.Size = new Size(110, 23);
            DireccionTextBox.TabIndex = 78;
            // 
            // TelefonoTextBox
            // 
            TelefonoTextBox.Location = new Point(131, 264);
            TelefonoTextBox.Margin = new Padding(2, 1, 2, 1);
            TelefonoTextBox.Name = "TelefonoTextBox";
            TelefonoTextBox.Size = new Size(110, 23);
            TelefonoTextBox.TabIndex = 79;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(131, 293);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 80;
            // 
            // legajottextBox
            // 
            legajottextBox.Location = new Point(131, 320);
            legajottextBox.Margin = new Padding(2, 1, 2, 1);
            legajottextBox.Name = "legajottextBox";
            legajottextBox.Size = new Size(110, 23);
            legajottextBox.TabIndex = 81;
            // 
            // tipoPersonaTextBox
            // 
            tipoPersonaTextBox.Location = new Point(131, 348);
            tipoPersonaTextBox.Margin = new Padding(2, 1, 2, 1);
            tipoPersonaTextBox.Name = "tipoPersonaTextBox";
            tipoPersonaTextBox.Size = new Size(110, 23);
            tipoPersonaTextBox.TabIndex = 82;
            // 
            // UsuarioDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 409);
            Controls.Add(tipoPersonaTextBox);
            Controls.Add(legajottextBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(TelefonoTextBox);
            Controls.Add(DireccionTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(claveTextBox);
            Controls.Add(claveLabel);
            Controls.Add(habilitadoCheckBox);
            Controls.Add(habilitadoLabel);
            Controls.Add(apellidoLabel);
            Controls.Add(apellidoTextBox);
            Controls.Add(idLabel);
            Controls.Add(idTextBox);
            Controls.Add(emailLabel);
            Controls.Add(emailTextBox);
            Controls.Add(usuarioLabel);
            Controls.Add(usuarioTextBox);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(nombreLabel);
            Controls.Add(nombreTextBox);
            Margin = new Padding(2, 1, 2, 1);
            Name = "UsuarioDetalle";
            Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombreTextBox;
        private Label nombreLabel;
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Label usuarioLabel;
        private TextBox usuarioTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label idLabel;
        private TextBox idTextBox;
        private Label apellidoLabel;
        private TextBox apellidoTextBox;
        private CheckBox habilitadoCheckBox;
        private Label habilitadoLabel;
        private TextBox claveTextBox;
        private Label claveLabel;
        private TextBox TelefonoTextBox;
        private TextBox DireccionTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tipoPersonaTextBox;
        private TextBox legajottextBox;
        private DateTimePicker dateTimePicker1;
    }
}