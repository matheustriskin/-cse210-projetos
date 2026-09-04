using System;

class Program
{
    static void Main(string[] args)
    {
        ExibirBoasVindas();

        string nomeUsuario = PerguntarNomeUsuario();
        int numeroFavorito = PerguntarNumeroFavorito();

        int numeroAoQuadrado = ElevarAoQuadrado(numeroFavorito);

        ExibirResultado(nomeUsuario, numeroAoQuadrado);
    }

    // Exibe a mensagem de boas-vindas
    static void ExibirBoasVindas()
    {
        Console.WriteLine("Bem-vindo ao programa!");
    }

    // Solicita e retorna o nome do usuário como string
    static string PerguntarNomeUsuario()
    {
        Console.Write("Por favor, insira seu nome: ");
        string nome = Console.ReadLine();
        return nome;
    }

    // Solicita e retorna o número favorito do usuário como inteiro
    static int PerguntarNumeroFavorito()
    {
        Console.Write("Por favor, insira seu número favorito: ");
        int numero = int.Parse(Console.ReadLine());
        return numero;
    }

    // Aceita um número inteiro e retorna o seu quadrado
    static int ElevarAoQuadrado(int numero)
    {
        int quadrado = numero * numero;
        return quadrado;
    }

    // Aceita o nome e o quadrado e exibe o resultado
    static void ExibirResultado(string nome, int quadrado)
    {
        Console.WriteLine($"{nome}, o quadrado do seu número é {quadrado}");
    }
}