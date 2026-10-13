using System;
using System.Collections.Generic;

public class AtividadeDeReflexao : Atividade
{
    private List<string> _temas;
    private List<string> _questionamentos;
    private Random _sorteador;

    public AtividadeDeReflexao() : base(
        "Atividade de Reflexão",
        "Esta atividade convida você a meditar sobre momentos da sua trajetória em que você demonstrou coragem e determinação, ajudando a reconhecer seus pontos fortes e potenciais.")
    {
        _sorteador = new Random();

        _temas = new List<string>()
        {
            "Pense em uma ocasião em que você precisou superar o medo para fazer o que era correto.",
            "Lembre-se de um momento difícil em que você perseverou e não desistiu.",
            "Recorde um episódio em que você ofereceu apoio a alguém que estava passando por dificuldades.",
            "Pense em uma conquista que exigiu esforço e dedicação genuínos de sua parte."
        };

        _questionamentos = new List<string>()
        {
            "O que tornou essa vivência tão marcante para você?",
            "Qual foi o seu maior desafio no início dessa situação?",
            "Como você se sentiu ao perceber o resultado da sua atitude?",
            "O que você descobriu a respeito da sua própria capacidade com essa experiência?",
            "Quais lições aprendidas nessa ocasião podem ajudar você nos desafios de hoje?",
            "Se passasse pela mesma situação novamente, o que manteria igual?",
            "De que forma essa memória pode servir de motivação para o seu futuro?",
            "Quem mais percebeu ou foi influenciado positivamente por essa sua postura?"
        };
    }

    public void Executar()
    {
        ExibirMensagemInicial();

        string temaEscolhido = ObterTemaAleatorio();
        Console.WriteLine("Pense a respeito do seguinte tema:");
        Console.WriteLine($"\n  --- \"{temaEscolhido}\" ---\n");
        Console.WriteLine("Assim que tiver refletido sobre uma situação específica, pressione [Enter] para prosseguir.");
        Console.ReadLine();

        Console.WriteLine("Agora, avalie com atenção as questões a seguir:");
        Console.Write("A atividade começará em: ");
        ExibirContagemRegressiva(5);
        Console.Clear();

        DateTime horarioTermino = DateTime.Now.AddSeconds(ObterDuracao());

        while (DateTime.Now < horarioTermino)
        {
            string questao = ObterQuestionamentoAleatorio();
            Console.Write($"\n> {questao} ");
            ExibirAnimacao(5);
            Console.WriteLine();
        }

        ExibirMensagemFinal();
    }

    private string ObterTemaAleatorio()
    {
        int indice = _sorteador.Next(_temas.Count);
        return _temas[indice];
    }

    private string ObterQuestionamentoAleatorio()
    {
        int indice = _sorteador.Next(_questionamentos.Count);
        return _questionamentos[indice];
    }
}
