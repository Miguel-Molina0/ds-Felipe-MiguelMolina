using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_CONTADOR
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int contador = 0; contador <= 20; contador++)
            {
                Console.WriteLine(contador);
            }


            Console.WriteLine("");


            for (int contador2 = 0; contador2 <= 20; contador2++)
            {
                Console.Write(contador2 + " ");
            }
            Console.WriteLine();

        }
    }
}
