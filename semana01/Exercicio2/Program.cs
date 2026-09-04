using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual é a porcentagem da sua nota? ");
        string entrada = Console.ReadLine();
        int porcentagem = int.Parse(entrada);

        string letra = "";

        if (porcentagem >= 90)
        {
            letra = "A";
        }
        else if (porcentagem >= 80)
        {
            letra = "B";
        }
        else if (porcentagem >= 70)
        {
            letra = "C";
        }
        else if (porcentagem >= 60)
        {
            letra = "D";
        }
        else
        {
            letra = "F";
        }

        Console.WriteLine($"Sua nota conceitual é: {letra}");

        if (porcentagem >= 70)
        {
            Console.WriteLine("Parabéns! Você foi aprovado no curso!");
        }
        else
        {
            Console.WriteLine("Não desanime! Continue se esforçando para a próxima vez!");
        }
    }
}