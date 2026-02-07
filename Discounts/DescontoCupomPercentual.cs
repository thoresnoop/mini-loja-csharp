using System;

namespace MiniLoja.Discounts;

public class DescontoCupomPercentual : IDesconto
{
    private readonly decimal _percentual;

    public DescontoCupomPercentual(decimal percentual)
    {
        if (percentual < 0 || percentual > 1)
            throw new ArgumentException("Percentual deve estar entre 0 e 1.");

        _percentual = percentual;
    }

    public decimal Aplicar(decimal total) => total - (total * _percentual);
}
