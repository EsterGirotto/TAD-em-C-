namespace Struct;

public struct JogadorFutebol
{
    public string nome;
    public string clube;
    public int numeroCartoesAmarelos;
    public int numeroCartoesVermelhos;

    public JogadorFutebol(string nome, string clube, int numeroCartoesAmarelos, int numeroCartoesVermelhos)
    {
        this.nome = nome;
        this.clube = clube;
        this.numeroCartoesAmarelos = numeroCartoesAmarelos;
        this.numeroCartoesVermelhos = numeroCartoesVermelhos;
    }

    public void registrarNumeroCartoesAmarelos()
    {
        this.numeroCartoesAmarelos++;
    }

    public void registrarNumeroCartoesVermelhos()
    {
        this.numeroCartoesVermelhos++;
    }

    public string verificarVinculoClube()
    {
        if (this.clube != "")
            return "Possui vinculo com clube.";

        return "Sem clube.";
    }

    public string imprimir()
    {
        return "\nNome: " + this.nome +
               "\nClube: " + this.clube +
               "\nCartoes amarelos: " + this.numeroCartoesAmarelos +
               "\nCartoes vermelhos: " + this.numeroCartoesVermelhos;
    }
}
