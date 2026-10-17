const double notaMinimaAprobatoria = 3.5;
const int asistenciaMinimaPorcentaje = 80;

Console.WriteLine("--- RETO: OPERADORES LÓGICOS Y RELACIONALES ---");

double notaFinalModulo = 4.2;
int porcentajeAsistencia = 85;

bool apruebaPorNota = notaFinalModulo >= notaMinimaAprobatoria;
bool apruebaPorAsistencia = porcentajeAsistencia >= asistenciaMinimaPorcentaje;
bool resultadoAprobacionGlobal = apruebaPorNota && apruebaPorAsistencia;

Console.WriteLine($"Nota obtenida: {notaFinalModulo} (Mínimo: {notaMinimaAprobatoria}) -> ¿Cumple nota?: {apruebaPorNota}");
Console.WriteLine($"Asistencia: {porcentajeAsistencia}% (Mínimo: {asistenciaMinimaPorcentaje}%) -> ¿Cumple asistencia?: {apruebaPorAsistencia}");
Console.WriteLine($"\n¿El aprendiz aprueba el módulo formativo?: {resultadoAprobacionGlobal}");