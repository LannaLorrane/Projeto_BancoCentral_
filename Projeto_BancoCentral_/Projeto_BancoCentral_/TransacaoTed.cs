using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Projeto_BancoCentral_.Transacao;

namespace Projeto_BancoCentral_
{
    internal class TransacaoTed : Transacao
    {
        public string Finalidade { get; set; }

        public override bool Validar()
        {
            return _valor > 0;
        }
    }
}