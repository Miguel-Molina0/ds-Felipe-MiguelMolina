using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_IMPAR
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
