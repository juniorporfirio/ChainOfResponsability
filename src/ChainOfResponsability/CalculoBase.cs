namespace ChainOfResponsability
{
    public class CalculoBase : ICalculo
    {

        private ICalculo Proximo;

        public virtual decimal Tributos(Salario salario)
        {
            if (Proximo != null)
                return Proximo.Tributos(salario);
            else
                return 0;
        }

        public void AdicionaProximo(ICalculo calculo)
        {
            Proximo = calculo;
        }
    }
}