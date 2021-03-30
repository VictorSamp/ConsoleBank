using System;

namespace ConsoleBank.Entities
{
    public class Conta
    {
        private long NumeroConta { get; set; }
        private string NomeCliente { get; set; }
        private decimal Saldo { get; set; } = 0;

        public Conta()
        {
        }

        public Conta(string nomeCliente, decimal saldo)
        {
            NumeroConta = new Random().Next();
            NomeCliente = nomeCliente;
            Saldo = saldo;
        }

        public bool Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }

            Saldo -= valor;
            return true;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

    }
}
