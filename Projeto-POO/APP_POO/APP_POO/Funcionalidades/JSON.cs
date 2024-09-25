using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_POO.Funcionalidades
{
    public class JSON
    {
        public string? Nome { get; set; }
        public string? Senha { get; set; }
        public int Saldo { get; set; }
        public string? DataRegistro { get; set; }

        public void SalvarJson(JSON user)
        {
            JSON json = new JSON
            {
                Nome = user.Nome,
            };
        }
    }
}

