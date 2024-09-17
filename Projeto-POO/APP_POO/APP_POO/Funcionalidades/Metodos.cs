using Svg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_POO.Funcionalidades
{
    public static class Metodos
    {
        public static void CarregaPagina(Panel panel, UserControl userControl)
        {
            AddUserControl(userControl, panel);
        }

        internal static void AddUserControl(UserControl userControl,Panel panel)
        {
            userControl.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        public static Bitmap RenderSvg(SvgDocument svgDoc, Size size)
        {
            svgDoc.Width = new SvgUnit(size.Width);
            svgDoc.Height = new SvgUnit(size.Height);

            Bitmap bitmap = svgDoc.Draw();
            return bitmap;
        }
    }
}
