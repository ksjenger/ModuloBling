using System;
using System.Windows.Forms;
using ModuloBling.Entities;
using ModuloBling.Services;
using ModuloBling.View;


namespace ModuloBling.View
{
    public partial class Login : Form
    {

        internal static PerfilVipp Operfil { get; set; }

        public Login()
        {
            InitializeComponent();
            this.Text = "Login - Versão: " + Application.ProductVersion;

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {

            Operfil = new PerfilVipp()
            {
                usuarioField = txtUsr.Text,
                tokenField = txtPwd.Text
            };

            if (txtUsr.Text.Length < 6)
            {
                MessageBox.Show("O usuário deve conter no minimo 6 caracteres", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtPwd.Text.Length < 6)
            {
                MessageBox.Show("A senha deve conter no minimo 6 caracteres", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Logar.LogarVipp(txtUsr.Text, txtPwd.Text))
            {
                Hide();
                new Principal(txtUsr.Text, txtPwd.Text).ShowDialog();
                Application.Exit();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
