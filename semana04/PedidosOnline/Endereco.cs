using System;

public class Endereco
{
    private string _logradouro;
    private string _cidade;
    private string _estado;
    private string _pais;

    public Endereco(string logradouro, string cidade, string estado, string pais)
    {
        _logradouro = logradouro;
        _cidade = cidade;
        _estado = estado;
        _pais = pais;
    }

    public bool EstaNosEua()
    {
        string paisNormalizado = _pais.Trim().ToUpper();
        return paisNormalizado == "USA" ||
               paisNormalizado == "EUA" ||
               paisNormalizado == "ESTADOS UNIDOS" ||
               paisNormalizado == "UNITED STATES";
    }

    public string ObterEnderecoFormatado()
    {
        return $"{_logradouro}\n{_cidade}, {_estado}\n{_pais}";
    }

    public string ObterLogradouro()
    {
        return _logradouro;
    }

    public string ObterCidade()
    {
        return _cidade;
    }

    public string ObterEstado()
    {
        return _estado;
    }

    public string ObterPais()
    {
        return _pais;
    }
}
