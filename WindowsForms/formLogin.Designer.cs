namespace Academia
{
    partial class formLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textUsuario = new TextBox();
            textPass = new TextBox();
            btnIngresar = new Button();
            linkForgotPass = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AliceBlue;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(85, 33);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingreso al sistema";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 115);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre del usuario:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 165);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(126, 115);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(199, 23);
            textUsuario.TabIndex = 3;
            // 
            // textPass
            // 
            textPass.Location = new Point(126, 165);
            textPass.Name = "textPass";
            textPass.PasswordChar = '*';
            textPass.Size = new Size(199, 23);
            textPass.TabIndex = 4;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(126, 229);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // linkForgotPass
            // 
            linkForgotPass.AutoSize = true;
            linkForgotPass.Location = new Point(5, 274);
            linkForgotPass.Name = "linkForgotPass";
            linkForgotPass.Size = new Size(119, 15);
            linkForgotPass.TabIndex = 6;
            linkForgotPass.TabStop = true;
            linkForgotPass.Text = "Olvidé mi contraseña";
            linkForgotPass.LinkClicked += linkForgotPass_LinkClicked;
            // 
            // formLogin
            // 
            AcceptButton = btnIngresar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 305);
            Controls.Add(linkForgotPass);
            Controls.Add(btnIngresar);
            Controls.Add(textPass);
            Controls.Add(textUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textUsuario;
        private TextBox textPass;
        private Button btnIngresar;
        private LinkLabel linkForgotPass;
    }
}
