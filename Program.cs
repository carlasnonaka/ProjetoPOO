using System;
using ProjetoPOO.src.Entities;

/* DUNGEON
 Criando os personagens do jogo de RPG, inventei uma regra para o jogo ficar mais animado.
 Você escolhe seu personagem e possui 10 pontos para distribuir entre Ataque, Defesa e Bônus
 Assim que colocar os dados do primeiro e do segundo jogador, o computador mostra quem venceu.
 Ganha quem conseguir mais pontos ao final da luta que se dará da seguinte forma:
 Ataque: diminui a pontuação do Oponente
 Defesa: aumenta seus pontos de vida
 Bonus: multiplica o valor do seu ataque e os seus pontos de vida
 *Lembrando que é necessário equilibrar 10 pontos entre os 3 itens e que sua vida começa com o valor
 fixo de 10, podendo dependendo do ataque do seu oponente, ou na sua estratégia ficar com a vida negativa ou nula. 
*/

namespace ProjetoPOO 
{
    class Program 
    {
        static void Main(string[] args)
        {
            int[] ataque = new int[2];
            int[] defesa = new int[2]; 
            int[] bonus  = new int[2];
            int[] vida = new int[2] {10,10};
            string[] heroi  = new string[2]; 
            int soma, i;

            for (i=0; i<2; i++)
            {
                System.Console.WriteLine("\n{0,-36}",$" *** ESCOLHA DO {i+1}º JOGADOR: *** ");
            System.Console.WriteLine("Digite com qual herói deseja jogar: ");
            System.Console.WriteLine("______________________________________");
            System.Console.WriteLine("               1. Arus                ");
            System.Console.WriteLine("               2. Jenica              ");
            System.Console.WriteLine("               3. Wedge               ");
            System.Console.WriteLine("               4. Topapa              ");
            System.Console.WriteLine("______________________________________");
            int op = Convert.ToInt32(Console.ReadLine());

            do
                    {
                        System.Console.Write("Digite o valor do Ataque: ");
                        ataque[i] = Convert.ToInt32(Console.ReadLine());
                        System.Console.Write("Digite o valor da Defesa: ");
                        defesa[i] = Convert.ToInt32(Console.ReadLine());
                        System.Console.Write("Digite o valor do Bônus: ");
                        bonus[i] = Convert.ToInt32(Console.ReadLine());
                        soma = ataque[i] + defesa[i] + bonus[i];

                        if (soma < 10)
                        {
                            System.Console.WriteLine("A soma dos 3 itens são menores que o total de 10 pontos. Refaça a operação!");
                        } 
                        else if (soma > 10)
                        {
                            System.Console.WriteLine("A soma dos 3 itens são maiores que o total de 10 pontos. Refaça a operação!");
                        }

                    } while (soma != 10);

                soma = 0;
            System.Console.WriteLine("\nHerói escolhido pelo {0}º Jogador: ",(i+1));
            switch (op)
            {
                case 1:
                    Knight arus = new Knight("Arus", 10, "Knight");
                    heroi[i] = arus.Name;
                    Console.WriteLine(arus.ToString());
                    arus.Poderes(ataque[i], defesa[i], bonus[i]);
                    if (bonus[i].Equals(0))
                    {
                        Console.WriteLine(arus.Attack());
                    } 
                    else
                    {
                        Console.WriteLine(arus.Attack(bonus[i]));
                    }  
                break;
                case 2:
                    Wizard whitewizard = new Wizard("Jenica", 10, "White Wizard");
                    heroi[i] = whitewizard.Name;
                    Console.WriteLine(whitewizard.ToString());
                    whitewizard.Poderes(ataque[i], defesa[i], bonus[i]);
                    if (bonus[i].Equals(0))
                    {
                        Console.WriteLine(whitewizard.Attack());
                    } 
                    else
                    {
                        Console.WriteLine(whitewizard.Attack(bonus[i]));
                    }  
                break;
                case 3:

                    Ninja ninja = new Ninja("Wedge", 10, "Ninja");
                    heroi[i] = ninja.Name;
                    Console.WriteLine(ninja.ToString());
                    ninja.Poderes(ataque[i], defesa[i], bonus[i]);
                    if (bonus[i].Equals(0))
                    {
                        Console.WriteLine(ninja.Attack());
                    } 
                    else
                    {
                        Console.WriteLine(ninja.Attack(bonus[i]));
                    }  

                break;
                case 4:
                    Wizard blackwizard = new Wizard("Topapa", 10, "Black Wizard");
                    heroi[i] = blackwizard.Name;
                    Console.WriteLine(blackwizard.ToString());
                    blackwizard.Poderes(ataque[i], defesa[i], bonus[i]);
                    if (bonus[i].Equals(0))
                    {
                        Console.WriteLine(blackwizard.Attack());
                    } 
                    else
                    {
                        Console.WriteLine(blackwizard.Attack(bonus[i]));
                    }  

                break;
                default:
                    System.Console.WriteLine("Escolha Inválida. Digite outra opção!");
                break;
            }

                ataque[i] = (ataque[i]*bonus[i]);
                defesa[i] = (defesa[i]*bonus[i]);
                vida[i] = (vida[i]+defesa[i]);

            }

            for (i=0; i<2; i++)
            {
                if (i == 0)
                {
                    vida[i] = vida[i]-ataque[i+1];
                }
                else
                {
                    vida[i] = vida[i]-ataque[i-1];
                }
                
            }

            if (vida[0] > vida[1])
            {
                 System.Console.WriteLine("\nQuem ganhou a batalha foi o 1º Jogador veja a tabela: ");
            }
            else if (vida[0] < vida[1])
            {
                System.Console.WriteLine("\nQuem ganhou a batalha foi o 2º Jogador veja a tabela: ");

            }
            else 
            {
                System.Console.WriteLine("\nHouve empate entre os dois jogadores, veja a tabela: ");
            }

                System.Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15} {5,-15} {6,-15}","JOGADOR", "HERÓI", "ATAQUE_TOTAL", "DEFESA_TOTAL", "BÔNUS", "VIDA_INICIAL", "VIDA_FINAL");
                System.Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15} {5,-15} {6,-15}","   1º  ",heroi[0],ataque[0],defesa[0],bonus[0],10,vida[0]);
                System.Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15} {5,-15} {6,-15}","   2º  ",heroi[1],ataque[1],defesa[1],bonus[1],10,vida[1]);
            
            Console.ReadKey();
        }

    }
}
