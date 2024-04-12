using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_5._2_poo
{
    internal class Circunferencia:Forma
    {
        public override void CalcularArea()
        {
            area = 3,14 * raio ^2;
        }

        public override void CalcularPerimetro()
        {         
        }
    }
}
