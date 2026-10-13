using System;

public class AtividadeDeRespiracao : Atividade
{
    public AtividadeDeRespiracao() : base(
        "Atividade de Respiração",
        "Esta atividade tem como objetivo promover o relaxamento por meio de respirações compassadas. Busque esvaziar os pensamentos e acompanhar o ritmo indicado.")
    {
    }

    public void Executar()
    {
        ExibirMensagemInicial();

        int segundosInspirar = 4;
        int segundosExpirar = 6;
        DateTime momentoTermino = DateTime.Now.AddSeconds(ObterDuracao());

        while (DateTime.Now < momentoTermino)
        {
            Console.Write("Puxe o ar profundamente... ");
            ExibirContagemRegressiva(segundosInspirar);
            Console.WriteLine();

            Console.Write("Solte o ar lentamente... ");
            ExibirContagemRegressiva(segundosExpirar);
            Console.WriteLine("\n");
        }

        ExibirMensagemFinal();
    }
}
