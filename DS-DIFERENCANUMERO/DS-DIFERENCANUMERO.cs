
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Runtime.Remoting.Metadata.W3cXsd2001;
            using System.Text;
            using System.Threading.Tasks;
            using static System.Net.Mime.MediaTypeNames;

namespace DS_IDADE
    {
        public class Program
        {
            static void Main(string[] args)
            {


                Console.WriteLine("digite um número");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("digite um número");
                int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            if (n1 < n2)
                {

                    for (int x = n1; x <= n2; x++)
                    {

                        Console.WriteLine(x);
                    }

                }
            else
            {
                for (int x = n2; x <= n1; x++)
                {

                    Console.WriteLine(x);
                }
            }


                
            }
        }
    }

