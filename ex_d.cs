using System;

struct Professor
{
    public string nome;
    public double salario;
    public int cargaHoraria;

    public void reajusteSalarialEmValor(double valor)
    {
        salario += valor;
    }

    public void reajusteSalarialEmPorcentagem(double porcentagem)
    {
        salario += salario * (porcentagem / 100);
    }

    public void descontoSalarialPorFaltaEmValor(double valor)
    {
        salario -= valor;
    }

    public void descontoSalarialPorFaltaEmPorcentagem(double porcentagem)
    {
        salario -= salario * (porcentagem / 100);
    }

    public void aumentarCargaHorariaDeTrabalho(int horas)
    {
        cargaHoraria += horas;
        salario += 200;
    }

    public void imprimir()
    {
        Console.WriteLine(nome);
        Console.WriteLine(salario);
        Console.WriteLine(cargaHoraria);
    }
}