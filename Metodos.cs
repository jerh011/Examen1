using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Metodos
    {
        public void Primer_interativo_1(int numero_1, int numero_2)
        {
            Console.WriteLine("=============================================================");

            Console.WriteLine("Asendente");
            for (int X = numero_1; X <= numero_2; X++)
                Console.WriteLine($"\"la secuencia de los números es {X}\"");


        }
        public void Primer_interativo_2(int numero_1, int numero_2)
        {
            Console.WriteLine("=============================================================");

            Console.WriteLine("Desendente");
            for (int X = numero_1; X >= numero_2; X--)
                Console.WriteLine($"\"la secuencia de los números es {X}\"");
        }

        public int Multiplicacion(int num_1, int num_2)
        {

            if (++num_2 >= 11)
                return 0;
            else
                Console.WriteLine($"{num_2}X{num_1}={num_1 * num_2}");

            return Multiplicacion(num_1, num_2);
        }

     //hola

    }
}
