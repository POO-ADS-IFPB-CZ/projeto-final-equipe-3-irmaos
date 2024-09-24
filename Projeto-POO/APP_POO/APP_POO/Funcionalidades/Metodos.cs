
using Svg;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;
using Newtonsoft.Json;

namespace APP_POO.Funcionalidades
{
    public static class Metodos
    {
        internal static void AddUserControl(UserControl userControl, Panel panel)
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

        public static void RegistrarUsuario(JSON json)
        {
            string arquivo = "usuario.json";
            List<JSON> lista = [];

            if (File.Exists(arquivo))
            {
                string arquivoExistente = File.ReadAllText(arquivo);
                lista = JsonConvert.DeserializeObject<List<JSON>>(arquivoExistente) ?? [];
            }

            lista.Add(json);

            string salvarLista = JsonConvert.SerializeObject(lista, Formatting.Indented);
            File.WriteAllText(arquivo, salvarLista);
        }
        public static bool Autenticar(string nome, string senha)
        {
            string arquivo = "usuario.json";

            if (!File.Exists(arquivo))
            {
                return false;
            }

            string json = File.ReadAllText(arquivo);
            List<JSON> usuarios = JsonConvert.DeserializeObject<List<JSON>>(json);

            foreach (var usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == senha)
                {
                    return true;
                }
            }

            return false;
        }
        public static byte[] GeraHash(string hash)
        {
            using (HashAlgorithm algoritmo = SHA256.Create())
                return algoritmo.ComputeHash(Encoding.UTF8.GetBytes(hash));
        }
        public static string ConverteByteParaHex(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in bytes)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }

    }


}