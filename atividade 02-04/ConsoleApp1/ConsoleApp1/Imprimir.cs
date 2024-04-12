using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Imprimir
    {
        public string SolicitarTexto()
        {
            Console.WriteLine("Digite o texto para impressão:");
            return Console.ReadLine();
        }

        public void EnviarParaImpressora(string texto)
        {
            Console.WriteLine("Enviando documento para impressão:");
            Console.WriteLine(texto);
        }
    }
}
