namespace MiniLoja.Discounts;

public interface IDesconto
{
    decimal Aplicar(decimal total);
}
