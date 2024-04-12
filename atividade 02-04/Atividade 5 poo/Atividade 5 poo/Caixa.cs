using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_5_poo
{
    internal class Caixa
    {
        public void Criarmenu()
        {
            ContaBancaria _conta = new ContaBancaria();

            Console.Write("Digite o nome do titular");
            _conta.titular = Console.ReadLine();

            Console.Write("Digite o numero da contra");
            _conta.numeroConta = Console.ReadLine();

            Console.Write("Qual valor você deseja depositar?");
            double valordeposito =  double.Parse (Console.ReadLine());

            _conta.Depositar(valordeposito);
            _conta.ObterSaldo();
        }
    }
}
