using System;

namespace Atividade_5._2_poo
{
    internal class GerarForma
    {
        public void SolicitarForma()
        {
            Console.WriteLine("Qual forma você quer calcular?");
            Console.WriteLine("Digite 1 para quadrado, 2 para triangulo ou 3 para circunferência");
            int tipo = int.Parse(Console.ReadLine());

            if (tipo == 1)
            {
                Console.Write("Digite o valor do lado do quadrado:");
                double lado = double.Parse(Console.ReadLine());
                Quadrado quadrado = new Quadrado(lado);
                quadrado.CalcularPerimetro();
                quadrado.CalcularArea();
                Console.WriteLine("Área do quadrado: " + quadrado.area);
                Console.WriteLine("Perímetro do quadrado: " + quadrado.perimetro);
            }
            else if (tipo == 2)
            {
                Console.Write("Digite o valor do lado do triângulo:");
                double lado = double.Parse(Console.ReadLine());
                Triangulo triangulo = new Triangulo(lado);
                triangulo.CalcularPerimetro();
                triangulo.CalcularArea();
                Console.WriteLine("Área do triângulo: " + triangulo.area);
                Console.WriteLine("Perímetro do triângulo: " + triangulo.perimetro);
            }
            else if (tipo == 3)
            {
                Console.Write("Digite o valor do raio da circunferência:");
                double raio = double.Parse(Console.ReadLine());
                Circunferencia circunferencia = new Circunferencia(raio);
                circunferencia.CalcularCircunferencia();
                Console.WriteLine("Circunferência: " + circunferencia.circunferencia);
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }
        }
    }