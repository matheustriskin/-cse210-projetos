using System;

public class Fracao
{
    private int _numerador;
    private int _denominador;

    // Construtor sem parâmetros que inicializa a fração como 1/1
    public Fracao()
    {
        _numerador = 1;
        _denominador = 1;
    }

    // Construtor com 1 parâmetro (numerador) que inicializa o denominador como 1
    public Fracao(int numeroInteiro)
    {
        _numerador = numeroInteiro;
        _denominador = 1;
    }

    // Construtor com 2 parâmetros (numerador e denominador)
    public Fracao(int numerador, int denominador)
    {
        _numerador = numerador;
        _denominador = denominador;
    }

    // Getter e Setter para o numerador
    public int ObterNumerador()
    {
        return _numerador;
    }

    public void DefinirNumerador(int numerador)
    {
        _numerador = numerador;
    }

    // Getter e Setter para o denominador
    public int ObterDenominador()
    {
        return _denominador;
    }

    public void DefinirDenominador(int denominador)
    {
        _denominador = denominador;
    }

    // Retorna a representação em texto da fração (ex: "3/4")
    public string ObterFracaoEmTexto()
    {
        return $"{_numerador}/{_denominador}";
    }

    // Retorna a representação decimal da fração (ex: 0.75)
    public double ObterFracaoEmDecimal()
    {
        return (double)_numerador / (double)_denominador;
    }
}
