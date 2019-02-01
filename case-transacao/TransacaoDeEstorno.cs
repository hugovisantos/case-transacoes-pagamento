using System.Collections.Generic;

namespace case_transacao
{
    public class TransacaoDeEstorno : Transacao
    
    {
        
        public TransacaoDeEstorno(int id, List<Transacao> transacoesEfetuadas)
        {
            var contadorDeTransacoes = 0;
            var aprovado = false;


            foreach(Transacao t in transacoesEfetuadas)
            {
                if(t.IdTransacao == id)
                {
                    contadorDeTransacoes++;
                    aprovado = t.Estado;
                }
            }
            

            if(contadorDeTransacoes == 1)
            { 
                if(aprovado)
                {
                    this.IdTransacao = id;
                    transacoesEfetuadas.Add(this);                    
                } 
                else
                {           
                    throw new System.Exception("Transacao não aprovada");
                }
                
            } 
            else if(contadorDeTransacoes == 2 )
            {
                throw new System.Exception("Transacao já foi estornada");
            } 
            else
            {
                throw new System.Exception("Transacao inexistente");
            }
            
        }
    }
}