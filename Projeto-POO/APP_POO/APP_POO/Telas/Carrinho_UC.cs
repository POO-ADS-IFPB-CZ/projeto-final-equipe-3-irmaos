using APP_POO.Funcionalidades;
using Svg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_POO.Telas
{
    public partial class Carrinho_UC : UserControl
    {
        public event EventHandler VoltarClicked;
        private Frutas_UC frutas;
        private Size frutasSize = new Size(57, 57);

        public Carrinho_UC()
        {
            InitializeComponent();
            RenderSvg();
            frutas = new Frutas_UC();
            //AtualizarCarrinho(); 
        }

        private void RenderSvg()
        {
            SvgDocument voltar = SvgDocument.Open(@"Icons\voltar.svg");
            SvgDocument uva = SvgDocument.Open(@"Icons\uva.svg");
            Bitmap bitmapVoltar = Metodos.RenderSvg(voltar, new Size(35, 35));
            Bitmap bitmapUva = Metodos.RenderSvg(uva, frutasSize);
            Btn_Voltar.BackgroundImage = bitmapVoltar;
            Panel_Uva.BackgroundImage = bitmapUva;
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            VoltarClicked?.Invoke(this, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var nomeFruta = frutas.Label_UvaNome.Text;
            var quantidade = label35.Text;
            MessageBox.Show($"Você comprou {quantidade} {nomeFruta}s");
            panel6.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }

        //public void AtualizarCarrinho()
        //{

        //    foreach (var item in Metodos.Carrinho)
        //    {
        //        Panel itemPanel = new Panel
        //        {
        //            Width = panelCarrinho.Width,
        //            Height = 100, // Ajuste conforme necessário
        //            Dock = DockStyle.Top
        //        };

        //        // Crie os componentes (imagem, nome, preço, quantidade, valor total, checkbox)
        //        PictureBox pictureBox = new PictureBox
        //        {
        //            Image = Image.FromFile(item.Imagem), // Carregue a imagem
        //            SizeMode = PictureBoxSizeMode.StretchImage,
        //            Width = 70, // Ajuste conforme necessário
        //            Height = 70  // Ajuste conforme necessário
        //        };

        //        Label lblNome = new Label { Text = item.Nome };
        //        Label lblPreco = new Label { Text = $"Preço: {item.PrecoUnitario:C}" };
        //        Label lblQuantidade = new Label { Text = $"Qtd: {item.Quantidade}" };
        //        Label lblValorTotal = new Label { Text = $"Total: {item.ValorTotal:C}" };
        //        CheckBox checkBox = new CheckBox { Text = "Selecionar" };

        //        // Adicione os componentes ao painel do item
        //        itemPanel.Controls.Add(pictureBox);
        //        itemPanel.Controls.Add(lblNome);
        //        itemPanel.Controls.Add(lblPreco);
        //        itemPanel.Controls.Add(lblQuantidade);
        //        itemPanel.Controls.Add(lblValorTotal);
        //        itemPanel.Controls.Add(checkBox);

        //        // Adicione o painel do item ao painel do carrinho
        //        panelCarrinho.Controls.Add(itemPanel);
        //    }
        //}
    }
}
