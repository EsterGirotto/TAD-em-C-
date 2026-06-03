using System;
using Struct;

namespace TAD
{
    class Program
    {
        static void Main(string[] args)
        {
            JogadorFutebol c1 = new JogadorFutebol("Lucas", "Santos", 1, 0);
            c1.registrarNumeroCartoesAmarelos();
            c1.registrarNumeroCartoesVermelhos();
            Console.WriteLine(c1.imprimir());
            Console.WriteLine(c1.verificarVinculoClube());

            EquipeEsports c2 = new EquipeEsports("MIBR", 2, 50000.00, new DateTime(2026, 2, 15));
            c2.registrarCampeonatoVencido(10000.00);
            Console.WriteLine(c2.imprimir());
            Console.WriteLine(c2.verificarAnoEstreia());

            Produto c3 = new Produto("Teclado", 200.00, 5);
            c3.aplicarCupomDescontoValor(20.00);
            c3.aplicarCupomDescontoPorcentagem(10.00);
            Console.WriteLine(c3.imprimir());
            Console.WriteLine(c3.verificarQuantidadeEmEstoque());

            Professor c4 = new Professor("Bruno", 3000.00, 20);
            c4.reajusteSalarialEmValor(200.00);
            c4.reajusteSalarialEmPorcentagem(10.00);
            c4.descontoSalarialPorFaltaEmValor(100.00);
            c4.descontoSalarialPorFaltaEmPorcentagem(5.00);
            c4.aumentarCargaHorariaDeTrabalho(4, 300.00);
            Console.WriteLine(c4.imprimir());
        }
    }
}
