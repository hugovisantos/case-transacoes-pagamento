using System;
using System.Collections.Generic;

namespace case_transacao
{
    public class Credito : TransacaoDePagamento
    {
        const int MAXIMO_PARCELAS = 12;
        public Credito(double valorCompra, int parcelas, List<Transacao> lista)
        {
            if(parcelas > MAXIMO_PARCELAS || parcelas <=0 )
            {
                throw new ArgumentException();  
            }            
            
            if(valorCompra <=0)
            {
                throw new ArgumentException();  
            }

            this.IdTransacao = 10000000 + ++Transacao.QuantidadeDeTransacoes;
            this.ValorTransacao = valorCompra;
            this.Parcelas = parcelas;
            this.Estado = base.Autorizacao();

            lista.Add(this);
        }

    }
}