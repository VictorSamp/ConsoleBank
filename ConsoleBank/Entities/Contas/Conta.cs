using ConsoleBank.Entities.Clientes;
using ConsoleBank.Entities.Contas.Enums;
using System;
using System.Globalization;
using System.Text;

namespace ConsoleBank.Entities.Contas
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private Cliente Cliente { get; set; }

        public Conta(TipoConta tipoConta, double saldo, double credito, Cliente cliente)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Cliente = cliente;
        }

        public bool Sacar(double valorSaque)
        {
            if (this.Saldo - valorSaque < (this.Credito * -1))
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }
            this.Saldo -= valorSaque;

            Console.WriteLine($"Saldo atual da conta de {Cliente.GetNomeCliente()} é {this.Saldo}");

            return true;
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;

            Console.WriteLine($"Saldo atual da conta de {Cliente.GetNomeCliente()} é {this.Saldo}");
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"TipoConta: {this.TipoConta}");
            sb.AppendLine($"Nome: {Cliente.GetNomeCliente()}");
            sb.AppendLine($"Saldo: R$ {this.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
            sb.AppendLine($"Crédito: R$ {this.Credito.ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
