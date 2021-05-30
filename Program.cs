using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ColeccionesBYteArray
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray ArregloBits = new BitArray(new byte[] { 1, 2, 4, 8, 16});

            Console.WriteLine(ArregloBits.Count);
            Console.WriteLine(ArregloBits.Length);
            MostrarArreglo(ArregloBits, "Hola");

            Console.WriteLine("----------");

            Console.ReadKey();
        }
        public static void MostrarArreglo(BitArray ArregloBytes, string Nombre)
        {
            int Contador = 0;
            Console.WriteLine("{0}\t",Nombre);
            foreach (bool  item in ArregloBytes)
            {
                Contador++;
                if (item)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine("0");
                }
                if (Contador % 8 == 0)
                {
                    Console.WriteLine(",");
                }
                Console.WriteLine();
            }
        }
    }
}
