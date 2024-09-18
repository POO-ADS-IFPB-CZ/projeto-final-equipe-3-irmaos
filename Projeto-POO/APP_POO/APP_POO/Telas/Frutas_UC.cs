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
    public partial class Frutas_UC : UserControl
    {
        public event EventHandler VoltarClicked;
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
            Bitmap bitmapAcabaxi = Metodos.RenderSvg(abacaxi, frutasSize);
            Bitmap bitmapMorango = Metodos.RenderSvg(morango, frutasSize);
            Bitmap bitmapUva = Metodos.RenderSvg(uva, frutasSize);

            Btn_Voltar.Image = bitmapVoltar;
            Panel_Maca.BackgroundImage = bitmapMaca;
            Panel_Banana.BackgroundImage = bitmapBanana;
            Panel_Laranja.BackgroundImage = bitmapLaranja;
            Panel_Abacaxi.BackgroundImage = bitmapAcabaxi;
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

        private void Btn_AumentarLaranja_Click(object sender, EventArgs e)
        {
            int.TryParse(Label_LaranjaPreco.Text, out int precoLaranja);
            precoLaranja += 1;
            Label_LaranjaPreco.Text = precoLaranja.ToString();
        }

        private void Btn_DiminuirLaranja_Click(object sender, EventArgs e)
        {
            int.TryParse(Label_LaranjaPreco.Text, out int precoLaranja);
            precoLaranja -= 1;
            Label_LaranjaPreco.Text = precoLaranja.ToString();
        }
    }
}
