﻿namespace FormasGeometricas.FormasGeomitricas;


internal class Triangulo : FormaGeometrica
{
    public Triangulo(double @base, double altura)
    {
        Base = @base;
        Altura = altura;
    }

    public double Base { get; set; }
    public double Altura { get; set; }


    public override double CalcularArea()
    {
        return Base * Altura / 2;
    }

    public override double CalcularPerimetro()
    {
        return Base + Altura + Math.Sqrt(Base * Base + Altura * Altura);
    }
}
