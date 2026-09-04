using System;

class Program
{
    static void Main(string[] args)
    {
        // Requisito 3: Gera um número aleatório de 1 a 100
        Random geradorAleatorio = new Random();
        int numeroMagico = geradorAleatorio.Next(1, 101);

        int palpite = -1;

        // Requisito 2: Laço que continua até o usuário acertar o número mágico
        while (palpite != numeroMagico)
        {
            Console.Write("Qual é o seu palpite? ");
            palpite = int.Parse(Console.ReadLine());

            // Requisito 1: Condicionais informando se o número é mais alto ou mais baixo
            if (palpite < numeroMagico)
            {
                Console.WriteLine("Mais alto");
            }
            else if (palpite > numeroMagico)
            {
                Console.WriteLine("Mais baixo");
            }
            else
            {
                Console.WriteLine("Você adivinhou!");
            }
        }
    }
}