namespace Alura.Filmes;
class Filme
{
    public Filme(string titulo, int duracao, List<Artista>? elenco)
    {
        Titulo = titulo;
        Duracao = duracao;
        Elenco = elenco ?? new List<Artista>();
        if (elenco != null)
        {
            foreach (Artista artista in elenco)
            {
                artista.AdicionarFilme(this);
            }
        }
    }

    public string Titulo { get; }
    public int Duracao { get; }
    public List<Artista> Elenco { get; set; }

    public void AdicionarElenco(Artista artista)
    {
        Elenco.Add(artista);
        if (!artista.Filmes.Contains(this)) { artista.AdicionarFilme(this); }
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
        foreach (Artista ator in Elenco) {
            Console.Write($" - {ator.Nome}");
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