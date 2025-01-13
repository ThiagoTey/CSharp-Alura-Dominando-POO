namespace Loja.Modelos;

internal class SMS : INotificavel
{
    public void EnviarNotificacao(string mensagem, string destinatario)
    {
        Console.WriteLine($"Mensagem {mensagem} para {destinatario} Enviada");
    }
}
