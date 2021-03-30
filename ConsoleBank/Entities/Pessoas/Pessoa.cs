namespace ConsoleBank.Entities.Pessoas
{
    public abstract class Pessoa
    {
        private string Nome { get; set; }
        private string Endereco { get; set; }
        private string Telefone { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome, string endereco, string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }

        public string GetNome()
        {
            return Nome;
        }
    }
}
