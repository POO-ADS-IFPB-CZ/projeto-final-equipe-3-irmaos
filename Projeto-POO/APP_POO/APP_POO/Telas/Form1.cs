using APP_POO.Funcionalidades;
using APP_POO.Telas;
using System.Drawing.Text;

namespace APP_POO
{
    public partial class TelaPrincipal : Form
    {
        private Login_UC login;
        private Registrar_UC registrar;
        private Sessoes sessoes;
        private Frutas_UC frutas;
        private Legumes_UC legumes;
        private Verduras_UC verduras;
        private Carrinho_UC carrinho;
        private Usuario_UC usuario;

        public TelaPrincipal()
        {
            InitializeComponent();

            login = new Login_UC();
            registrar = new Registrar_UC();
            sessoes = new Sessoes();
            frutas = new Frutas_UC();
            legumes = new Legumes_UC();
            verduras = new Verduras_UC();
            carrinho = new Carrinho_UC();  
            usuario = new Usuario_UC();

            login.RegisterClicked += OnRegisterClicked;
            login.LoginAppClicked += OnLoginAppClicked;
            registrar.LoginClicked += OnLoginClicked;
            sessoes.FrutasClicked += OnFrutasClicked;
            sessoes.LegumesClicked += OnLegumesClicked;
            sessoes.VerdurasClicked += OnVerdurasClicked;
            sessoes.CarrinhoClicked += OnCarrinhoClicked;
            sessoes.UsuarioClicked += OnUsuarioClicked;
            frutas.VoltarClicked += OnVoltarClicked;
            legumes.VoltarClicked += OnVoltarClicked;
            verduras.VoltarClicked +=OnVoltarClicked;
            carrinho.VoltarClicked += OnVoltarClicked;
            usuario.VoltarClicked += OnVoltarClicked;

            
            Metodos.AddUserControl(login, GetPanel());
        }
        private void OnRegisterClicked(object sender, EventArgs e)
        {
            Metodos.AddUserControl(registrar, GetPanel());
        }
        private void OnLoginClicked(object sender, EventArgs e)
        {
            Metodos.AddUserControl(login, GetPanel());
        }
        private void OnLoginAppClicked(object sender, EventArgs e)
        {
            Metodos.AddUserControl(sessoes, GetPanel());
        }
        private void OnFrutasClicked(object sender, EventArgs e)
        {
            Metodos.AddUserControl(frutas, GetPanel());
            frutas.Dock = DockStyle.Fill;
        }
        private void OnVoltarClicked(object sender, EventArgs e)
        {
            Metodos.AddUserControl(sessoes, GetPanel());
        }
        private void OnLegumesClicked(object sender, EventArgs e)
        {
            Metodos.AddUserControl(legumes, GetPanel());
        }
        private void OnVerdurasClicked(object sender, EventArgs e)
        {
            Metodos.AddUserControl(verduras, GetPanel());
        }
        private void OnCarrinhoClicked(object sender, EventArgs e)
        {
            Metodos.AddUserControl(carrinho, GetPanel());
        }
        private void OnUsuarioClicked(object sender, EventArgs e)
        {
            Metodos.AddUserControl(usuario, GetPanel());
        }
        private Panel GetPanel()
        {
            return PanelConteudo;
        }
    }
}
