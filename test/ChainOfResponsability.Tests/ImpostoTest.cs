using System;
using Xunit;
using ChainOfResponsability;

namespace ChainOfResponsability.Tests
{
    public class ImpostosTest
    {
        [Fact]
        public void DeveCalcularOImpostoCalculandoOICMS()
        {
            var inss = new INSS();
            var salario = new Salario(400);
            var imposto = inss.Tributos(salario);
            Assert.Equal(40, imposto);
        }

        [Fact]
        public void DeveCalcularOImpostoCalculandoOIRPF()
        {
            var inss = new INSS();
            var irpf = new IRPF();
            var salario = new Salario(2200);
            inss.AdicionaProximo(irpf);
            var imposto = inss.Tributos(salario);
            Assert.Equal(550, imposto);
        }

        [Fact]
        public void DeveCalcularSemImpostos()
        {
            var inss = new INSS();
            var irpf = new IRPF();
            var salario = new Salario(600);
            inss.AdicionaProximo(irpf);
            var imposto = inss.Tributos(salario);
            Assert.Equal(0, imposto);
        }
    }
}
