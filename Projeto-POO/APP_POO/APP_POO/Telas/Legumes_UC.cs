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
    public partial class Legumes_UC : UserControl
    {
        public event EventHandler VoltarClicked;
        private Size frutasSize = new(57, 57);

        public Legumes_UC()
        {
            InitializeComponent();
            RenderSvg();
        }
        private void RenderSvg()
        {
            SvgDocument abobora = SvgDocument.Open(@"Icons\abobora.svg");
            SvgDocument voltar = SvgDocument.Open(@"Icons\voltar.svg");
            SvgDocument cenoura = SvgDocument.Open(@"Icons\legume.svg");
            SvgDocument cebola = SvgDocument.Open(@"Icons\cebola.svg");
            SvgDocument tomate = SvgDocument.Open(@"Icons\tomate.svg");
            SvgDocument beterraba = SvgDocument.Open(@"Icons\beterraba.svg");
            SvgDocument batata = SvgDocument.Open(@"Icons\batata.svg");

            Bitmap bitmapVoltar = Metodos.RenderSvg(voltar, new Size(35, 35));
            Bitmap bitmapAbobora = Metodos.RenderSvg(abobora, frutasSize);
            Bitmap bitmapCenoura = Metodos.RenderSvg(cenoura, frutasSize);
            Bitmap bitmapCebola = Metodos.RenderSvg(cebola, frutasSize);
            Bitmap bitmapTomate = Metodos.RenderSvg(tomate, frutasSize);
            Bitmap bitmapBeterraba = Metodos.RenderSvg(beterraba, frutasSize);
            Bitmap bitmapBatata = Metodos.RenderSvg(batata, frutasSize);

            Btn_Voltar.Image = bitmapVoltar;
            Panel_Abobora.BackgroundImage = bitmapAbobora;
            Panel_Cenoura.BackgroundImage = bitmapCenoura;
            Panel_Cebola.BackgroundImage = bitmapCebola;
            Panel_Tomate.BackgroundImage = bitmapTomate;
            Panel_Beterraba.BackgroundImage = bitmapBeterraba;
            Panel_Batata.BackgroundImage = bitmapBatata;
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            VoltarClicked?.Invoke(this, EventArgs.Empty);   
        }
    }
}
