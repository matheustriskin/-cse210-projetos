using System;

class Program
{
    static void Main(string[] args)
    {
        bool executando = true;

        while (executando)
        {
            Console.Clear();
            Console.WriteLine("=== Programa de Introspecção ===");
            Console.WriteLine("Opções de Menu:");
            Console.WriteLine("  1. Iniciar Atividade de Respiração");
            Console.WriteLine("  2. Iniciar Atividade de Reflexão");
            Console.WriteLine("  3. Iniciar Atividade de Listagem");
            Console.WriteLine("  4. Sair");
            Console.Write("\nSelecione uma opção (1-4): ");

            string escolha = Console.ReadLine()?.Trim();

            switch (escolha)
            {
                case "1":
                    AtividadeDeRespiracao respiracao = new AtividadeDeRespiracao();
                    respiracao.Executar();
                    break;

                case "2":
                    AtividadeDeReflexao reflexao = new AtividadeDeReflexao();
                    reflexao.Executar();
                    break;

                case "3":
                    AtividadeDeListagem listagem = new AtividadeDeListagem();
                    listagem.Executar();
                    break;

                case "4":
                    executando = false;
                    Console.WriteLine("\nEncerrando o programa. Bom descanso!");
                    break;

                default:
                    Console.WriteLine("\nOpção inválida! Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
