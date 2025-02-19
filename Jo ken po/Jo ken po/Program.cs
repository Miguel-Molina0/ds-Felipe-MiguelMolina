
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DS_IDADE
{ }
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("digite 1 se quiser enfrentar outro jogador e 2 se quiser enfrentar uma máquina");
        int player0 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("");
        
        switch (player0)
        {
            case 1: Console.WriteLine("digite o nome do jogador 1");
                    string player1 = Console.ReadLine();

                    Console.WriteLine("");
                    
                    Console.WriteLine("digite o nome do jogador 2");
                    string player2 = Console.ReadLine();

                    Console.WriteLine("");

                    Console.WriteLine("Jogador 1");
                    Console.WriteLine("caso queira jogar pedra digite '1', caso queire tesoura digite '2' e caso queire papel digite '3' ");
                    int opcao1 = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("");

                    Console.WriteLine("Jogador 2");
                    Console.WriteLine("caso queira jogar pedra digite '1', caso queire tesoura digite '2' e caso queire papel digite '3' ");
                    int opcao2 = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("");

                    if (opcao1  == 1 && opcao2 == 1)
                    {
                        Console.WriteLine("empate");
                    }

                    else if (opcao1 == 2 && opcao2 == 2)
                    {
                        Console.WriteLine("empate");
                    }


                    else if (opcao1 == 3 && opcao2 == 3)
                    {
                        Console.WriteLine("empate");
                    }

                    else if (opcao1 == 1 && opcao2 == 2)
                    {
                        Console.WriteLine("jogador 1 ganhou");
                        string score1 = Console.ReadLine();

                        Console.WriteLine("");

                        Console.WriteLine("rank");
                        Console.WriteLine(player1);

                    int contador;

                        score1 = Convert.ToInt16(contador);
                        
                        for (contador = 0;contador < 10000; contador++)
                        {
                            Console.WriteLine(score1);
                        }
                    }

                    else if (opcao1 == 2 && opcao2 == 3)
                    {
                        Console.WriteLine("jogador 1 ganhou");
                    }

                    else if (opcao1 == 3 && opcao2 == 1)
                    {
                        Console.WriteLine("jogador 1 ganhou");
                    }

                    else if (opcao1 == 2 && opcao2 == 1)
                    {
                        Console.WriteLine("jogador 2 ganhou");
                    }

                    else if (opcao1 == 3 && opcao2 == 2)
                    {
                        Console.WriteLine("jogador 2 ganhou");
                    }

                    else if (opcao1 == 1 && opcao2 == 3)
                    {
                        Console.WriteLine("jogador 2 ganhou");
                    }

                    else
                    {
                        Console.WriteLine("inválido");
                    }

                   
                    ; break;

            case 2: Console.WriteLine("digite o seu nome"); 
                    player1 = Console.ReadLine();
                
                
                break;

            default: Console.WriteLine("inválido."); break;
        }
    }
}