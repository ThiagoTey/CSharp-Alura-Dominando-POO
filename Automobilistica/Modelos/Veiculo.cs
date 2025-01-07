namespace Automobilistica.Modelos;

internal class Veiculo
{
    public Veiculo(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }

    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
}