using System;

struct Produto
{
    public string nome;
    public double preco;
    public int quantidadeEstoque;

    public void aplicarCupomDescontoValor(double valor)
    {
        preco -= valor;
    }

    public void aplicarCupomDescontoPorcentagem(double porcentagem)
    {
        preco -= preco * (porcentagem / 100);
    }

    public void verificarQuantidadeEmEstoque()
    {
        if (quantidadeEstoque > 0)
            Console.WriteLine("Produto disponível");
        else
            Console.WriteLine("Sem estoque");
    }

    public void imprimir()
    {
        Console.WriteLine(nome);
        Console.WriteLine(preco);
        Console.WriteLine(quantidadeEstoque);
    }
}