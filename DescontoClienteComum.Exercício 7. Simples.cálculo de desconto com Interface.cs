using System;
using System.Collections.Generic;
using System.Text;
public class DescontoClienteComum : IDesconto
{
    public decimal Calcular(decimal valor)
    {
        return valor - (valor * 0.05m);
    }
}
