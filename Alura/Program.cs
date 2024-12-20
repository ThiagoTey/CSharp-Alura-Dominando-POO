using Alura.Filmes;

Artista artista1 = new("Seu zé", 32);
Artista artista2 = new("Palerma", 32);
Artista artista3 = new("São bob", 32);
Artista artista4 = new("Gojo", 32);
Artista artista5 = new("Sabrina", 32);

Filme filme1 = new("Poderoso Chefão", 160, new List<Artista>(){} );
filme1.AdicionarElenco(artista1);
Filme filme2 = new("Um sonho de Liberdade", 120, new List<Artista>() { artista2 });
Filme filme3 = new("Um sonho de Liberdade", 120, new List<Artista>() { artista3 });
Filme filme4 = new("Um sonho de Liberdade", 120, new List<Artista>() { artista1 });
Filme filme5 = new("Um sonho de Liberdade", 120, new List<Artista>() { artista4 });

List<Filme> filmes = new() { filme1, filme2, filme3, filme4, filme5 };

foreach (Filme filme in filmes)
{
    filme.ExibirInformacoes();
}