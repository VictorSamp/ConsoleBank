namespace ConsoleBank.Entities.Contas
{
    class ContaPoupanca : Conta
    {
        public ContaPoupanca(long numeroConta, string nomeCliente, decimal saldo, decimal credito)
            : base(nomeCliente, saldo)
        {
            _credito = 0m;
        }
    }
}
