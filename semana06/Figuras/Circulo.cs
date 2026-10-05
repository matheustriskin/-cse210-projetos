using System;

public class Circulo : Figura
{
    private double _raio;

    public Circulo(string cor, double raio) : base(cor)
    {
        _raio = raio;
    }

    public override double ObterArea()
    {
        return _raio * _raio * Math.PI;
    }
}
