using PetShop.Modulos;

namespace PetShop.Modelos;

internal class Pet
{
    public Pet(string nome, Dono dono, string raca, int idade)
    {
        Nome = nome;
        Dono = dono;
        dono.AdicionarPet(this);
        Raca = raca;
        Idade = idade;
    }

    public string Nome { get; set; }
    public Dono Dono { get; }
    public string Raca { get; set; }
    public int Idade { get; set; }
    public List<Consulta> Consultas { get; set; }

    public void AdicionarColsulta(Consulta consulta)
    {
        Consultas.Add(consulta);
    }
}