using ConsoleBank.Entities.Contas;
using System;
using System.Collections.Generic;

namespace ConsoleBank
{
    class Program
    {
        List<Conta> listaContas = new List<Conta>();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
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
    }
}
