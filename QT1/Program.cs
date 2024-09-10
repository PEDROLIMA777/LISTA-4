/*-------------------------------------------------------------------
Questão 1: Sistema de Cura de Personagem
• Contextualização: Em um jogo de RPG, o jogador pode usar poções de cura para 
recuperar a vida do seu personagem durante a batalha. A quantidade de vida 
recuperada depende do tipo de poção, do nível do personagem e da quantidade de 
poções usadas.
• Comando: Crie um programa que receba o tipo de poção (Pequena, Média, Grande), o 
nível do personagem e a quantidade de poções usadas. Crie uma função que calcule a 
quantidade de vida recuperada com base nos seguintes critérios:
• Poção Pequena: 10 pontos de vida por poção.
• Poção Média: 20 pontos de vida por poção.
• Poção Grande: 30 pontos de vida por poção.
• Adicione 5 pontos adicionais para cada nível do personagem acima de 5.
• Exiba o total de vida recuperada
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

        string? typeP;
        int level, qP;

     Console.WriteLine("escreva o tipo de poção (pequena, media ou grande): ");
     typeP = Console.ReadLine();

     Console.WriteLine("escreva o nível do jogador: ");
        int.TryParse(Console.ReadLine(), out level);

     Console.WriteLine("escreva a quantidade de poções que deseja tomar?: ");
        int.TryParse(Console.ReadLine(), out qP);

        int total = Some(level, qP, typeP);
     Console.ReadLine();

     Console.WriteLine("a sua pontuação de vida é: " + total);


     Console.WriteLine("\nPressione ENTER para fechar.");
     Console.ReadLine();
    }
        static int Some(int level, int qP, string typeP)
    {
        int level1 = 0;
        int total = 0;
        if (level > 5)
        {
            level = level1 = 5;
        }

        if (typeP == "pequena")
        {
            total = (10 + level1) * qP;
        }

        if (typeP == "media")
        {
            total = (20 + level1) * qP;
        }

        if (typeP == "grande")
        {
            total = (30 + level1) * qP;
        }
        return total;


    }


}