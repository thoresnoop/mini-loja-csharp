namespace MiniLoja.Discounts;

public class SemDesconto : IDesconto
{
    public decimal Aplicar(decimal total) => total;
}
