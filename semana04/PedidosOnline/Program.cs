using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Garante formatação monetária com ponto decimal (padrão USD)
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("==================================================");
        Console.WriteLine("        SISTEMA DE PROCESSAMENTO DE PEDIDOS       ");
        Console.WriteLine("==================================================");
        Console.WriteLine();

        // -------------------------------------------------------------
        // Pedido 1: Cliente nos Estados Unidos (Taxa de envio: $5.00)
        // -------------------------------------------------------------
        Endereco endereco1 = new Endereco("742 Evergreen Terrace", "Springfield", "OR", "USA");
        Cliente cliente1 = new Cliente("Lucas Miller", endereco1);
        Pedido pedido1 = new Pedido(cliente1);

        pedido1.AdicionarItem(new Produto("Fone de Ouvido Bluetooth Pro", "AUD-501", 45.00m, 2));
        pedido1.AdicionarItem(new Produto("Carregador Rápido USB-C 65W", "PWR-208", 18.50m, 1));
        pedido1.AdicionarItem(new Produto("Suporte Articulado para Monitor", "MNT-104", 32.00m, 1));

        ExibirPedido(1, pedido1);

        Console.WriteLine();
        Console.WriteLine(new string('-', 50));
        Console.WriteLine();

        // -------------------------------------------------------------
        // Pedido 2: Cliente fora dos Estados Unidos (Taxa de envio: $35.00)
        // -------------------------------------------------------------
        Endereco endereco2 = new Endereco("Rua das Flores, 450, Apto 302", "Curitiba", "PR", "Brasil");
        Cliente cliente2 = new Cliente("Carolina Mendes", endereco2);
        Pedido pedido2 = new Pedido(cliente2);

        pedido2.AdicionarItem(new Produto("Teclado Mecânico Compacto RGB", "KEY-801", 69.90m, 1));
        pedido2.AdicionarItem(new Produto("Mousepad Gamer Extra Grande", "PAD-305", 19.50m, 2));
        pedido2.AdicionarItem(new Produto("Mouse Sem Fio Ergonômico", "MOU-112", 28.00m, 1));

        ExibirPedido(2, pedido2);

        Console.WriteLine();
        Console.WriteLine("==================================================");
        Console.WriteLine("             PROCESSAMENTO CONCLUÍDO              ");
        Console.WriteLine("==================================================");
    }

    static void ExibirPedido(int numero, Pedido pedido)
    {
        Console.WriteLine($"PEDIDO #{numero}");
        Console.WriteLine();

        // 1. Etiqueta de Embalagem (Nome e ID de cada produto)
        Console.WriteLine(pedido.GerarEtiquetaEmbalagem());
        Console.WriteLine();

        // 2. Etiqueta de Envio (Nome e Endereço do cliente)
        Console.WriteLine(pedido.GerarEtiquetaEnvio());
        Console.WriteLine();

        // 3. Preço Total do Pedido (Produtos + Taxa de Envio)
        Console.WriteLine("--- RESUMO FINANCEIRO ---");
        Console.WriteLine($"Subtotal dos Itens: ${pedido.CalcularSubtotal():0.00}");
        Console.WriteLine($"Custo de Envio:     ${pedido.ObterTaxaEnvio():0.00} {(pedido.ObterCliente().MoraNosEua() ? "(EUA: $5.00)" : "(Internacional: $35.00)")}");
        Console.WriteLine($"CUSTO TOTAL:        ${pedido.CalcularCustoTotal():0.00}");
    }
}