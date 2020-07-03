namespace ChainOfResponsability
{
    public class INSS : CalculoBase
    {

        public override decimal Tributos(Salario salario)
        {
            if (salario.Valor < 500)
                return salario.Valor * 0.1m;
            else
                return base.Tributos(salario);
        }
    }
}