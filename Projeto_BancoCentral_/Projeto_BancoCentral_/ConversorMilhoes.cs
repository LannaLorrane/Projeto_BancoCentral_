using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_BancoCentral_
{
    public class ConversorMilhoes : IConversorGrandeza
    {
        public decimal Converter(decimal valor) => 1250000000000 / 1_000_000m;

        public string ObterSimbolo() => "Mi";
    }
}
