using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Figura> figuras = new List<Figura>();

        Quadrado f1 = new Quadrado("Vermelho", 3);
        figuras.Add(f1);

        Retangulo f2 = new Retangulo("Azul", 4, 5);
        figuras.Add(f2);

        Circulo f3 = new Circulo("Verde", 6);
        figuras.Add(f3);

        foreach (Figura figura in figuras)
        {
            string cor = figura.ObterCor();
            double area = figura.ObterArea();

            Console.WriteLine($"A figura {cor} tem uma área de {area:F2}.");
        }
    }
}