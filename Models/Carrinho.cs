using System.Collections.Generic;
using System.Linq;
using MiniLoja.Discounts;

namespace MiniLoja.Models;

public class Carrinho
{
    private readonly List<Produto> _produtos = new();

    public IReadOnlyList<Produto> Itens => _produtos;

    public void Adicionar(Produto produto) => _produtos.Add(produto);

    public decimal TotalBruto() => _produtos.Sum(p => p.Preco);

    public decimal TotalComDesconto(IDesconto desconto) => desconto.Aplicar(TotalBruto());
}
