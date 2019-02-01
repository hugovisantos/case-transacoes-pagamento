using System;
using System.Collections.Generic;

namespace case_transacao
{
    public class Crediario : Debito
    {
        const int MAXIMO_PARCELAS = 24;
        const double TAXA_CREDIARIO = 0.015;
        public Crediario(double valorTransacao, int parcelas, List<Transacao> lista) : base(valorTransacao)
        {
            if(parcelas > MAXIMO_PARCELAS || parcelas <= 0 )
            {
                throw new ArgumentException();
            }
            else if(valorTransacao <=0)
            {
                throw new ArgumentException();
            }else
            {
                this.IdTransacao = 40000000 + ++Transacao.QuantidadeDeTransacoes;
                this.ValorTransacao = valorTransacao * (1 + TAXA_CREDIARIO);
                this.Parcelas = parcelas;
                this.Estado = base.Autorizacao();
            }
            
            
            lista.Add(this);
                          
        }
    
    
    
    }
}