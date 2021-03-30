using System;

namespace ConsoleBank.Entities.Contas
{
    public abstract class Conta
    {
        private long NumeroConta { get; set; }
        private string NomeCliente { get; set; }
        private decimal Saldo { get; set; }
        private decimal Credito { get; set; }
        private DateTime DataCriacao { get; set; }

        protected Conta(long numeroConta, string nomeCliente, decimal saldo, decimal credito, DateTime dataCriacao)
        {
            NumeroConta = numeroConta;
            NomeCliente = nomeCliente;
            Saldo = saldo;
            Credito = credito;
            DataCriacao = dataCriacao;
        }
    }
}
