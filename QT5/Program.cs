﻿/*-------------------------------------------------------------------
Questão 5: Escolha de Habilidade Especial
• Contextualização: No jogo, o jogador pode usar habilidades especiais durante a 
batalha. A escolha da habilidade depende da quantidade de mana disponível, do tipo de 
inimigo e da distância do alvo.
• Comando: Crie um programa que receba a quantidade de mana, o tipo de inimigo 
(Normal, Forte, Boss) e a distância do alvo (em metros). Crie uma função que sugira 
qual habilidade usar com base nos seguintes critérios:
• Mana maior que 50: Use Habilidade Poderosa.
• Inimigo Forte ou Boss: +10 mana necessária.
• Distância menor que 10 metros: Reduz a mana necessária em 5.
• Exiba a habilidade sugerida.
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
        string? type;
        double man, dis;

        Console.WriteLine("Qual a sua quantidade de mana? ");
        double.TryParse(Console.ReadLine(), out man);

        Console.WriteLine("Qual sua distância até ao alvo?");
        double.TryParse(Console.ReadLine(), out dis);

        Console.WriteLine("Qual o tipo de inimigo ");
        type = Console.ReadLine();


        double total = Some( man, dis ,type);
        Console.ReadLine();

        Console.WriteLine("o seu ataque foi de: " + total);
    }
    static double Some(double man, double dis, string? type)
    {

        double total = 0;
        
        if (type == "forte" || type == "boss")
        {
            if(dis < 10)
            {
                if(man > 55)
                {
                Console.WriteLine("Use Habilidade Poderosa");
                }
                else
                {
                    Console.WriteLine("Use Habilidade Básica");
                }
            }

        
        else if(man > 60)
        {
                    Console.WriteLine("Use Habilidade Poderosa");
                }
                else
                {
                    Console.WriteLine("Use Habilidade Básica");
                }
            
        }
    
        else if(man > 0)
        {
            if(dis < 10)
            {
                if(man >45)
                {
                    Console.WriteLine("Use Habilidade Poderosa");
                }
                else
                {
                      Console.WriteLine("Use Habilidade Básica");
                }
            }
        }
            else 
            {
            if(man>50)
                {
                     Console.WriteLine("Use Habilidade Poderosa");
                }
                 else
                {
                      Console.WriteLine("Use Habilidade Básica");
                }
            }
            return total;
        }
    }