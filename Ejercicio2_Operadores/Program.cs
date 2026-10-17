using System;

namespace Ejercicio2_Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 20.5;
            double num2 = 4.0;

            double suma = num1 + num2;
            double resta = num1 - num2;
            double multiplicacion = num1 * num2;
            double division = num1 / num2;
            double modulo = num1 % num2;

            double acumulador = 10.0;
            acumulador += 5.0;
            acumulador *= 2.0;

            Console.WriteLine("--- EJERCICIO 2: OPERADORES ARITMÉTICOS Y DE ASIGNACIÓN ---");
            Console.WriteLine($"Número 1: {num1}, Número 2: {num2}");
            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Resta: {resta}");
            Console.WriteLine($"Multiplicación: {multiplicacion}");
            Console.WriteLine($"División: {division}");
            Console.WriteLine($"Módulo: {modulo}");
            Console.WriteLine($"Resultado acumulador compuesto: {acumulador}");
        }
    }
}