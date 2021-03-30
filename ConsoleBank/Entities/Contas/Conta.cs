using ConsoleBank.Entities.Pessoas;
using System;
using System.Text;

namespace ConsoleBank.Entities.Contas
{
    public abstract class Conta
    {
        private long NumeroConta { get; set; }
        private Pessoa Cliente { get; set; }
        private decimal Saldo { get; set; }
        protected decimal Credito { get; set; }

        public Conta(Pessoa cliente)
        {
            NumeroConta = new Random().Next();
            Cliente = cliente;
            Saldo = 0m;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Numero da conta: {NumeroConta}");
            sb.AppendLine($"Nome do Cliente: {Cliente.GetNome()}");
            sb.AppendLine($"Saldo: {Saldo:0.00}");
            sb.AppendLine($"Crédito: {Credito:0.00}");
            return sb.ToString();
        }
    }
}
