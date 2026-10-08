using System;

public class Produto
{
    private string _nome;
    private string _id;
    private decimal _precoUnitario;
    private int _quantidade;

    public Produto(string nome, string id, decimal precoUnitario, int quantidade)
    {
        _nome = nome;
        _id = id;
        _precoUnitario = precoUnitario;
        _quantidade = quantidade;
    }

    public decimal ObterCustoTotal()
    {
        return _precoUnitario * _quantidade;
    }

    public string ObterNome()
    {
        return _nome;
    }

    public string ObterId()
    {
        return _id;
    }

    public decimal ObterPrecoUnitario()
    {
        return _precoUnitario;
    }

    public int ObterQuantidade()
    {
        return _quantidade;
    }
}
