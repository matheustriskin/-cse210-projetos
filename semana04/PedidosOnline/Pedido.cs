using System;
using System.Collections.Generic;
using System.Text;

public class Pedido
{
    private List<Produto> _itensPedido;
    private Cliente _clienteDestinatario;

    public Pedido(Cliente clienteDestinatario)
    {
        _clienteDestinatario = clienteDestinatario;
        _itensPedido = new List<Produto>();
    }

    public void AdicionarItem(Produto produto)
    {
        _itensPedido.Add(produto);
    }

    public decimal ObterTaxaEnvio()
    {
        return _clienteDestinatario.MoraNosEua() ? 5.00m : 35.00m;
    }

    public decimal CalcularSubtotal()
    {
        decimal subtotal = 0m;
        foreach (Produto item in _itensPedido)
        {
            subtotal += item.ObterCustoTotal();
        }
        return subtotal;
    }

    public decimal CalcularCustoTotal()
    {
        return CalcularSubtotal() + ObterTaxaEnvio();
    }

    public string GerarEtiquetaEmbalagem()
    {
        StringBuilder etiqueta = new StringBuilder();
        etiqueta.AppendLine("--- ETIQUETA DE EMBALAGEM ---");
        foreach (Produto item in _itensPedido)
        {
            etiqueta.AppendLine($"Item: {item.ObterNome()} | Código/ID: {item.ObterId()}");
        }
        return etiqueta.ToString().TrimEnd();
    }

    public string GerarEtiquetaEnvio()
    {
        StringBuilder etiqueta = new StringBuilder();
        etiqueta.AppendLine("--- ETIQUETA DE ENVIO ---");
        etiqueta.AppendLine($"Destinatário: {_clienteDestinatario.ObterNome()}");
        etiqueta.AppendLine("Endereço:");
        etiqueta.AppendLine(_clienteDestinatario.ObterEndereco().ObterEnderecoFormatado());
        return etiqueta.ToString().TrimEnd();
    }

    public Cliente ObterCliente()
    {
        return _clienteDestinatario;
    }

    public List<Produto> ObterItens()
    {
        return _itensPedido;
    }
}
