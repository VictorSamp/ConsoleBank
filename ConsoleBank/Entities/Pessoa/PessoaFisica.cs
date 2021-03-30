namespace ConsoleBank.Entities.Pessoa
{
    class PessoaFisica : Pessoa
    {
        private string Cpf { get; set; }

        public PessoaFisica(string nome, string endereco, string telefone, string cpf)
            : base(nome, endereco, telefone)
        {
            Cpf = cpf;
        }
    }
}
