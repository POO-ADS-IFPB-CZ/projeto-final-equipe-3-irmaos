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
    public partial class Sessoes : UserControl
    {
        private Size globalSize = new Size(35, 35);
        public event EventHandler LoginAppClicked;
        public event EventHandler FrutasClicked;
        public event EventHandler LegumesClicked;
        public event EventHandler VerdurasClicked;
        public event EventHandler CarrinhoClicked;
        public event EventHandler UsuarioClicked;

        public Sessoes()
        {
            InitializeComponent();
            RenderImg();
        }
        private void RenderImg()
        {
            //Carrega img SVG
            SvgDocument carrinho = SvgDocument.Open(@"Icons\carrinho.svg");
            SvgDocument fruta = SvgDocument.Open(@"Icons\fruta.svg");
            SvgDocument legumes = SvgDocument.Open(@"Icons\legume.svg");
            SvgDocument verdura = SvgDocument.Open(@"Icons\verdura.svg");
            SvgDocument user = SvgDocument.Open(@"Icons\conta.svg");

            //Redimensiona img SVG
            Bitmap bitmapCarrinho = Metodos.RenderSvg(carrinho, globalSize);
            Bitmap bitmapFruta = Metodos.RenderSvg(fruta, globalSize);
            Bitmap bitmapLegume = Metodos.RenderSvg(legumes, globalSize);
            Bitmap bitmapVerdura = Metodos.RenderSvg(verdura, globalSize);
            Bitmap bitmapUser = Metodos.RenderSvg(user, new Size (40, 40));

            //Aplica img ao botão
            Btn_Carrinho.Image = bitmapCarrinho;
            Btn_Fruta.Image = bitmapFruta;
            Btn_Legumes.Image = bitmapLegume;
            Btn_Verduras.Image = bitmapVerdura;
            Btn_Usuario.Image = bitmapUser;
        }

        private void Btn_Carrinho_DragEnter(object sender, DragEventArgs e)
        {
            Btn_Carrinho.ForeColor = Color.Transparent;
        }

        private void Btn_Fruta_Click(object sender, EventArgs e)
        {
            FrutasClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Btn_Legumes_Click(object sender, EventArgs e)
        {
            LegumesClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Btn_Verduras_Click(object sender, EventArgs e)
        {
            VerdurasClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Btn_Carrinho_Click(object sender, EventArgs e)
        {
            CarrinhoClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Btn_Usuario_Click(object sender, EventArgs e)
        {
            UsuarioClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
