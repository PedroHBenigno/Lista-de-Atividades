using System;

class Q1
{
    public static void Executar()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();
        

        if (string.IsNullOrEmpty(frase))
        {
            Console.WriteLine("Frase vazia.");
            return;
        }

        char inicial = char.ToLower(frase[0]);
        int cont = 0;

        foreach (char c in frase.ToLower())
        {
            if (c == inicial)
                cont++;
        }

        Console.WriteLine($"Caracteres iguais à inicial: {cont}");
    }
}
