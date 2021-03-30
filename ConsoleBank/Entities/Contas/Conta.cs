﻿using System;

namespace ConsoleBank.Entities.Contas
{
    public abstract class Conta
    {
        private long _numeroConta { get; }
        private string _nomeCliente { get; set; }
        private decimal _saldo { get; set; }
        private decimal _credito { get; set; }
        private DateTime _dataCriacao { get; }

        public Conta(long numeroConta, string nomeCliente, decimal saldo, decimal credito)
        {
            _numeroConta = new Random().Next(0, 12000);
            _nomeCliente = nomeCliente;
            _saldo = saldo;
            _credito = credito;
            _dataCriacao = DateTime.Now;
        }

        public bool Sacar(decimal valor)
        {
            if (valor > _saldo + _credito)
            {
                Console.WriteLine("Saldo Insuficiente!");
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(decimal valor)
        {
            _saldo += valor;
        }
    }
}
