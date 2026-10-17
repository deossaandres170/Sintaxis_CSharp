using System;

namespace Ejercicio1_TiposDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 24;
            double altura = 1.75;
            char inicial = 'J';
            bool esEstudiante = true;
            string nombre = "Juan Andrés";

            Console.WriteLine("--- EJERCICIO 1: TIPOS DE DATOS ---");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Inicial: " + inicial);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Altura: " + altura);
            Console.WriteLine("Es estudiante: " + esEstudiante);
        }
    }
}