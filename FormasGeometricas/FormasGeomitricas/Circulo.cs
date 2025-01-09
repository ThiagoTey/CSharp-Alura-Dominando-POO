namespace FormasGeometricas.FormasGeomitricas;

internal class Circulo : FormaGeometrica
{
    public Circulo (double raio)
    {
        Raio = raio;
    }

    public double Raio { get; set; }

    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(Raio , 2);
    }

    public override double CalcularPerimetro()
    {
        return 2 * Math.PI * Raio;
    }
}
