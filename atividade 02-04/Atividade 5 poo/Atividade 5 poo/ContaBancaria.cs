using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_5_poo
{
    internal class ContaBancaria
    {
        public double Saldo=1000;
        public string numeroConta;
        public string titular;

        public void Depositar(double valor)
        {
            Saldo = Saldo + valor;  
        }

        public void ObterSaldo()
        {
            Console.Write($"Saldo={Saldo}");
        }
    }
}
