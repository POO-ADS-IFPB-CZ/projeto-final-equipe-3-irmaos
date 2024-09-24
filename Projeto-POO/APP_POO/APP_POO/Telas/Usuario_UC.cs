using APP_POO.Funcionalidades;
using Svg;
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
    public partial class Usuario_UC : UserControl
    {
        public event EventHandler VoltarClicked;
        
        private Login_UC login;

        private JSON user;

        public Usuario_UC()
        {
            InitializeComponent();
            RenderImg();
            login = new Login_UC();
            login.LoginSucesso += OnLoginSucesso;
        }

        public void OnLoginSucesso(object sender, JSON dadosUsuario)
        {
            user = dadosUsuario;
        }

        private void RenderImg()
        {
            Size size = new(35, 35);

            SvgDocument voltar = SvgDocument.Open(@"Icons\voltar.svg");
            Bitmap bitmap = Metodos.RenderSvg(voltar, size);
            Btn_Voltar.Image = bitmap;
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            VoltarClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Btn_Recarregar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = new()
            {
                Width = 200,
                Height = 30,
                BackColor = Color.Green,
                ForeColor = Color.WhiteSmoke,
                Font = new Font(DefaultFont, FontStyle.Bold),
                MaxLength = 3

            };

            textBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);

            int centerX = (ClientSize.Width - textBox.Width) / 2;
            int centerY = (ClientSize.Height - textBox.Height) / 2;

            textBox.Location = new Point(centerX, centerY);
            Controls.Add(textBox);
            textBox.Visible = true;
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Usuario_UC_Load(object sender, EventArgs e)
        {

        }

        public void SetUser(JSON usuario)
        {
            user = usuario;
            AtualizarLabels();
        }
        private void AtualizarLabels()
        {
            if (user != null)
            {
                Label_NomeUsuario.Text = user.Nome;
                Label_DataCadastro.Text = DateTime.Parse(user.DataRegistro).ToString("dd/MM/yyyy");
                Label_Saldo.Text = user.Saldo.ToString();
            }
        }

    }
}
