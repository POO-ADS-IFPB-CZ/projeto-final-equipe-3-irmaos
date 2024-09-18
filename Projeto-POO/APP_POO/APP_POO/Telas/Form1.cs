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

        public TelaPrincipal()
        {
            InitializeComponent();
            PanelConteudo.HorizontalScroll.Enabled = false;
            PanelConteudo.HorizontalScroll.Visible = false;
            PanelConteudo.VerticalScroll.Visible = false;

            login = new Login_UC();
            registrar = new Registrar_UC();
            sessoes = new Sessoes();
            frutas = new Frutas_UC();
            legumes = new Legumes_UC();

            login.RegisterClicked += OnRegisterClicked;
            login.LoginAppClicked += OnLoginAppClicked;
            registrar.LoginClicked += OnLoginClicked;
            sessoes.FrutasClicked += OnFrutasClicked;
            sessoes.LegumesClicked += OnLegumesClicked;
            frutas.VoltarClicked += OnVoltarClicked;
            legumes.VoltarClicked += OnVoltarClicked;

            
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
        private Panel GetPanel()
        {
            return PanelConteudo;
        }
    }
}
