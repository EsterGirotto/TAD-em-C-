using System;

struct EquipeEsports
{
    public string nome;
    public int campeonatosVencidos;
    public double valorTotalPremiacoes;
    public DateTime dataEstreia;

    public void registrarCampeonatoVencido(double valorPremio)
    {
        campeonatosVencidos++;
        atualizarValorTotalPremiacoes(valorPremio);
    }

    public void atualizarValorTotalPremiacoes(double valor)
    {
        valorTotalPremiacoes += valor;
    }

    public void verificarAnoEstreia()
    {
        if (dataEstreia.Year == DateTime.Now.Year)
            Console.WriteLine("Equipe novata");
        else
            Console.WriteLine("Equipe veterana");
    }

    public void imprimir()
    {
        Console.WriteLine(nome);
        Console.WriteLine(campeonatosVencidos);
        Console.WriteLine(valorTotalPremiacoes);
        Console.WriteLine(dataEstreia.ToShortDateString());
    }
}