
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
        int vitoria1 = 0;
        int vitoria2 = 0;
        int placa = 0;
        int placa1 = 0;

        Console.Write("digite 1 se quiser enfrentar outro jogador e 2 se quiser enfrentar uma máquina: ");
        int player0 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("");

        switch (player0)
        {
            case 1:

                
                backnmD:
                Console.Clear();
                Console.Write("digite o nome do jogador 1: ");
                string player1 = Console.ReadLine();

                Console.WriteLine("");

                Console.Write("digite o nome do jogador 2: ");
                string player2 = Console.ReadLine();

                
                Console.WriteLine("");

                back:
                Console.Clear();
                Console.WriteLine($"{player1}");
                Console.Write("caso queira jogar pedra digite '1', caso queire tesoura digite '2' e caso queire papel digite '3': ");
                int opcao1 = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("");

                Console.WriteLine($"{player2}");
                Console.Write("caso queira jogar pedra digite '1', caso queire tesoura digite '2' e caso queire papel digite '3': ");
                int opcao2 = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("");

                int vitoria = GmAn(opcao1, opcao2, player1, player2);

                if(vitoria == 1)
                {
                    vitoria1++;
                }
                else if(vitoria == 2) 
                {
                    vitoria2++;
                }
        
                Console.WriteLine("");

                Console.WriteLine("Número vitorias");
                Console.WriteLine($"{player1}: {vitoria1} ");
                Console.WriteLine($"{player2}: {vitoria2}");

                Console.WriteLine("");

                escolhaback:
                Console.Write("caso queira jogar denovo digite '1', caso queira parar digite '2', caso queira jogar denovo com nomes diferentes digite '3': ");
                int opcao = Convert.ToInt16(Console.ReadLine());

                if (opcao == 2)
                {
                    return;
                }

               else if (opcao == 1)
                {
                    goto back;
                }
                else if(opcao == 3)
                {
                    vitoria1 = 0;
                    vitoria2 = 0;
                    goto backnmD;
                    
                }
                else
                {
                    Console.WriteLine("Número Invalido");
                    goto escolhaback;
                }
        
            case 2:
                Console.WriteLine("digite o seu nome");
                string player5 = Console.ReadLine();

                back1:
                Console.Clear();
                Console.WriteLine($"{player5}");
                Console.Write("caso queira jogar pedra digite '1', caso queire tesoura digite '2' e caso queire papel digite '3': ");
                int opcao5 = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("");

                Random rnd = new Random();
                int jgdMaquina = rnd.Next(1,4);

                switch (jgdMaquina)

                {
                    case 1: Console.WriteLine("Maquina jogou pedra");
                        break;
                    case 2:
                        Console.WriteLine("Maquina jogou tesoura");
                        break;
                    case 3:
                        Console.WriteLine("Maquina jogou papel");
                        break;

                }

                int vncdr = GmAn(opcao5, jgdMaquina, player5, "maquina");

                if (vncdr == 1)
                {
                    placa++;
                    
                }
                else if (vncdr == 2)
                {
                    placa1++;
                }

                Console.WriteLine("");

                Console.WriteLine("Número vitorias");
                Console.WriteLine($"{player5}: {placa} ");
                Console.WriteLine($"Máquina: {placa1}");

            escolhaback1:
                Console.Write("caso queira jogar denovo digite '1', caso queira parar digite '2', caso queira jogar denovo contra um player digite '3': ");
                int opcao10 = Convert.ToInt16(Console.ReadLine());

                if (opcao10 == 2)
                {
                    return;
                }

                else if (opcao10 == 1)
                {
                    goto back1;
                }
                else if (opcao10 == 3)
                {
                    placa = 0;
                    placa1 = 0;
                    goto backnmD;

                }
                else
                {
                    Console.WriteLine("Número Invalido");
                    goto escolhaback1;
                }



                break;

            default: Console.WriteLine("inválido."); break;
        }
       
    }
    static int GmAn(int opcao1, int opcao2, string jogd1, string jogd2)
    {
        int vencedor = 0;
        if (opcao1 == 1 && opcao2 == 1)
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
            Console.WriteLine($"{jogd1} ganhou!!!"); vencedor = 1;
        }

        else if (opcao1 == 2 && opcao2 == 3)
        {
            Console.WriteLine($"{jogd1} ganhou!!!"); vencedor = 1;
        }

        else if (opcao1 == 3 && opcao2 == 1)
        {
            Console.WriteLine($"{jogd1} ganhou!!!"); vencedor = 1;
        }

        else if (opcao1 == 2 && opcao2 == 1)
        {
            Console.WriteLine($"{jogd2} ganhou!!!"); vencedor = 2;
        }

        else if (opcao1 == 3 && opcao2 == 2)
        {
            Console.WriteLine($"{jogd2} ganhou!!!"); vencedor = 2;
        }

        else if (opcao1 == 1 && opcao2 == 3)
        {
            Console.WriteLine($"{jogd2} ganhou!!!"); vencedor = 2;
        }
        else
        {
            Console.WriteLine("inválido");
        }
        return vencedor;
    }
}