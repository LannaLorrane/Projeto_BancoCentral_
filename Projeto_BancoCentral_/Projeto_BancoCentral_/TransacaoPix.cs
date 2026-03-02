using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Projeto_BancoCentral_.Transacao;

namespace Projeto_BancoCentral_
{
    internal class TransacaoPix : Transacao
    {
        public string ChavePix { get; set; }

        public override bool Validar()
        {
            return _valor > 0 && _valor <= 10000;
        }
    }
}
