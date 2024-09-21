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

        public Usuario_UC()
        {
            InitializeComponent();
            RenderImg();
        }

        private void RenderImg()
        {
            Size size = new (35, 35);

            SvgDocument voltar = SvgDocument.Open(@"Icons\voltar.svg");
            Bitmap bitmap = Metodos.RenderSvg(voltar, size);
            Btn_Voltar.Image = bitmap;
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            VoltarClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
