using System;
using System.IO;

class Q10
{
    public static void Executar()
    {
        Console.Write("Nome do arquivo: ");
        string nome = Console.ReadLine();

        if (!File.Exists(nome))
        {
            Console.WriteLine("Arquivo não encontrado.");
            return;
        }

        string[] linhas = File.ReadAllLines(nome);

        double soma = 0;
        double max = double.MinValue;
        double min = double.MaxValue;
        int qtd = 0;

        foreach (string linha in linhas)
        {
            double v = double.Parse(linha);
            soma += v;
            qtd++;

            if (v > max) max = v;
            if (v < min) min = v;
        }

        Console.WriteLine($"Máximo: {max}");
        Console.WriteLine($"Mínimo: {min}");
        Console.WriteLine($"Média: {soma / qtd}");
    }
}
