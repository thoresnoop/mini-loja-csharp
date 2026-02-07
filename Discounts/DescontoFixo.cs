using System;

namespace MiniLoja.Discounts;

public class DescontoFixo : IDesconto
{
    private readonly decimal _valor;

    public DescontoFixo(decimal valor)
    {
        if (valor < 0)
            throw new ArgumentException("Valor do desconto não pode ser negativo.");

        _valor = valor;
    }

    public decimal Aplicar(decimal total)
    {
        var final = total - _valor;
        return final < 0 ? 0 : final;
    }
}
