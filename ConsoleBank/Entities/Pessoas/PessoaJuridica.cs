namespace ConsoleBank.Entities.Pessoas
{
    class PessoaJuridica : Pessoa
    {
        private string Cnpj { get; set; }

        public PessoaJuridica()
        {

        }

        public PessoaJuridica(string nome, string endereco, string telefone, string cnpj)
            : base(nome, endereco, telefone)
        {
            Cnpj = cnpj;
        }
    }
}
