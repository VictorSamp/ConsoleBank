using ConsoleBank.Entities.Contas;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleBank
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();

        static void Main(string[] args)
        {
            string opcaoEscolhida = GerarMenuPrincipal();

            while (opcaoEscolhida.ToUpper() != "X")
            {
                switch (opcaoEscolhida)
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

                opcaoEscolhida = GerarMenuPrincipal();
            }
        }

        static string GerarMenuPrincipal()
        {
            Console.WriteLine("Bem vindo ao ConsoleBank!");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine();
            Console.WriteLine("1- Listar contas");
            Console.WriteLine("2- Inserir nova conta");
            Console.WriteLine("3- Transferir");
            Console.WriteLine("4- Sacar");
            Console.WriteLine("5- Depositar");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();
            string opcaoEscolhida = Console.ReadLine();
            return opcaoEscolhida;
        }

        static void ListarContas()
        {
            if (listContas.Count == 0)
            {
                Console.WriteLine("A lista de contas está vazia!");
            }

            foreach (IEnumerable item in listContas)
            {
                Console.WriteLine(item);
            }
        }

    }
}
