using System;
using System.Collections.Generic;

public class AtividadeDeListagem : Atividade
{
    private List<string> _topicos;
    private Random _gerador;

    public AtividadeDeListagem() : base(
        "Atividade de Listagem",
        "Esta atividade auxilia a direcionar a atenção para aspectos positivos e bênçãos do seu dia a dia, encorajando você a registrar o maior número de respostas possíveis.")
    {
        _gerador = new Random();

        _topicos = new List<string>()
        {
            "Quais são as pessoas pelas quais você sente maior gratidão em sua vida?",
            "Quais qualidades e habilidades você mais admira em sua própria personalidade?",
            "Quem você conseguiu ajudar ou confortar nos últimos dias?",
            "Quais momentos de paz e inspiração você vivenciou recentemente?",
            "Quais pessoas servem como exemplos positivos e inspiradores para você?"
        };
    }

    public void Executar()
    {
        ExibirMensagemInicial();

        string topicoEscolhido = ObterTopicoAleatorio();
        Console.WriteLine("Escreva quantas respostas conseguir para a seguinte pergunta:");
        Console.WriteLine($"\n  --- \"{topicoEscolhido}\" ---\n");
        Console.Write("Você poderá iniciar em: ");
        ExibirContagemRegressiva(5);
        Console.WriteLine("\n");

        List<string> respostas = new List<string>();
        DateTime momentoLimite = DateTime.Now.AddSeconds(ObterDuracao());

        while (DateTime.Now < momentoLimite)
        {
            Console.Write("- ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                respostas.Add(item);
            }
        }

        Console.WriteLine($"\nParabéns! Você conseguiu listar {respostas.Count} item(ns).");

        ExibirMensagemFinal();
    }

    private string ObterTopicoAleatorio()
    {
        int indice = _gerador.Next(_topicos.Count);
        return _topicos[indice];
    }
}
