using System;

namespace Tarea1CuotaPrestamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CALCULO DE CUOTA DE PRESTAMO ===");
            Console.Write("Monto del prestamo RD$: ");
            double monto = Convert.ToDouble(Console.ReadLine());
            Console.Write("Tasa de interes anual %: ");
            double tasaAnual = Convert.ToDouble(Console.ReadLine());
            Console.Write("Tiempo en meses: ");
            int tiempoMeses = Convert.ToInt32(Console.ReadLine());
            double tasaMensual = (tasaAnual / 100) / 12;
            double cuota = monto * (tasaMensual / (1 - Math.Pow(1 + tasaMensual, -tiempoMeses)));
            Console.WriteLine("\n--- Resultado ---");
            Console.WriteLine("Cuota Mensual: RD$ {0:N2}", cuota);
            Console.ReadLine();
        }
    }
}
