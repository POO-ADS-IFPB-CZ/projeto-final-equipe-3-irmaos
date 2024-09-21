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

    public partial class Carrinho_UC : UserControl
    {
        public event EventHandler VoltarClicked;

        public Carrinho_UC()
        {
            InitializeComponent();
            RenderSvg();
        }

        private void RenderSvg()
        {
            SvgDocument voltar = SvgDocument.Open(@"Icons\voltar.svg");
            Bitmap bitmapVoltar = Metodos.RenderSvg(voltar, new Size(35, 35));
            Btn_Voltar.BackgroundImage = bitmapVoltar;
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            VoltarClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
