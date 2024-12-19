namespace Alura.Filmes;
class Filme
{
    public Filme(string titulo, int duracao, List<string>? elenco)
    {
        Titulo = titulo;
        Duracao = duracao;
        Elenco = elenco ?? new List<string>();
    }

    public string Titulo { get; }
    public int Duracao { get; }
    public List<string> Elenco { get; set; }

    public void AdicionarElenco(string ator)
    {
        Elenco.Add(ator);
        Console.WriteLine("Elenco adicionado");
    }

    public void ExibirElenco()
    {
        if (Elenco.Count <= 0)
        {
            Console.WriteLine("Não há elenco registrado para este filme.");
            return;
        }
        Console.Write("Elenco : ");
        foreach (string ator in Elenco) {
            Console.Write($" - {ator}");
        }
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Filme : {Titulo}");
        Console.WriteLine($"Duracao : {Duracao} Minutos");
        ExibirElenco();
        Console.WriteLine("\n");
    }
}