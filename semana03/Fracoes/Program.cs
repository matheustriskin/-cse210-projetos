using System;

class Program
{
    static void Main(string[] args)
    {
        // Testando o construtor sem parâmetros (1/1)
        Fracao f1 = new Fracao();
        Console.WriteLine(f1.ObterFracaoEmTexto());
        Console.WriteLine(f1.ObterFracaoEmDecimal());

        // Testando o construtor com 1 parâmetro (5/1)
        Fracao f2 = new Fracao(5);
        Console.WriteLine(f2.ObterFracaoEmTexto());
        Console.WriteLine(f2.ObterFracaoEmDecimal());

        // Testando o construtor com 2 parâmetros (3/4)
        Fracao f3 = new Fracao(3, 4);
        Console.WriteLine(f3.ObterFracaoEmTexto());
        Console.WriteLine(f3.ObterFracaoEmDecimal());

        // Testando o construtor com 2 parâmetros (1/3)
        Fracao f4 = new Fracao(1, 3);
        Console.WriteLine(f4.ObterFracaoEmTexto());
        Console.WriteLine(f4.ObterFracaoEmDecimal());
    }
}