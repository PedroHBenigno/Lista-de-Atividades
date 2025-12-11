using System;
using System.IO;

class Q5
{
    public static void Executar()
    {
        Console.Write("Nome do arquivo: ");
        string nome = Console.ReadLine();

        if (!File.Exists(nome))
        {
            Console.WriteLine("Arquivo inexistente.");
            return;
        }

        string[] linhas = File.ReadAllLines(nome);

        foreach (string linha in linhas)
            Console.WriteLine(linha);

        Console.WriteLine($"\nQuantidade de linhas: {linhas.Length}");
    }
}
