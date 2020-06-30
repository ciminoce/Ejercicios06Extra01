using System;

namespace Ejercicios06Extra01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ingresados los extremos de un intervalo de nros. enteros
             mostrar los equivalentes de los mismos en binario*/
            Console.Title = "Listado de Nros. Binarios de un intervalo";
            var nroMenor = 0;
            var nroMayor = 0;
            var noError = true;
            do
            {
                Console.Write("Ingrese el primer extremo del intervalo:");
                while (!int.TryParse(Console.ReadLine(), out nroMenor))
                {
                    Console.WriteLine("El extremo menor debe ser nro entero");
                }
                Console.Write("Ingrese el segundo extremo del intervalo:");
                while (!int.TryParse(Console.ReadLine(), out nroMayor))
                {
                    Console.WriteLine("El extremo mayor debe ser nro entero");
                }
                if (nroMenor >= nroMayor)
                {
                    Console.WriteLine("Nro menor es mayor o igual al nro mayor... intente otra vez!!!");
                }
                else
                {
                    noError = false;
                }

            } while (noError);

            for (int i = nroMenor; i <= nroMayor; i++)
            {
                double equivalenteBinario = ConvertirBinario(i);
                Console.WriteLine($"{i} equivale a {equivalenteBinario} en binario");
            }

            Console.ReadLine();
        }

        private static double ConvertirBinario(int nroDecimal)
        {
            double nroBinario = 0;
            int contador = 0;
            bool noSalir = true;
            do
            {
                var resto = nroDecimal % 2;
                nroBinario = nroBinario + resto * Math.Pow(10, contador);
                nroDecimal = nroDecimal / 2;
                contador++;
                if (nroDecimal < 2)
                {
                    nroBinario = nroBinario + nroDecimal * Math.Pow(10, contador);
                    noSalir = false;
                }
            } while (noSalir);

            return nroBinario;
        }
    }
}
