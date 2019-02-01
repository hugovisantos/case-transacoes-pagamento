using System;
using System.Collections.Generic;

namespace case_transacao
{
    public class Voucher : TransacaoDePagamento
    {
        
        public Voucher(double valorTransacao, List<Transacao> lista)
        {
            if(valorTransacao <=0)
            {
                throw new ArgumentException();  
            }
            else
            {
                this.IdTransacao = 30000000 + ++Transacao.QuantidadeDeTransacoes;
                this.ValorTransacao = valorTransacao;
                this.Estado = base.Autorizacao();
            }
                        
            lista.Add(this);
        }
    }
}