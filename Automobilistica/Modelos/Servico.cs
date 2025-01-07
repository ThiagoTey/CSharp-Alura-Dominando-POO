namespace Automobilistica.Modelos;

internal class Servico
{
    public Servico(string descricao, Mecanico mecanico, Cliente cliente, Veiculo veiculo, Oficina oficina)
    {
        Descricao = descricao;
        Mecanico = mecanico;
        Cliente = cliente;
        Veiculo = veiculo;
        oficina.AdicionarServico(this);
    }
    public string Descricao { get; set; }
    public Mecanico Mecanico { get; set; }
    public Cliente Cliente { get; set; }
    public Veiculo Veiculo { get; set; }
    public bool Conscluido { get; set; }
}
