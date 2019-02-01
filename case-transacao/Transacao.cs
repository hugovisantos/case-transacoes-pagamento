using System;

namespace  case_transacao
{

    public abstract class Transacao
    {
        public static int QuantidadeDeTransacoes;
        public int IdTransacao { get; protected set; }
        public bool Estado { get; protected set; }


        public bool Autorizacao()
        {
            Random rdn = new Random();
                        
            return 2 == rdn.Next(1, 3);

            
        }

    }

    
}