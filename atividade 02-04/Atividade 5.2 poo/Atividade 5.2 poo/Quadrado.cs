using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_5._2_poo
{
    internal class Quadrado:Forma
    {
        public double lado;
        public override void CalcularArea()
        {
            area = lado*lado;
        }
        public override void CalcularPerimetro()
        {
            perimetro = lado * 4;
        }

    }
}
