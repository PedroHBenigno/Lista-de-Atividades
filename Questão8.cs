using System;
using System.IO;

class Q8
{
    public static void Executar()
    {
        string nomeArq = "alunos.txt";

        StreamWriter sw = new StreamWriter(nomeArq, true);

        Console.WriteLine("Cadastro de alunos (matrícula / nome). Digite 0 para parar.");
        while (true)
        {
            Console.Write("Matrícula: ");
            string mat = Console.ReadLine();

            if (mat == "0") break;

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            sw.WriteLine(mat + ";" + nome);
        }

        sw.Close();

        Console.Write("\nBuscar matrícula: ");
        string busca = Console.ReadLine();

        string[] linhas = File.ReadAllLines(nomeArq);

        foreach (string linha in linhas)
        {
            string[] partes = linha.Split(';');
            if (partes[0] == busca)
            {
                Console.WriteLine("Nome encontrado: " + partes[1]);
                return;
            }
        }

        Console.WriteLine("Matrícula não encontrada.");
    }
}
