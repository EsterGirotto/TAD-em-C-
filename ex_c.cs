namespace Struct;

public struct Produto
{
    public string nome;
    public double preco;
    public int quantidadeEstoque;

    public Produto(string nome, double preco, int quantidadeEstoque)
    {
        this.nome = nome;
        this.preco = preco;
        this.quantidadeEstoque = quantidadeEstoque;
    }

    public void aplicarCupomDescontoValor(double valor)
    {
        this.preco -= valor;
    }

    public void aplicarCupomDescontoPorcentagem(double porcentagem)
    {
        this.preco -= this.preco * (porcentagem / 100);
    }

    public string verificarQuantidadeEmEstoque()
    {
        if (this.quantidadeEstoque > 0)
            return "Produto disponivel.";

        return "Sem estoque.";
    }

    public string imprimir()
    {
        return "\nNome: " + this.nome +
               "\nPreco: " + this.preco +
               "\nQuantidade em estoque: " + this.quantidadeEstoque;
    }
}
