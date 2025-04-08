--MAIN EJERCICIO JUGADOR
class Program
{
    static void Main()
    {
        IJugador jugador1 = new Profesional();
        IJugador jugador2 = new Amateur();

        Console.WriteLine("🏃 Profesional corre de a 10 minutos:");
        for (int i = 0; i < 5; i++)
        {
            bool pudoCorrer = jugador1.Correr(10);
            Console.WriteLine($"Intento {i + 1}: ¿Pudo correr? {pudoCorrer}. ¿Está cansado? {jugador1.Cansado()}");
        }

        Console.WriteLine("\n💤 El profesional descansa 20 minutos...");
        jugador1.Descansar(20);
        Console.WriteLine($"¿Está cansado ahora? {jugador1.Cansado()}");

        Console.WriteLine("\n🏃 Amateur corre de a 5 minutos:");
        for (int i = 0; i < 5; i++)
        {
            bool pudoCorrer = jugador2.Correr(5);
            Console.WriteLine($"Intento {i + 1}: ¿Pudo correr? {pudoCorrer}. ¿Está cansado? {jugador2.Cansado()}");
        }

        Console.WriteLine("\n💤 El amateur descansa 10 minutos...");
        jugador2.Descansar(10);
        Console.WriteLine($"¿Está cansado ahora? {jugador2.Cansado()}");
    }
}
