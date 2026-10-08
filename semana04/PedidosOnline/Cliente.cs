using System;

public class Cliente
{
    private string _nomeCompleto;
    private Endereco _enderecoResidencial;

    public Cliente(string nomeCompleto, Endereco enderecoResidencial)
    {
        _nomeCompleto = nomeCompleto;
        _enderecoResidencial = enderecoResidencial;
    }

    public bool MoraNosEua()
    {
        return _enderecoResidencial.EstaNosEua();
    }

    public string ObterNome()
    {
        return _nomeCompleto;
    }

    public Endereco ObterEndereco()
    {
        return _enderecoResidencial;
    }
}
