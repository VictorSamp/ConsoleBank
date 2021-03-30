using ConsoleBank.Entities.Contas;
using ConsoleBank.Entities.Pessoas;
using System;
using System.Collections.Generic;

namespace ConsoleBank
{
    class Program
    {
        static List<Conta> listaContas = new List<Conta>();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Bem Vindo ao ConsoleBank!");
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine();
            Console.WriteLine("1 - Listar contas");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            string opcaoEscolhida = Console.ReadLine().ToUpper();
            return opcaoEscolhida;
        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar contas");

            if (listaContas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }

            for (int i = 0; i < listaContas.Count; i++)
            {
                Conta conta = listaContas[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(conta);
            }
        }

        private static void InserirConta()
        {
            Console.WriteLine("Inserir Nova Conta");
            Console.WriteLine();

            Console.WriteLine("Informe os dados do cliente:");
            Console.WriteLine();
            Console.Write("Pessoa física ou jurídica: (1 - Física, 2 - Jurídica)");
            int tipoPessoa = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            string dadoTipoPessoa;
            Pessoa cliente;

            switch (tipoPessoa)
            {
                case 1:
                    Console.Write("Digite o CPF do cliente: ");
                    dadoTipoPessoa = Console.ReadLine();
                    cliente = new PessoaFisica();
                    break;
                case 2:
                    Console.Write("Digite o CNPJ do cliente: ");
                    dadoTipoPessoa = Console.ReadLine();
                    cliente = new PessoaJuridica();
                    break;
            }





        }


    }
}
