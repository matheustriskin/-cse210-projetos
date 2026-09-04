using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();

        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar.");

        int numeroInserido = -1;

        while (numeroInserido != 0)
        {
            Console.Write("Insira o número: ");
            numeroInserido = int.Parse(Console.ReadLine());

            // Não adiciona o 0 à lista
            if (numeroInserido != 0)
            {
                numeros.Add(numeroInserido);
            }
        }

        // Requisito 1: Calcular a soma
        int soma = 0;
        foreach (int numero in numeros)
        {
            soma += numero;
        }
        Console.WriteLine($"A soma é: {soma}");

        // Requisito 2: Calcular a média
        double media = ((double)soma) / numeros.Count;
        Console.WriteLine($"A média é: {media}");

        // Requisito 3: Encontrar o maior número
        int maior = numeros[0];
        foreach (int numero in numeros)
        {
            if (numero > maior)
            {
                maior = numero;
            }
        }
        Console.WriteLine($"O maior número é: {maior}");
    }
}