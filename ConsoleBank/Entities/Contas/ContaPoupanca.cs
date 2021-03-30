using ConsoleBank.Entities.Pessoas;

namespace ConsoleBank.Entities.Contas
{
    class ContaPoupanca : Conta
    {
        public ContaPoupanca(Pessoa cliente)
            : base(cliente)
        {
            Credito = 100m;
        }
    }
}
