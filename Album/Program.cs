internal class Album
{
    public Album(string nome)
    {
        nome = Nome;
        ContadorDeObjetos++;
    }

    public string Nome { get; set; }

    public static int ContadorDeObjetos = 0;

}

public class Program()
{
    static void Main()
    {
        Album a1 = new Album("Barões da Pisadinha Ao Vivo");
        Album a2 = new Album("Barões da Pisadinha feat.Anitta");
        Album a3 = new Album("Barões da Pisadinha no Free Jazz Festival");

        Console.WriteLine($"Total de objetos criados: { Album.ContadorDeObjetos}");
    }
}