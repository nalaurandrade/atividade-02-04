using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_5._2_poo
{
    public abstract class Forma
    {
        public double area;
        public double perimetro;

        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();


    }
}
