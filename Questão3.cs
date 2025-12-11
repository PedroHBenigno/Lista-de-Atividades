using System;
using System.IO;

class Q3
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

        string conteudo = File.ReadAllText(nome);
        string[] palavras = conteudo.Split(' ', '\n', '\r', '\t');

        int qtd = 0;
        foreach (string p in palavras)
        {
            if (p.Trim().Length > 0)
                qtd++;
        }

        Console.WriteLine("Quantidade de palavras: " + qtd);
    }
}
