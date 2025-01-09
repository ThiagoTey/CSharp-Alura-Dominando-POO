namespace FormasGeometricas.FormasGeomitricas;

internal class Quadrado : FormaGeometrica
{
    public Quadrado(double lado)
    {
        Lado = lado;
    }

    public double Lado { get; set; }
    public override double CalcularArea()
    {
        return Lado * Lado;
    }

    public override double CalcularPerimetro()
    {
        return Lado * 4;
    }
}
