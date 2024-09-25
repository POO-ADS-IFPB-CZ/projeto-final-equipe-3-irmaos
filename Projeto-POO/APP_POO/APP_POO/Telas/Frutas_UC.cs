using APP_POO.Funcionalidades;
using Svg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_POO.Telas
{
    public partial class Frutas_UC : UserControl
    {
        public event EventHandler VoltarClicked;
        public event EventHandler<ItemCarrinho> ProdutoAdicionado;
        private Size frutasSize = new(57, 57);

        public Frutas_UC()
        {
            InitializeComponent();
            RenderImg();
        }

        private void RenderImg()
        {
            SvgDocument maca = SvgDocument.Open(@"Icons\maçã.svg");
            SvgDocument voltar = SvgDocument.Open(@"Icons\voltar.svg");
            SvgDocument banana = SvgDocument.Open(@"Icons\banana.svg");
            SvgDocument laranja = SvgDocument.Open(@"Icons\laranja.svg");
            SvgDocument abacaxi = SvgDocument.Open(@"Icons\abacaxi.svg");
            SvgDocument morango = SvgDocument.Open(@"Icons\morango.svg");
            SvgDocument uva = SvgDocument.Open(@"Icons\uva.svg");

            Bitmap bitmapVoltar = Metodos.RenderSvg(voltar, new Size(35, 35));
            Bitmap bitmapMaca = Metodos.RenderSvg(maca, frutasSize);
            Bitmap bitmapBanana = Metodos.RenderSvg(banana, frutasSize);
            Bitmap bitmapLaranja = Metodos.RenderSvg(laranja, frutasSize);
            Bitmap bitmapAbacaxi = Metodos.RenderSvg(abacaxi, frutasSize);
            Bitmap bitmapMorango = Metodos.RenderSvg(morango, frutasSize);
            Bitmap bitmapUva = Metodos.RenderSvg(uva, frutasSize);

            Btn_Voltar.Image = bitmapVoltar;
            Panel_Maca.BackgroundImage = bitmapMaca;
            Panel_Banana.BackgroundImage = bitmapBanana;
            Panel_Laranja.BackgroundImage = bitmapLaranja;
            Panel_Abacaxi.BackgroundImage = bitmapAbacaxi;
            Panel_Morango.BackgroundImage = bitmapMorango;
            Panel_Uva.BackgroundImage = bitmapUva;
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            VoltarClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Label_LaranjaPreco_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Label_LaranjaPreco.Text, out int precoLaranja))
            {
                Btn_DiminuirLaranja.Enabled = precoLaranja > 0;
                Btn_AumentarLaranja.Enabled = precoLaranja < 10;
            }
            else
            {
                Btn_DiminuirLaranja.Enabled = false;
                Btn_AumentarLaranja.Enabled = false;
            }
        }

        private void Aumentar_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Label? label = button.Tag as Label;

            if (label == null)
            {
                Debug.WriteLine("Label não encontrado");
                return;
            }
            Metodos.Aumentar(label);
        }

        private void Diminuir_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Label? label = button.Tag as Label;

            if (label == null)
            {
                return;
            }
            Metodos.Diminuir(label);
        }

        private void Btn_AddItem_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            string nomeProduto = btn.Tag.ToString().Trim().ToUpper();
            Debug.WriteLine(nomeProduto); 
            string imagem = "";
            decimal precoUnitario = 0;
            int quantidade = 0;

            switch (nomeProduto)
            {
                case "ABACAXI":
                    imagem = @"Icons\abacaxi.svg";
                    precoUnitario = decimal.Parse(Label_Abacaxi.Text);
                    quantidade = int.Parse(Label_Abacaxi.Text);
                    break;
                case "Banana":
                    imagem = @"Icons\banana.svg";
                    precoUnitario = decimal.Parse(Label_Banana.Text);
                    quantidade = int.Parse(Label_Banana.Text);
                    break;
                case "Laranja":
                    imagem = @"Icons\laranja.svg";
                    precoUnitario = decimal.Parse(Label_LaranjaPreco.Text);
                    quantidade = int.Parse(Label_LaranjaPreco.Text);
                    break;
                case "Maca":
                    imagem = @"Icons\maçã.svg";
                    precoUnitario = decimal.Parse(Label_Maca.Text);
                    quantidade = int.Parse(Label_Maca.Text);
                    break;
                case "Morango":
                    imagem = @"Icons\morango.svg";
                    precoUnitario = decimal.Parse(Label_Morango.Text);
                    quantidade = int.Parse(Label_Morango.Text);
                    break;
                case "UVA":
                    imagem = @"Icons\uva.svg";
                    string precoText = Label_UvaPreco.Text.Replace("R$", "").Trim().Replace(",", ".");
                    if (!decimal.TryParse(precoText, out precoUnitario))
                    {
                        MessageBox.Show("Formato de preço inválido.");
                        return;
                    }
                    quantidade = int.Parse(Label_UvaQuantidade.Text);
                    break;
                default:
                    MessageBox.Show("Produto desconhecido.");
                    return;
            }

            ItemCarrinho produto = new ItemCarrinho(nomeProduto, imagem, precoUnitario, quantidade);
            Metodos.AdicionarAoCarrinho(produto.Nome, produto.Imagem, produto.PrecoUnitario, produto.Quantidade);

            MessageBox.Show($"{produto.Nome} adicionado ao carrinho!");
        }

        private void Frutas_UC_Load(object sender, EventArgs e)
        {
            // Aumentar
            Btn_AumentarUva.Tag = Label_UvaQuantidade; 
            Btn_AumentarLaranja.Tag = Label_LaranjaPreco;
            Btn_AumentarBanana.Tag = Label_Banana;
            Btn_AumentarAbacaxi.Tag = Label_Abacaxi;
            Btn_AumentarMaca.Tag = Label_Maca;
            Btn_AumentarMorango.Tag = Label_Morango;

            // Diminuir
            Btn_DiminuirUva.Tag = Label_UvaQuantidade; 
            Btn_DiminuirAbacaxi.Tag = Label_Abacaxi;
            Btn_DiminuirBanana.Tag = Label_Banana;
            Btn_DiminuirMaca.Tag = Label_Maca;
            Btn_DiminuirMorango.Tag = Label_Morango;
            Btn_DiminuirLaranja.Tag = Label_LaranjaPreco;

            // Add
            Btn_ADDAbacaxi.Tag = Label_Abacaxi;
            Btn_ADDBanana.Tag = Label_Banana;
            Btn_ADDLaranja.Tag = Label_LaranjaPreco;
            Btn_ADDMaca.Tag = Label_Maca;
            Btn_ADDMorango.Tag = Label_Morango;
            Btn_ADDUva.Tag = "Uva";

            Debug.WriteLine(Label_UvaNome.ToString());
        }
    }
}
