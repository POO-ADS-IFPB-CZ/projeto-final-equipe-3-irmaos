using APP_POO.Funcionalidades;
using Newtonsoft.Json;
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
    public static class UsuarioLogado
    {
        public static JSON Usuario { get; set; }
    }

    public partial class Registrar_UC : UserControl
    {
        public event EventHandler RegistroSucessoClicked;
        public event EventHandler LoginClicked;

        public Registrar_UC()
        {
            InitializeComponent();
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            string nome = TBox_Usuario_Registrar.Text;
            string senha = TBox_Senha_Registrar.Text;
            int saldo = 0;

            byte[] hashRegistro = Metodos.GeraHash(senha);
            string hashConvertido = Metodos.ConverteByteParaHex(hashRegistro);

            JSON novoUsuario = new JSON
            {
                Nome = nome,
                Senha = hashConvertido,
                Saldo = saldo,
                DataRegistro = DateTime.Now.ToString() // Inclui a data de registro
            };

            if (string.IsNullOrEmpty(nome) && string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Você precisa informar um nome para o usuário e uma senha se quiser prosseguir.");
            }
            else if (string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Você precisa informar uma senha se quiser prosseguir.");
            }
            else if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Você precisa informar um nome para o usuário se quiser prosseguir.");
            }
            else
            {
                Metodos.RegistrarUsuario(novoUsuario);
                UsuarioLogado.Usuario = novoUsuario; // Armazena o usuário registrado
                MessageBox.Show("Registro bem sucedido!");

                RegistroSucessoClicked?.Invoke(this, EventArgs.Empty);
            }
        }


        private void ComparaSenhas_TextChanged(object sender, EventArgs e)
        {
            if (TBox_Senha_Registrar.Text != Tx_Box_SenhaConfirmar.Text || string.IsNullOrEmpty(TBox_Senha_Registrar.Text) || string.IsNullOrEmpty(Tx_Box_SenhaConfirmar.Text))
            {
                Btn_Registrar.Enabled = false;
            }
            else
            {
                Btn_Registrar.Enabled = true;
            }
        }

    }
}
