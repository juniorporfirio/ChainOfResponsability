using System;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            var inss = new INSS();
            var iprf = new IRPF();

            var salario = new Salario(1200);

            inss.AdicionaProximo(iprf);

            var valores = inss.Tributos(salario);

            Console.WriteLine(valores);
        }
    }
}
