using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_BancoCentral_
{
    public interface IConversorGrandeza
    {
        decimal Converter(decimal valor);
        string ObterSimbolo();
    }
}

