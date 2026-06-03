namespace Struct;

public struct Professor
{
    public string nome;
    public double salario;
    public int cargaHoraria;

    public Professor(string nome, double salario, int cargaHoraria)
    {
        this.nome = nome;
        this.salario = salario;
        this.cargaHoraria = cargaHoraria;
    }

    public void reajusteSalarialEmValor(double valor)
    {
        this.salario += valor;
    }

    public void reajusteSalarialEmPorcentagem(double porcentagem)
    {
        this.salario += this.salario * (porcentagem / 100);
    }

    public void descontoSalarialPorFaltaEmValor(double valor)
    {
        this.salario -= valor;
    }

    public void descontoSalarialPorFaltaEmPorcentagem(double porcentagem)
    {
        this.salario -= this.salario * (porcentagem / 100);
    }

    public void aumentarCargaHorariaDeTrabalho(int horas, double valorReajuste)
    {
        this.cargaHoraria += horas;
        this.reajusteSalarialEmValor(valorReajuste);
    }

    public string imprimir()
    {
        return "\nNome: " + this.nome +
               "\nSalario: " + this.salario +
               "\nCarga horaria: " + this.cargaHoraria;
    }
}
