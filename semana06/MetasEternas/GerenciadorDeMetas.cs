using System;
using System.Collections.Generic;
using System.IO;

public class GerenciadorDeMetas
{
    private List<Meta> _metas;
    private int _pontos;

    public GerenciadorDeMetas()
    {
        _metas = new List<Meta>();
        _pontos = 0;
    }

    public void Iniciar()
    {
        string opcao = "";

        while (opcao != "6")
        {
            ExibirInfoJogador();

            Console.WriteLine("Opções de Menu:");
            Console.WriteLine("  1. Criar Nova Meta");
            Console.WriteLine("  2. Listar Metas");
            Console.WriteLine("  3. Salvar Metas");
            Console.WriteLine("  4. Carregar Metas");
            Console.WriteLine("  5. Registrar Evento");
            Console.WriteLine("  6. Sair");
            Console.Write("Selecione uma escolha do menu: ");
            opcao = Console.ReadLine();

            if (opcao == "1")
            {
                CriarMeta();
            }
            else if (opcao == "2")
            {
                ListarDetalhesDasMetas();
            }
            else if (opcao == "3")
            {
                SalvarMetas();
            }
            else if (opcao == "4")
            {
                CarregarMetas();
            }
            else if (opcao == "5")
            {
                RegistrarEvento();
            }
        }
    }

    public void ExibirInfoJogador()
    {
        Console.WriteLine($"\nVocê tem {_pontos} pontos.\n");
    }

    public void ListarNomesDasMetas()
    {
        for (int i = 0; i < _metas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_metas[i].ObterNome()}");
        }
    }

    public void ListarDetalhesDasMetas()
    {
        Console.WriteLine("\nAs metas são:");
        if (_metas.Count == 0)
        {
            Console.WriteLine("Nenhuma meta cadastrada ainda.");
            return;
        }

        for (int i = 0; i < _metas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_metas[i].ObterDetalhesEmTexto()}");
        }
    }

    public void CriarMeta()
    {
        Console.WriteLine("\nOs tipos de Metas são:");
        Console.WriteLine("  1. Meta Simples");
        Console.WriteLine("  2. Meta Eterna");
        Console.WriteLine("  3. Meta de Lista de Tarefas");
        Console.Write("Qual tipo de meta você gostaria de criar? ");
        string tipo = Console.ReadLine();

        Console.Write("Qual é o nome da sua meta? ");
        string nome = Console.ReadLine();

        Console.Write("Qual é uma breve descrição dela? ");
        string descricao = Console.ReadLine();

        Console.Write("Qual é a quantidade de pontos associados a essa meta? ");
        int pontos = int.Parse(Console.ReadLine());

        if (tipo == "1")
        {
            _metas.Add(new MetaSimples(nome, descricao, pontos));
        }
        else if (tipo == "2")
        {
            _metas.Add(new MetaEterna(nome, descricao, pontos));
        }
        else if (tipo == "3")
        {
            Console.Write("Quantas vezes essa meta precisa ser realizada para um bônus? ");
            int total = int.Parse(Console.ReadLine());

            Console.Write("Qual é o bônus por realizá-la tantas vezes? ");
            int bonus = int.Parse(Console.ReadLine());

            _metas.Add(new MetaDeListaDeTarefas(nome, descricao, pontos, total, bonus));
        }
    }

    public void RegistrarEvento()
    {
        if (_metas.Count == 0)
        {
            Console.WriteLine("\nNão há metas para registrar eventos.");
            return;
        }

        Console.WriteLine("\nAs metas são:");
        ListarNomesDasMetas();
        Console.Write("Qual meta você realizou? ");

        if (int.TryParse(Console.ReadLine(), out int escolha) && escolha >= 1 && escolha <= _metas.Count)
        {
            Meta metaSelecionada = _metas[escolha - 1];

            if (metaSelecionada.EstaConcluida())
            {
                Console.WriteLine("Essa meta já foi concluída anteriormente!");
                return;
            }

            metaSelecionada.RegistrarEvento();
            int pontosGanhos = metaSelecionada.ObterPontos();

            if (metaSelecionada is MetaDeListaDeTarefas checklist)
            {
                if (checklist.ObterConcluidas() == checklist.ObterTotal())
                {
                    pontosGanhos += checklist.ObterBonus();
                    Console.WriteLine($"Parabéns! Você alcançou o objetivo total e ganhou um bônus de {checklist.ObterBonus()} pontos!");
                }
            }

            _pontos += pontosGanhos;
            Console.WriteLine($"Parabéns! Você ganhou {pontosGanhos} pontos!");
            Console.WriteLine($"Agora você tem {_pontos} pontos.");
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }
    }

    public void SalvarMetas()
    {
        Console.Write("Qual é o nome do arquivo para o arquivo de meta? ");
        string nomeArquivo = Console.ReadLine();

        using (StreamWriter escritor = new StreamWriter(nomeArquivo))
        {
            escritor.WriteLine(_pontos);
            foreach (Meta meta in _metas)
            {
                escritor.WriteLine(meta.ObterRepresentacaoEmTexto());
            }
        }
        Console.WriteLine("Metas salvas com sucesso!");
    }

    public void CarregarMetas()
    {
        Console.Write("Qual é o nome do arquivo para o arquivo de meta? ");
        string nomeArquivo = Console.ReadLine();

        if (!File.Exists(nomeArquivo))
        {
            Console.WriteLine("Arquivo não encontrado.");
            return;
        }

        string[] linhas = File.ReadAllLines(nomeArquivo);
        if (linhas.Length > 0)
        {
            _pontos = int.Parse(linhas[0]);
            _metas.Clear();

            for (int i = 1; i < linhas.Length; i++)
            {
                string linha = linhas[i];
                if (string.IsNullOrWhiteSpace(linha)) continue;

                string[] partes = linha.Split(':');
                string tipo = partes[0];
                string[] dados = partes[1].Split(',');

                if (tipo == "MetaSimples")
                {
                    string nome = dados[0];
                    string descricao = dados[1];
                    int pontos = int.Parse(dados[2]);
                    bool estaConcluida = bool.Parse(dados[3]);

                    _metas.Add(new MetaSimples(nome, descricao, pontos, estaConcluida));
                }
                else if (tipo == "MetaEterna")
                {
                    string nome = dados[0];
                    string descricao = dados[1];
                    int pontos = int.Parse(dados[2]);

                    _metas.Add(new MetaEterna(nome, descricao, pontos));
                }
                else if (tipo == "MetaDeListaDeTarefas")
                {
                    string nome = dados[0];
                    string descricao = dados[1];
                    int pontos = int.Parse(dados[2]);
                    int bonus = int.Parse(dados[3]);
                    int total = int.Parse(dados[4]);
                    int concluidas = int.Parse(dados[5]);

                    _metas.Add(new MetaDeListaDeTarefas(nome, descricao, pontos, total, bonus, concluidas));
                }
            }
            Console.WriteLine("Metas carregadas com sucesso!");
        }
    }
}
