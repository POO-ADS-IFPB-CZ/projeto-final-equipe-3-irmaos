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

        public static void Aumentar(Label label)
        {
            if (int.TryParse(label.Text, out int value))
            {
                if (value >= 0)
                {
                    value++;
                    label.Text = value.ToString();
                }
            }
        }

        public static void Diminuir(Label label)
        {
            if (int.TryParse(label.Text, out int value))
            {
                if (value == 0)
                {
                    label.Text = value.ToString();
                }
                else if (value >= 0)
                {
                    value--;
                    label.Text = value.ToString();
                }
                
            }
        }
    }
}
