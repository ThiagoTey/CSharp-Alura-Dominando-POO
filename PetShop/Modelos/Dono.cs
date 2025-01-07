namespace PetShop.Modelos;

internal class Dono
{
    public Dono(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }
    public List<Pet> Pets { get; }

    public void AdicionarPet(Pet pet)
    {
        Pets.Add(pet);
    }
}