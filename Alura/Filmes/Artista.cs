namespace Alura.Filmes;
class Artista
{
    public Artista(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
        Filmes = new List<Filme>();
    }

    public string Nome { get; }
    public int Idade { get; }
    public List<Filme> Filmes { get; set; }

    public void AdicionarFilme(Filme filme)
    {
        Filmes.Add(filme);
        if (!filme.Elenco.Contains(this)) { filme.AdicionarElenco(this); }
    }

}