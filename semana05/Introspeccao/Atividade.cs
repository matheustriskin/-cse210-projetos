using System;
using System.Threading;

public class Atividade
{
    private string _nome;
    private string _descricao;
    private int _duracao;

    public Atividade(string nome, string descricao)
    {
        _nome = nome;
        _descricao = descricao;
        _duracao = 0;
    }

    public int ObterDuracao()
    {
        return _duracao;
    }

    public string ObterNome()
    {
        return _nome;
    }

    public void ExibirMensagemInicial()
    {
        Console.Clear();
        Console.WriteLine($"Seja bem-vindo(a) à {_nome}!\n");
        Console.WriteLine(_descricao);
        Console.WriteLine();
        Console.Write("Por quantos segundos deseja realizar esta sessão? ");

        if (!int.TryParse(Console.ReadLine(), out _duracao) || _duracao <= 0)
        {
            _duracao = 10;
        }

        Console.Clear();
        Console.Write("Iniciando a atividade... ");
        ExibirAnimacao(3);
        Console.WriteLine("\n");
    }

    public void ExibirMensagemFinal()
    {
        Console.WriteLine("\nExcelente trabalho!");
        ExibirAnimacao(3);
        Console.WriteLine($"\nVocê finalizou a {_nome} com duração total de {_duracao} segundos.");
        ExibirAnimacao(3);
        Console.WriteLine();
    }

    public void ExibirAnimacao(int segundos)
    {
        string[] quadros = { "/", "-", "\\", "|" };
        DateTime limite = DateTime.Now.AddSeconds(segundos);
        int indice = 0;

        while (DateTime.Now < limite)
        {
            Console.Write(quadros[indice]);
            Thread.Sleep(250);
            Console.Write("\b \b");

            indice = (indice + 1) % quadros.Length;
        }
    }

    public void ExibirContagemRegressiva(int segundos)
    {
        for (int contagem = segundos; contagem > 0; contagem--)
        {
            Console.Write(contagem);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
