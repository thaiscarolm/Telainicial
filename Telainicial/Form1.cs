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
                // Abre o formul�rio de login
                var loginForm = new TelaLogin();
                loginForm.ShowDialog();

                // Verifica se o login foi bem-sucedido
                if (loginForm.DialogResult == DialogResult.OK)
                {
                    // Aqui voc� pode executar as a��es necess�rias para o login bem-sucedido,
                    // como abrir a tela principal do usu�rio.
                    MessageBox.Show("Login bem-sucedido!");

                    // Exemplo: Abre a tela principal do usu�rio
                    var userForm = new TelaLogin();
                    userForm.ShowDialog();
                }
                else
                {
                    // Aqui voc� pode lidar com o login mal-sucedido,
                    // como exibir uma mensagem de erro.
                    MessageBox.Show("Login falhou!");
                }

                // Fecha o formul�rio de login
                loginForm.Dispose();
            }
        }
    }
}