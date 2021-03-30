using System;

namespace ConsoleBank.Entities.Contas
{
    class ContaPoupanca : Conta
    {
        public ContaPoupanca(long numeroConta, string nomeCliente, decimal saldo, decimal credito)
            : base(numeroConta, nomeCliente, saldo, credito)
        {

        }
    }
}
