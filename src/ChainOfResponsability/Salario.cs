namespace ChainOfResponsability
{
    public class Salario
    {
        public decimal Valor { get; private set; }

        public Salario(decimal valor) =>
         Valor = valor;
    }
}