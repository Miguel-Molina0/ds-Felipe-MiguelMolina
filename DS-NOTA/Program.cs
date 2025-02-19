using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_NOTA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite uma nota de 0 a 10");
            int nota = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            while (nota > 10) 
            {
                Console.WriteLine("nota invalida, mandar novamente");

                Console.WriteLine("");

                Console.WriteLine("digite uma nota de 0 a 10");
                nota = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");



            }
            

          
        }
    }
}
