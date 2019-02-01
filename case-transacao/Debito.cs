using System;
using System.Collections.Generic;

namespace case_transacao
{
    public class Debito : TransacaoDePagamento
    {
        const int MAXIMO_PARCELAS = 1;
        public Debito(double valorTransacao, List<Transacao> lista)
        {  
            if(valorTransacao <= 0) 
            {
                throw new ArgumentException();
            }
            else
            {
            this.IdTransacao = 20000000 + ++Transacao.QuantidadeDeTransacoes;
            this.ValorTransacao = valorTransacao;
            this.Estado = base.Autorizacao();
            }


            lista.Add(this);
        }

        public Debito(double valorTransacao)
        {
            this.ValorTransacao = valorTransacao;
            this.Estado = base.Autorizacao();
        }
    }

 
}