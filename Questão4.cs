using System;

class Q4
{
    public static void Executar()
    {
        Console.Write("Digite a frase: ");
        string frase = Console.ReadLine().ToUpper();

        string nova = "";

        foreach (char c in frase)
        {
            if (c >= 'A' && c <= 'Z')
            {
                char novoChar = (char)(c + 3);
                if (novoChar > 'Z')
                    novoChar = (char)(novoChar - 26);

                nova += novoChar;
            }
            else
            {
                nova += c;
            }
        }

        Console.WriteLine("String criptografada:");
        Console.WriteLine(nova);
    }
}
