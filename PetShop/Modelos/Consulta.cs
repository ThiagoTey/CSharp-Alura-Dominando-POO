using PetShop.Modelos;

namespace PetShop.Modulos;

internal class Consulta
{
    public Consulta(Veterinario veterinario, DateTime data, Pet pet, Dono dono)
    {
        Veterinario = veterinario;
        Data = data;
        Pet = pet;
        Dono = dono;
        Veterinario.AdicionarColsulta(this);
        Pet.AdicionarColsulta(this);
    }

    public Veterinario Veterinario { get; }
    public DateTime Data { get; set; }
    public Pet Pet { get; }
    public Dono Dono { get; set; }
}