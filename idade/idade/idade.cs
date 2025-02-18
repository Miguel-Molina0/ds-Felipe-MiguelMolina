using System;

public class Program
{
    public static void Main()
    {
        string nome;
        double idade;
        
        Console.WriteLine("digite seu nome");
        nome = Console.ReadLine();

        Console.WriteLine("digite sua idade");
        idade = Convert.ToDouble(Console.ReadLine());

        if(idade >= 18)
        {
            Console.WriteLine (nome,  "é maior de idade e tem" ,idade, " anos");
        }
    }
}