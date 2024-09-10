/*-------------------------------------------------------------------
Questão 2: Sistema de Pontuação de Missões
• Contextualização: Em um jogo de aventuras, o jogador ganha pontos ao completar 
missões. A pontuação é calculada com base na dificuldade da missão, na quantidade 
de inimigos derrotados e no tempo gasto para completar.
• Comando: Crie um programa que receba a dificuldade da missão (Fácil, Média, Difícil), 
o número de inimigos derrotados e o tempo gasto (em minutos). Crie uma função para 
calcular a pontuação da missão usando os seguintes critérios:
• Fácil: 5 pontos por inimigo, sem penalidade de tempo.
• Média: 10 pontos por inimigo, -2 pontos por minuto acima de 10 minutos.
• Difícil: 15 pontos por inimigo, -5 pontos por minuto acima de 15 minutos.
• Exiba a pontuação final do jogador.
@Lista: 04 
@Autor: PEDRO LIMA
@Data: 08/09/2024
---------------------------------------------------------------------*/

using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        Console.Clear();

        string? ndifficulty;
        int nIni, tg;

        Console.WriteLine("escreva o nível de dificuldade (facil, media ou dificil): ");
        ndifficulty = Console.ReadLine();

        Console.WriteLine("escreva o número de inimigos: ");
        int.TryParse(Console.ReadLine(), out nIni);

        Console.WriteLine("escreva o tempo gasto: ");
        int.TryParse(Console.ReadLine(), out tg);

        int total = Some(nIni, tg, ndifficulty);

        Console.WriteLine("a sua pontuação de vida é: " + total);

        Console.WriteLine("\nPressione ENTER para fechar.");
        Console.ReadLine();
    }
    static int Some(int nIni, int tg, string? ndifficulty)
    {
        //int penaliza1 = 0;
        int total = 0;

        if (ndifficulty == "facil")
        {
            total = (5 * nIni);
        }

        if (ndifficulty == "media")
        {
            int tempoT = (tg - 10) * 2;

            total = (10 * nIni) - tempoT;
        }
        if (ndifficulty == "dificil")
        {
            int tempoT = (tg- 15) * 5;

            total = (15 * nIni) - tempoT;
        }
        return total;


    }


}