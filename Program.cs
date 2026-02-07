using System;
using MiniLoja.Models;
using MiniLoja.Discounts;

var carrinho = new Carrinho();

carrinho.Adicionar(new Produto("Fone Bluetooth", 89.90m));
carrinho.Adicionar(new Produto("Mouse", 50m));

var pedido = new Pedido(carrinho, new DescontoCupomPercentual(0.10m));

Console.WriteLine($"Total final: R$ {pedido.TotalFinal:F2}");
pedido.Pagar();
Console.WriteLine($"Status: {pedido.Status}");
