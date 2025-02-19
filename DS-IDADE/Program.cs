using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_IDADE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("digite sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine(nome + " é maior de idade e tem " + idade + " anos");
            }

            else
            {
                Console.WriteLine(nome + " é menor de idade e tem " + idade + " anos");
            }
        }
    }
}
