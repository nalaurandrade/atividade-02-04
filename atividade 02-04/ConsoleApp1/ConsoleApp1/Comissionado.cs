using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Comissionado : Empregado
    {
        public double TotalVenda { get; set; }
        public double Comissao { get; set; }

        public override double Vencimento()
        {
            return TotalVenda * (Comissao / 100);
        }
    }
}
