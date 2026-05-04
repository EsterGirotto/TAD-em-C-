using System;

struct JogadorFutebol
{
    public string nome;
    public string clube;
    public int cartoesAmarelos;
    public int cartoesVermelhos;

    public void registrarNumeroCartoesAmarelos()
    {
        cartoesAmarelos++;
    }

    public void registrarNumeroCartoesVermelhos()
    {
        cartoesVermelhos++;
    }

    public void verificarVinculoClube()
    {
        if (clube != "")
            Console.WriteLine("Possui vínculo com clube.");
        else
            Console.WriteLine("Sem clube.");
    }

    public void imprimir()
    {
        Console.WriteLine(nome);
        Console.WriteLine(clube);
        Console.WriteLine(cartoesAmarelos);
        Console.WriteLine(cartoesVermelhos);
    }
}