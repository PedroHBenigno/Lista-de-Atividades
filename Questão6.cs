using System;
using System.IO;

class Q6
{
    public static void Executar()
    {
        Console.Write("Digite um número: ");
        int n = int.Parse(Console.ReadLine());

        int soma = 0;

        Console.WriteLine("Divisores:");
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine(i);
                soma += i;
            }
        }

        File.WriteAllText("somaDivisores.txt", soma.ToString());
        Console.WriteLine("Soma salva em somaDivisores.txt");
    }
}
