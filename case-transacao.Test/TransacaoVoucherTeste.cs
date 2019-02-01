using Xunit;
using System;
using System.Collections.Generic;

namespace case_transacao.Test
{
    public class TransacaoVoucherTeste
    {
        List<Transacao> lista = new List<Transacao>();
        [Fact]
        public void LimitaAsParcelas()
        {
        Voucher voucher;
        Assert.Throws<ArgumentException>(() => voucher = new Voucher(-500, lista));
        }

        [Fact]
        public void IdExistente()
        {
            var voucher = new Voucher(1000, lista);
            var voucher2 = new Voucher(1000, lista);
            Assert.True(voucher.IdTransacao > 0);
            Assert.True(voucher2.IdTransacao >0);
        }
    }
}