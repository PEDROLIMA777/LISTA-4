/*-------------------------------------------------------------------
Questão 3: Cálculo de Dano Crítico
• Contextualização: Em combates, o jogador pode realizar ataques críticos que causam 
danos adicionais. O dano causado depende do ataque base, do multiplicador crítico e 
da arma utilizada.
• Comando: Crie um programa que receba o valor do ataque base, o multiplicador crítico 
(1.5x, 2x, 3x) e o tipo de arma (Espada, Arco, Cajado). Crie uma função que calcule o 
dano crítico da seguinte forma:
• Espada: +10 pontos ao dano total.
• Arco: +5 pontos ao dano total.
• Cajado: +15 pontos ao dano total.
• Exiba o dano total causado pelo ataque crítico.
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
        string? tar;
        double atbase, multcrt;

        Console.WriteLine("escreva quanto foi o ataque base: ");
        double.TryParse(Console.ReadLine(), out atbase);

        Console.WriteLine("escreva o seu multiplicador: ");
        double.TryParse(Console.ReadLine(), out multcrt);

        Console.WriteLine("escreva o tipo de arma (espada, arco ou cajado): ");
        tar = Console.ReadLine();

        double total = Some(atbase, multcrt, tar);
        Console.ReadLine();

        Console.WriteLine("o seu ataque foi de: " + total);

        Console.WriteLine("\nPressione ENTER para fechar.");
        Console.ReadLine();
    }
    static double Some(double atbase, double multcrt, string? tar)
    {

        double total = 0;
        if (tar == "espada")
        {
            total = (multcrt * atbase) + 10;
        }

        if (tar == "arco")
        {
            total = (multcrt * atbase) + 5;
        }

        if (tar == "cajado")
        {
            total = (multcrt * atbase) + 15;
        }
        return total;


    }


}