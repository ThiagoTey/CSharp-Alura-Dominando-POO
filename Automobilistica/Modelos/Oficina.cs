namespace Automobilistica.Modelos;

internal class Oficina
{
    private List<Servico> servicos;

    public Oficina()
    {
        servicos = new List<Servico>();
    }

    public void AdicionarServico(Servico servico)
    {
        servicos.Add(servico);
    }

    public void ConcluirServico(Veiculo veiculo) {
        var servico = servicos.FirstOrDefault(s => s.Veiculo == veiculo);

        if (servico != null) {
            servico.Conscluido = true;
            Console.WriteLine("Servico concluido com sucesso");
        } else
        {
            Console.WriteLine("Servico nao encontrado");
        }
    }
}
