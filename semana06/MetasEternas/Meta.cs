using System;

public abstract class Meta
{
    private string _nome;
    private string _descricao;
    private int _pontos;

    public Meta(string nome, string descricao, int pontos)
    {
        _nome = nome;
        _descricao = descricao;
        _pontos = pontos;
    }

    public string ObterNome()
    {
        return _nome;
    }

    public string ObterDescricao()
    {
        return _descricao;
    }

    public int ObterPontos()
    {
        return _pontos;
    }

    public abstract void RegistrarEvento();

    public abstract bool EstaConcluida();

    public virtual string ObterDetalhesEmTexto()
    {
        string status = EstaConcluida() ? "[X]" : "[ ]";
        return $"{status} {_nome} ({_descricao})";
    }

    public abstract string ObterRepresentacaoEmTexto();
}
