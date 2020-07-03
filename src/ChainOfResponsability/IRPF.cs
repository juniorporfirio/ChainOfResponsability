namespace ChainOfResponsability
{
    public class IRPF : CalculoBase
    {
        public override decimal Tributos(Salario salario)
        {
            if (salario.Valor > 2000)
                return salario.Valor * 0.25m;
            else
                return base.Tributos(salario);
        }
    }
}