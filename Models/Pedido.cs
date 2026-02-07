using System;
using MiniLoja.Discounts;

namespace MiniLoja.Models;

public enum StatusPedido
{
    Aberto,
    Pago,
    Cancelado
}

public class Pedido
{
    public Guid Id { get; } = Guid.NewGuid();
    public StatusPedido Status { get; private set; } = StatusPedido.Aberto;

    public Carrinho Carrinho { get; }
    public IDesconto Desconto { get; }

    public Pedido(Carrinho carrinho, IDesconto desconto)
    {
        Carrinho = carrinho ?? throw new ArgumentNullException(nameof(carrinho));
        Desconto = desconto ?? throw new ArgumentNullException(nameof(desconto));
    }

    public decimal TotalFinal => Carrinho.TotalComDesconto(Desconto);

    public void Pagar()
    {
        if (Carrinho.Itens.Count == 0)
            throw new InvalidOperationException("Não é possível pagar sem itens.");

        Status = StatusPedido.Pago;
    }
}
