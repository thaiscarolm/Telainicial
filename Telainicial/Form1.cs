namespace Telainicial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // Abre o formulário de login
                var loginForm = new TelaLogin();
                loginForm.ShowDialog();

                // Verifica se o login foi bem-sucedido
                if (loginForm.DialogResult == DialogResult.OK)
                {
                    // Aqui você pode executar as ações necessárias para o login bem-sucedido,
                    // como abrir a tela principal do usuário.
                    MessageBox.Show("Login bem-sucedido!");

                    // Exemplo: Abre a tela principal do usuário
                    var userForm = new TelaLogin();
                    userForm.ShowDialog();
                }
                else
                {
                    // Aqui você pode lidar com o login mal-sucedido,
                    // como exibir uma mensagem de erro.
                    MessageBox.Show("Login falhou!");
                }

                // Fecha o formulário de login
                loginForm.Dispose();
            }
        }
    }
}