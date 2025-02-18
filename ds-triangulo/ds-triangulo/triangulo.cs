using System;

public class Program
{
    public static void Main()
    {

        double n1;
        double n2;
        double n3;


            
        
       Console.WriteLine("digite a primeira medida");
        n1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("digite a segunda medida");
        n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("digite a terceira medida");
        n3 = Convert.ToDouble(Console.ReadLine());

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