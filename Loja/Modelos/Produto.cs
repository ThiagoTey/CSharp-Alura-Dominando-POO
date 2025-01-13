namespace Loja.Modelos;

internal class Produto : IPagavel
{
    public string Descricao { get; set; }
    public double Valor { get; set; }
    public int Quantidade { get; set; }

    public double CalcularPagamento()
    {
        return Valor * Quantidade;
    }
}
