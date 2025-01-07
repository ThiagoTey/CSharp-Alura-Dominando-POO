using PetShop.Modulos;

namespace PetShop.Modelos;

internal class Veterinario
{
    public string Nome { get; set; }
    public List<Consulta> Consultas { get; }

    public void AdicionarColsulta(Consulta consulta)
    {
        Consultas.Add(consulta);
    }
}