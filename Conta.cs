public class Conta
{
    public int Codigo { get; }
    public double Saldo { get; private set; }


    public Conta(int codigo)
    {
        Codigo = codigo;
        Saldo = 0.0;
    }

    public void Sacar(double valor)
    {
        Excecao(valor);
        VerificarSaldo(valor);
        Saldo -= valor;
    }

    public void Depositar(double valor)
    {
        Excecao(valor);
        Saldo += valor;
    }

    private void Excecao(double valor) 
    {
      if(valor < 0 || valor == 0)
            throw new ArgumentException("Valor inválido");  
    }

    private void VerificarSaldo(double valor)
    {
        if (valor > Saldo)
            throw new ArgumentException("Valor inválido para retirar do saldo");
    }

    public void Transferir(Conta conta, double valor)
    {
        Sacar(valor);
        conta.Depositar(valor);
    }
}