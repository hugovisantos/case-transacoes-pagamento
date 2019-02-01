using System;
using System.Collections.Generic;
using Xunit;

namespace case_transacao.Test
{
    public class TransacaoDebitoTeste
    {
      List<Transacao> lista = new List<Transacao>();
      [Fact]
      
      public void DeveLancarExcecao()
      {
          Debito debito;
          Assert.Throws<ArgumentException>(() => debito = new Debito(-10, lista));
      }   

      [Fact]
      public void IdExistente()
      {          
        var debito = new Debito(1000, lista);
        var debito2 = new Debito(1000, lista);
          
        Assert.True(debito.IdTransacao > 0);
        Assert.True(debito2.IdTransacao > 0);
      }
    }
}