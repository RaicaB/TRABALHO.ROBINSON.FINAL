using System;
using System.Collections.Generic;
using System.Text;
public class DescontoClienteVip : IDesconto
{
    public decimal Calcular(decimal valor)
    {
        return valor - (valor * 0.10m);
    }
}
