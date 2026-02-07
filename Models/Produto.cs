using System;

namespace MiniLoja.Models;

public class Produto
{
    public string Nome { get; }
    public decimal Preco { get; }

    public Produto(string nome, decimal preco)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("Nome inválido.");

        if (preco <= 0)
            throw new ArgumentException("Preço deve ser maior que zero.");

        Nome = nome;
        Preco = preco;
    }

    public override string ToString() => $"{Nome} - R$ {Preco:F2}";
}
