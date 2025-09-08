using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            Quadrado quadradinho = new Quadrado();

            Console.WriteLine("Digite o valor da aresta do quadrado:");

            quadradinho.setLado(int.Parse(Console.ReadLine()));

            quadradinho.calcularArea();

            Console.WriteLine(quadradinho.getArea());

            
            
        }
    }
}

