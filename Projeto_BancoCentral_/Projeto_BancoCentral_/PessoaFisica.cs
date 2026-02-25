using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCentralAtual
{
    internal class PessoaFisica : Cliente
    {
        public string CPF { get; set; }

        public override void ExibirDocumento()
        {
            Console.WriteLine($"CPF: {CPF}");
        }
    }
}