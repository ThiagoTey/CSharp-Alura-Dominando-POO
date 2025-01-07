using Automobilistica.Modelos;

class Program
{
    static void Main()
    {
        Veiculo carro = new("Ferrari","Aquela la",2017);
        Mecanico jorge = new("jorge", "carros");
        Cliente cliente = new("Rodolfo", "19284019");
        Oficina oficina = new();
        Servico servicoClietne = new("Troca oleo", jorge, cliente, carro, oficina);
        oficina.ConcluirServico(carro);
    }
}