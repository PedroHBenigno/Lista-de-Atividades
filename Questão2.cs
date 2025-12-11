using System;

class Q2
{
    public static void Executar()
    {
        Console.Write("Digite a frase: ");
        string frase = Console.ReadLine();

        string semEspacos = frase.Replace(" ", "");
        Console.WriteLine(semEspacos);
    }
}
