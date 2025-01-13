namespace Loja.Modelos;

internal interface INotificavel
{
    void EnviarNotificacao(string mensagem, string destinatario);
}
