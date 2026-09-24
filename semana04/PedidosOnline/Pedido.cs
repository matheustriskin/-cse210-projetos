using System;
using System.Collections.Generic;
using System.Text;

public class Pedido
{
    private List<Produto> _produtos;
    private Cliente _cliente;

    public Pedido(Cliente cliente)
    {
        _cliente = cliente;
        _produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        _produtos.Add(produto);
    }

    public decimal ObterCustoEnvio()
    {
        return _cliente.MoraNosEua() ? 5.00m : 35.00m;
    }

    public decimal ObterSubtotalProdutos()
    {
        decimal subtotal = 0m;
        foreach (Produto produto in _produtos)
        {
            subtotal += produto.CalcularCustoTotal();
        }
        return subtotal;
    }

    public decimal CalcularCustoTotal()
    {
        return ObterSubtotalProdutos() + ObterCustoEnvio();
    }

    public string ObterEtiquetaEmbalagem()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("=== ETIQUETA DE EMBALAGEM ===");
        foreach (Produto produto in _produtos)
        {
            sb.AppendLine($"• Produto: {produto.ObterNome()} | ID: {produto.ObterIdProduto()} (Qtd: {produto.ObterQuantidade()})");
        }
        return sb.ToString().TrimEnd();
    }

    public string ObterEtiquetaEnvio()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("=== ETIQUETA DE ENVIO ===");
        sb.AppendLine($"Destinatário: {_cliente.ObterNome()}");
        sb.AppendLine("Endereço de Entrega:");
        sb.AppendLine(_cliente.ObterEndereco().ObterEnderecoCompleto());
        return sb.ToString().TrimEnd();
    }

    public List<Produto> ObterProdutos()
    {
        return _produtos;
    }

    public Cliente ObterCliente()
    {
        return _cliente;
    }
}
