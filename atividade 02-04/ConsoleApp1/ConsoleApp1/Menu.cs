using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Menu
    {
        public Empregado CriarEmpregado()
        {
            Console.WriteLine("Digite o nome do empregado:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o sobrenome do empregado:");
            string sobrenome = Console.ReadLine();

            Console.WriteLine("Digite o CPF do empregado:");
            string cpf = Console.ReadLine();

            Console.WriteLine("Digite o tipo de empregado (1 - Assalariado, 2 - Comissionado, 3 - Horista):");
            int tipo = Convert.ToInt32(Console.ReadLine());

            Empregado empregado = null;

            if (tipo == 1)
            {
                Console.WriteLine("Digite o salário:");
                double salario = Convert.ToDouble(Console.ReadLine());
                empregado = new Assalariado { Nome = nome, Sobrenome = sobrenome, CPF = cpf, Salario = salario };
            }
            else if (tipo == 2)
            {
                Console.WriteLine("Digite o total de vendas:");
                double totalVenda = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a comissão (%):");
                double comissao = Convert.ToDouble(Console.ReadLine());
                empregado = new Comissionado { Nome = nome, Sobrenome = sobrenome, CPF = cpf, TotalVenda = totalVenda, Comissao = comissao };
            }
            else if (tipo == 3)
            {
                Console.WriteLine("Digite o preço por hora:");
                double precoHora = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o total de horas trabalhadas:");
                double totalHoras = Convert.ToDouble(Console.ReadLine());
                empregado = new Horista { Nome = nome, Sobrenome = sobrenome, CPF = cpf, PrecoHora = precoHora, TotalHorasTrabalhadas = totalHoras };
            }
            else
            {
                throw new ArgumentException("Tipo de empregado inválido.");
            }

            return empregado;
        }
    }

}
