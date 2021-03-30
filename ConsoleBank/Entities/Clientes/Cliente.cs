using System.Text;

namespace ConsoleBank.Entities.Clientes
{
    public class Cliente
    {
        private string Nome { get; set; }
        private string Endereco { get; set; }
        private string Telefone { get; set; }

        public Cliente(string nome, string endereco, string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }

        public string GetNomeCliente()
        {
            return this.Nome;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome do titular: {this.Nome}");
            sb.AppendLine($"Endereço: {this.Endereco}");
            sb.AppendLine($"Telefone: {this.Telefone}");
            return sb.ToString();
        }
    }
}
