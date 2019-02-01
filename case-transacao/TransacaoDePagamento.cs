namespace case_transacao
{
    public abstract class  TransacaoDePagamento : Transacao
    {
        public double ValorTransacao { get;  protected set; }       
        public int Parcelas { get; protected set; }
        public int MaximoDeParcelas { get; protected set; }        
        
        public virtual double ValorFinal()
        {
           return this.ValorTransacao;
        }
    }
}