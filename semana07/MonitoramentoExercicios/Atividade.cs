using System;
using System.Globalization;

public abstract class Atividade
{
    private string _data;
    private int _minutos;

    public Atividade(string data, int minutos)
    {
        _data = data;
        _minutos = minutos;
    }

    public string ObterData()
    {
        return _data;
    }

    public int ObterMinutos()
    {
        return _minutos;
    }

    public virtual string ObterNome()
    {
        return GetType().Name;
    }

    public abstract double ObterDistancia();

    public abstract double ObterVelocidade();

    public abstract double ObterRitmo();

    public string ObterResumo()
    {
        return string.Format(
            CultureInfo.InvariantCulture,
            "{0} {1} ({2} min): Distância {3:0.0} km, Velocidade: {4:0.0} km/h, Ritmo: {5:0.00} min por km",
            _data,
            ObterNome(),
            _minutos,
            ObterDistancia(),
            ObterVelocidade(),
            ObterRitmo()
        );
    }

    public string GetSummary()
    {
        return ObterResumo();
    }
}
