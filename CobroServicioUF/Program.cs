using System;

namespace CobroServicioUF
{
    internal class Program
    {
        private const double UF = 34753.97; // Valor actual a la fecha 21 Nov 2022
        
        /**
         * <sumary>
         *   Retorna la unidad de fomento a precio chileno
         * </sumary>
         * <returns>
         *   Devuelve la unidad de fomento, de tipo double
         * </returns>
         * <param name="unidadFomento">
         *   Recibe como parametro la unidad de fomento que ingresa el usuario por consola
         * </param>
         */
        static double convertirUF(int unidadFomento)
        {
            return (UF * unidadFomento);
        } 


        static void Main(string[] args)
        {
            int cantidadUF = 0;
            
            try
            {
                Console.WriteLine("Ingrese unidad de Fomento UF a cobrar por el servicio: ");
                cantidadUF = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nEl valor del servicio es: {convertirUF(cantidadUF)}");

            } catch (Exception e)
            {
                Console.Beep();
                Console.WriteLine("\nError: " + e.Message);
            }

            Console.WriteLine("\nPresione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
