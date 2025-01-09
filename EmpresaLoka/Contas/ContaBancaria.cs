namespace EmpresaLoka.Contas;

internal class ContaBancaria
{
    public double Saldo { get; set; }

    public virtual double CaucularSaldo()
    {
        return Saldo;
    }
}
