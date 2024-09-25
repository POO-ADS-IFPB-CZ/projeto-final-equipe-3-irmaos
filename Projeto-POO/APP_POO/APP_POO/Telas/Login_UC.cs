using APP_POO.Funcionalidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_POO.Telas
{
    public partial class Login_UC : UserControl
    {
        public event EventHandler RegisterClicked;
        public event EventHandler LoginAppClicked;
        public event EventHandler<JSON> LoginSucesso;

        public Login_UC()
        {
            InitializeComponent();
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            RegisterClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string login = TBox_Usuario_Login.Text;
            string senha = TBox_Senha_Login.Text;

            byte[] hashLogin = Metodos.GeraHash(senha);
            string byteConvertido = Metodos.ConverteByteParaHex(hashLogin);

            if (TBox_Usuario_Login.Text == "" && TBox_Senha_Login.Text == "")
            {
                MessageBox.Show("Você precisa informar um nome para o usuário e uma senha para prosseguir.");
            }
            else if (TBox_Usuario_Login.Text == "")
            {
                MessageBox.Show("Você precisa informar um nome para o usuário para prosseguir.");
            }
            else if (TBox_Senha_Login.Text == "")
            {
                MessageBox.Show("Você precisa informar uma senha para o usuário para prosseguir.");
            }
            else if (Metodos.Autenticar(login, byteConvertido))
            {
                MessageBox.Show("Sucesso");
                JSON dadoUsuarioLogado = new()
                {
                    Nome = login,
                    Saldo = 0,
                    DataRegistro = DateTime.Now.ToString("dd/MM/yyyy")
                };
                LoginSucesso?.Invoke(this, dadoUsuarioLogado);
                LoginAppClicked?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Erro");
                return;
            }
        }

        private void VerificaCampos_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBox_Senha_Login.Text) || string.IsNullOrEmpty(TBox_Usuario_Login.Text))
            {
                Btn_Login.Enabled = false;
            }
            else
            {
                Btn_Login.Enabled = true;
            }
        }

    }
}