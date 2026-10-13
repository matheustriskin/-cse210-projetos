using System;

public class Corrida : Atividade
{
    private double _distancia;

    public Corrida(string data, int minutos, double distancia) : base(data, minutos)
    {
        _distancia = distancia;
    }

    public override string ObterNome()
    {
        return "Corrida";
    }

    public override double ObterDistancia()
    {
        return _distancia;
    }

    public override double ObterVelocidade()
    {
        return (_distancia / ObterMinutos()) * 60;
    }

    public override double ObterRitmo()
    {
        return ObterMinutos() / _distancia;
    }
}
