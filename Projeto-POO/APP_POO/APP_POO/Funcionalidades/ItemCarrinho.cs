using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_POO.Funcionalidades
{
    public class ItemCarrinho
    {
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int Quantidade { get; set; }

        public decimal ValorTotal => PrecoUnitario * Quantidade;

        public ItemCarrinho(string nome, string imagem, decimal precoUnitario, int quantidade)
        {
            Nome = nome;
            Imagem = imagem;
            PrecoUnitario = precoUnitario;
            Quantidade = quantidade;
        }
    }
}
