using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Garante formatação consistente com ponto para moeda (USD)
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("=================================================");
        Console.WriteLine("     SISTEMA DE GESTÃO DE PEDIDOS ONLINE        ");
        Console.WriteLine("=================================================");
        Console.WriteLine();

        // -------------------------------------------------------------
        // Pedido 1: Cliente localizado nos EUA (Custo de envio: $5.00)
        // -------------------------------------------------------------
        Endereco endereco1 = new Endereco("1725 Slough Ave, Suite 100", "Scranton", "PA", "USA");
        Cliente cliente1 = new Cliente("Michael Scott", endereco1);
        Pedido pedido1 = new Pedido(cliente1);

        pedido1.AdicionarProduto(new Produto("Caneca World's Best Boss", "DNDR-001", 14.99m, 2));
        pedido1.AdicionarProduto(new Produto("Caixa de Papel Carta Dunder Mifflin", "DNDR-042", 8.50m, 4));
        pedido1.AdicionarProduto(new Produto("Grampeador de Mesa Premium", "DNDR-777", 12.00m, 1));

        ExibirDetalhesPedido(1, pedido1);

        Console.WriteLine();
        Console.WriteLine(new string('-', 55));
        Console.WriteLine();

        // -------------------------------------------------------------
        // Pedido 2: Cliente localizado fora dos EUA (Custo de envio: $35.00)
        // -------------------------------------------------------------
        Endereco endereco2 = new Endereco("Av. Paulista, 1578 - Bela Vista", "São Paulo", "SP", "Brasil");
        Cliente cliente2 = new Cliente("Ana Beatriz Ramos", endereco2);
        Pedido pedido2 = new Pedido(cliente2);

        pedido2.AdicionarProduto(new Produto("Teclado Mecânico Gamer RGB", "TECH-101", 65.00m, 1));
        pedido2.AdicionarProduto(new Produto("Mouse Ergonômico Sem Fio", "TECH-204", 28.50m, 2));
        pedido2.AdicionarProduto(new Produto("Mousepad Extra Grande Speed", "TECH-310", 19.90m, 1));

        ExibirDetalhesPedido(2, pedido2);

        Console.WriteLine();
        Console.WriteLine("=================================================");
        Console.WriteLine("           FIM DO PROCESSAMENTO                 ");
        Console.WriteLine("=================================================");
    }

    static void ExibirDetalhesPedido(int numeroPedido, Pedido pedido)
    {
        Console.WriteLine($"PEDIDO #{numeroPedido}");
        Console.WriteLine();

        // Etiqueta de Embalagem
        Console.WriteLine(pedido.ObterEtiquetaEmbalagem());
        Console.WriteLine();

        // Etiqueta de Envio
        Console.WriteLine(pedido.ObterEtiquetaEnvio());
        Console.WriteLine();

        // Resumo Financeiro
        Console.WriteLine("=== RESUMO DE CUSTOS ===");
        Console.WriteLine($"Subtotal dos Produtos: ${pedido.ObterSubtotalProdutos():0.00}");
        Console.WriteLine($"Taxa de Envio:         ${pedido.ObterCustoEnvio():0.00} {(pedido.ObterCliente().MoraNosEua() ? "(Nacional - EUA)" : "(Internacional)")}");
        Console.WriteLine($"PREÇO TOTAL DO PEDIDO: ${pedido.CalcularCustoTotal():0.00}");
    }
}