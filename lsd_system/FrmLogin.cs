using System.Windows.Forms;

namespace lsd_system
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "admin" && txtSenha.Text.Trim() == "1234")
            {

                FrmHome frmHome = new FrmHome();
                frmHome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Senha ou usuário inválido!","Erro ao logar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FrmLogin_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUsuario.Text.Trim() == "admin" && txtSenha.Text.Trim() == "1234")
                {
                    FrmHome frmHome = new FrmHome();
                    frmHome.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Senha ou usuário inválido!", "Erro ao logar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}