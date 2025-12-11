using System;
using System.IO;

class Q9
{
    public static void Executar()
    {
        string nomeArq = "frases.txt";

        if (!File.Exists(nomeArq))
        {
            Console.WriteLine("Arquivo frases.txt não existe.");
            return;
        }

        string[] frases = File.ReadAllLines(nomeArq);
        Random rnd = new Random();

        while (true)
        {
            int index = rnd.Next(frases.Length);
            Console.WriteLine("\nFrase sorteada:");
            Console.WriteLine(frases[index]);

            Console.Write("Deseja outra? (s/n): ");
            string resp = Console.ReadLine().ToLower();

            if (resp != "s")
                break;
        }
    }
}
