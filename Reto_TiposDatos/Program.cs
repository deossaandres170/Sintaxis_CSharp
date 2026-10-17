const string unidadMedida = "metros";

Console.WriteLine("--- RETO: TIPOS DE DATOS Y CONVERSIONES ---");
Console.Write("Por favor, introduce la base del rectángulo: ");
string? inputBase = Console.ReadLine();

Console.Write("Por favor, introduce la altura del rectángulo: ");
string? inputAltura = Console.ReadLine();

double baseRectangulo = double.Parse(inputBase ?? "0");
double alturaRectangulo = double.Parse(inputAltura ?? "0");

double area = baseRectangulo * alturaRectangulo;
double perimetro = 2 * (baseRectangulo + alturaRectangulo);

Console.WriteLine("\n[RESULTADOS DEL RETO]");
Console.WriteLine($"Base ingresada: {baseRectangulo} {unidadMedida}");
Console.WriteLine($"Altura ingresada: {alturaRectangulo} {unidadMedida}");
Console.WriteLine($"Área calculada: {area} {unidadMedida} cuadrados.");
Console.WriteLine($"Perímetro calculado: {perimetro} {unidadMedida}.");