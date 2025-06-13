using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Ejercicio Semáforo ===");
        EjercicioSemaforo.Ejecutar();

        Console.WriteLine("\n=== Ejercicio Banco ===");
        EjercicioBanco.Ejecutar();

        Console.WriteLine("\n=== Ejercicio Cronómetro ===");
        EjercicioCronometro.Ejecutar();

        Console.WriteLine("\n=== Ejercicio Jugador ===");
        EjercicioJugador.Ejecutar();

        Console.WriteLine("\n=== Ejercicio Vehículos ===");
        EjercicioVehiculos.Ejecutar();

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
