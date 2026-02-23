using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Projeto_BancoCentral_.Transacao;

namespace Projeto_BancoCentral_
{
    internal class Transacao
    {
        public class transacao
        {
            protected decimal _valor;

            public decimal Valor
            {
                get { return _valor; }
                set { if (value > 0) _valor = value; }
            }

            public DateTime Data { get; set; } = DateTime.Now;
            public string ContaOrigem { get; set; }
            public string ContaDestino { get; set; }

            public virtual bool Validar()
            {
                return _valor > 0;
            }
        }

        public class TransacaoPix : transacao
        {
            public string ChavePix { get; set; }

            public override bool Validar()
            {
                return _valor > 0 && _valor <= 10000;
            }
        }

        public class transacaoTed : transacao
        {
            public override bool Validar()
            {
                return _valor > 500;
            }
        }

        public class Transacaoted : transacao
        {
            public string Finalidade { get; set; }
            public override bool Validar()
            {
                //Regra de exemplo: TED deve ser maior que R$5.000 para fiscalização
                return _valor > 5000;
            }
        }
    }
}
