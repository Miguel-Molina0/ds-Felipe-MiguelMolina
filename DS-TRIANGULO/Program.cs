using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_TRIANGULO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            Console.WriteLine("digite a primeira medida");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite a segunda medida");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite a terceira medida");
            double n3 = Convert.ToDouble(Console.ReadLine());

            if (n1 <= n2 + n3 && n2 <= n1 + n3 && n3 <= n1 + n2)
            {
                Console.WriteLine("é um triangulo");

                if (n1 == n2 && n2 == n3 && n1 == n3)
                {
                    Console.WriteLine("é um triangulo equilátero");
                }

                else if (n1 != n2 && n1 != n3 && n2 != n3)
                {
                    Console.WriteLine("é um triangulo escaleno");
                }

                else
                {
                    Console.WriteLine("é um triângulo isoceles");
                }
            }

            else
            {
                Console.WriteLine("não é triangulo");
            }
        }
    }
}
