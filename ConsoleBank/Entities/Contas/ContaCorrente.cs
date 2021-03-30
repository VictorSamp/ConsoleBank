using System;

namespace ConsoleBank.Entities.Contas
{
    class ContaCorrente : Conta
    {
        public ContaCorrente(long numeroConta, string nomeCliente, decimal saldo, decimal credito, DateTime dataCriacao)
            : base(numeroConta, nomeCliente, saldo, credito, dataCriacao)
        {

        }
    }
}
