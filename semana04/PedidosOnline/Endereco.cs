using System;

public class Endereco
{
    private string _rua;
    private string _cidade;
    private string _estado;
    private string _pais;

    public Endereco(string rua, string cidade, string estado, string pais)
    {
        _rua = rua;
        _cidade = cidade;
        _estado = estado;
        _pais = pais;
    }

    public bool EstaNosEua()
    {
        string paisNormalizado = _pais.Trim().ToUpper();
        return paisNormalizado == "EUA" ||
               paisNormalizado == "USA" ||
               paisNormalizado == "ESTADOS UNIDOS" ||
               paisNormalizado == "UNITED STATES";
    }

    public string ObterEnderecoCompleto()
    {
        return $"{_rua}\n{_cidade}, {_estado}\n{_pais}";
    }

    public string ObterRua()
    {
        return _rua;
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
