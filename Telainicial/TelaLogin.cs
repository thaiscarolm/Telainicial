using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telainicial
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {
            string User = "admin";
            string Password = "admin";

            if (textusuario.Text == User & textsenha.Text == Password)
            {
                MessageBox.Show(" Acesso Liberado");
                Form1 FrmMain = new Form1();
                FrmMain.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Usúario/Senha Incorretos!");
            }

        }
    }
}
