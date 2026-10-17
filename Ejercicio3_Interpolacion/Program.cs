using System;

namespace Ejercicio3_Interpolacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string asignatura = "Análisis y Desarrollo de Software";
            int trimestreActual = 4;
            double promedioAcumulado = 4.6;

            Console.WriteLine("--- EJERCICIO 3: INTERPOLACIÓN DE STRINGS ---");
            Console.WriteLine($"Programa de formación: {asignatura}");
            Console.WriteLine($"Trimestre cursando actualmente: Trimestre N° {trimestreActual}");
            Console.WriteLine($"Su promedio académico actual es de: {promedioAcumulado:F1} puntos.");
            
            int horasSemanales = 40;
            Console.WriteLine($"Estimación de horas de estudio mensuales (4 semanas): {horasSemanales * 4} horas.");
        }
    }
}