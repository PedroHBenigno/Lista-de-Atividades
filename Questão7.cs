using System;
using System.IO;

class Q7
{
    public static void Executar()
    {
        Console.Write("Quantas letras deseja inserir? ");
        int n = int.Parse(Console.ReadLine());

        string nomeArq = "letras.txt";
        StreamWriter sw = new StreamWriter(nomeArq);

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Letra {i + 1}: ");
            char l = char.Parse(Console.ReadLine());
            sw.Write(l);
        }

        sw.Close();

        string conteudo = File.ReadAllText(nomeArq).ToLower();
        int vogais = 0;

        foreach (char c in conteudo)
        {
            if ("aeiou".Contains(c))
                vogais++;
        }

        Console.WriteLine("Quantidade de vogais: " + vogais);
    }
}
