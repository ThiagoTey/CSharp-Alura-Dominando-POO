using OpenAI.Chat;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new(nomeDaBanda);
        bandasRegistradas.Add(banda.Nome, banda);

        string APIKEY = "";

        ChatClient client = new(model: "gpt-4o-mini", apiKey: APIKEY);

        ChatCompletion completion = client.CompleteChat($"Faca um resumo curto e informal da banda {nomeDaBanda}");
        banda.Resumo = completion.Content[0].Text;

        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Console.WriteLine("Digite uma tecla para votar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
