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
    public partial class Verduras_UC : UserControl
    {
        public event EventHandler VoltarClicked;

        public Verduras_UC()
        {
            InitializeComponent();
            RenderSvg();
        }
        private void RenderSvg()
        {
            Size frutasSize = new(57, 57);

            SvgDocument alface = SvgDocument.Open(@"Icons\verdura.svg");
            SvgDocument voltar = SvgDocument.Open(@"Icons\voltar.svg");
            SvgDocument berinjela = SvgDocument.Open(@"Icons\berinjela.svg");
            SvgDocument nabo = SvgDocument.Open(@"Icons\nabo.svg");
            SvgDocument alhoporo = SvgDocument.Open(@"Icons\alhoporo.svg");
            SvgDocument brocoli = SvgDocument.Open(@"Icons\brocolis.svg");
            SvgDocument salsao = SvgDocument.Open(@"Icons\salsao.svg");

            Bitmap bitmapVoltar = Metodos.RenderSvg(voltar, new Size(35, 35));
            Bitmap bitmapAlface = Metodos.RenderSvg(alface, frutasSize);
            Bitmap bitmapBerinjela = Metodos.RenderSvg(berinjela, frutasSize);
            Bitmap bitmapNabo = Metodos.RenderSvg(nabo, frutasSize);
            Bitmap bitmapAlhoporo = Metodos.RenderSvg(alhoporo, frutasSize);
            Bitmap bitmapBrocoli = Metodos.RenderSvg(brocoli, frutasSize);
            Bitmap bitmapSalao = Metodos.RenderSvg(salsao, frutasSize);

            Btn_Voltar.Image = bitmapVoltar;
            Panel_Alface.BackgroundImage = bitmapAlface;
            Panel_Berinjela.BackgroundImage = bitmapBerinjela;
            Panel_Nabo.BackgroundImage = bitmapNabo;
            Panel_AlhoPoro.BackgroundImage = bitmapAlhoporo;
            Panel_Brocoli.BackgroundImage = bitmapBrocoli;
            Panel_Salsao.BackgroundImage = bitmapSalao;
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            VoltarClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
