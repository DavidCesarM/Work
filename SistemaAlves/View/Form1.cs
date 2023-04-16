using SistemaAlves.Model;

namespace SistemaAlves
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        
        private void btnSair_login_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_login_Click(object sender, EventArgs e)
        {
            Login usr = new Login();
            usr.Acessar(txtNome_login.Text, txtSenha_login.Text);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           
        }
    }
}