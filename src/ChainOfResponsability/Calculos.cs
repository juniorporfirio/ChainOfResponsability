namespace ChainOfResponsability
{
    public interface ICalculo
    {
        void AdicionaProximo(ICalculo calculo);
        decimal Tributos(Salario salario);

    }
}