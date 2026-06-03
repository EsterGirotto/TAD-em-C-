using System;

namespace Struct;

public struct EquipeEsports
{
    public string nome;
    public int numeroCampeonatosVencidos;
    public double valorTotalPremiacoes;
    public DateTime dataEstreia;

    public EquipeEsports(string nome, int numeroCampeonatosVencidos, double valorTotalPremiacoes, DateTime dataEstreia)
    {
        this.nome = nome;
        this.numeroCampeonatosVencidos = numeroCampeonatosVencidos;
        this.valorTotalPremiacoes = valorTotalPremiacoes;
        this.dataEstreia = dataEstreia;
    }

    public void registrarCampeonatoVencido(double valorPremio)
    {
        this.numeroCampeonatosVencidos++;
        this.atualizarValorTotalPremiacoes(valorPremio);
    }

    public void atualizarValorTotalPremiacoes(double valor)
    {
        this.valorTotalPremiacoes += valor;
    }

    public string verificarAnoEstreia()
    {
        if (this.dataEstreia.Year == DateTime.Now.Year)
            return "Equipe novata.";

        return "Equipe veterana.";
    }

    public string imprimir()
    {
        return "\nNome: " + this.nome +
               "\nCampeonatos vencidos: " + this.numeroCampeonatosVencidos +
               "\nValor total das premiacoes: " + this.valorTotalPremiacoes +
               "\nData de estreia: " + this.dataEstreia.ToShortDateString();
    }
}
