using System.Windows.Forms.VisualStyles;

namespace Academia
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Es Ud. un usario muy descuidado, haga memoria", "Olvid� mi contrase�a", MessageBoxButtons.OK);

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String adminName = "admin";
            String adminPass = "1234";

            if (this.textUsuario.Text == adminName && this.textPass.Text == adminPass)
            {   
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuario y/o contrase�a incorrectos", "Login", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
            

        }
    }
}
