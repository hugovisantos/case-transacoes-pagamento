using Xunit;
using System;
using System.Collections.Generic;

namespace case_transacao.Test
{
    public class TransacaoCrediarioTeste
    {
        

        List<Transacao> lista = new List<Transacao>();
        [Fact]
        public void LimitarAsParcelas()
        {
            Crediario crediario;
            Assert.Throws<ArgumentException>( ()=> crediario = new Crediario(1000, 25, lista));
        }

        [Fact]
        public void TaxarOValorFinal()
        {
            const double TAXA_CREDIARIO = 0.015;
            var valorEsperado = 1000 * (1 + TAXA_CREDIARIO);
            var crediario = new Crediario(1000, 12, lista);
            Assert.Equal(valorEsperado, crediario.ValorFinal());
        }
        
        [Fact]
        public void IdExistente()
        {
            var crediario = new Crediario(1000.0, 1, lista);
            Assert.True(crediario.IdTransacao > 0);
            
        }

    }
}