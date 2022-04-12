Conta conta1 = new Conta(1);
Conta conta2 = new Conta(2);

conta1.Depositar(100);
conta1.Sacar(100);
Console.WriteLine(conta1.Saldo);

conta2.Depositar(200);
conta2.Sacar(150);
Console.WriteLine(conta2.Saldo);

conta2.Transferir(conta1, 50);
Console.WriteLine(conta1.Saldo);
Console.WriteLine(conta2.Saldo);



