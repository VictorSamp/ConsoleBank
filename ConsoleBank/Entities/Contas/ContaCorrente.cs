using ConsoleBank.Entities.Pessoas;

namespace ConsoleBank.Entities.Contas
{
    class ContaCorrente : Conta
    {
        public ContaCorrente(Pessoa cliente)
            : base(cliente)
        {
            Credito = 500m;
        }
    }
}
