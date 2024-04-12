using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Empregado empregado = menu.CriarEmpregado();
            Console.WriteLine($"O salário do(a) {empregado.Nome} {empregado.Sobrenome} é: {empregado.Vencimento()}");
        }
    }
}
