using Xunit;
using System;
using System.Collections.Generic;

namespace case_transacao.Test
{
    public class TransacaoCreditoTeste
    {
        List<Transacao> lista = new List<Transacao>();
        [Fact]
        public void DeveLimitarAsParcelas()
        {
            Credito credito; 
            Assert.Throws<ArgumentException>(()=> credito = new Credito(5000, 13, lista));
        }
        [Fact]
        public void IdExistente()
      {
          
          var credito = new Credito(1000, 1, lista);
          var credito2 = new Credito(1000, 1, lista);
          Assert.True(credito.IdTransacao > 0);
          Assert.True(credito2.IdTransacao > 0);
          
      }
    }
}