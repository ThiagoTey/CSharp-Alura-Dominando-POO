namespace Loja.Modelos;

internal class Email : INotificavel
{
    public void EnviarNotificacao(string mensagem, string destinatario)
    {
        Console.WriteLine($"Mensagem {mensagem} para {destinatario} Enviada");   
    }
}
