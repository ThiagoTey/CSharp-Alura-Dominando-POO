namespace Loja.Modelos;

internal class Servico : IPagavel
{
    public string DescServico { get; set; }
    public double ValorHora { get; set; }
    public int TotalHoras{ get; set; }
    public double CalcularPagamento()
    {
        return ValorHora * TotalHoras;
    }
}
