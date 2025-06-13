using System;

public class EjercicioJugador
{
    public static void Ejecutar()
    {
        Jugador jugador1 = new Amateur();
        Jugador jugador2 = new Profesional();

        Console.WriteLine("Jugador Amateur intenta correr 15 minutos:");
        Console.WriteLine("¿Puede correr? " + jugador1.correr(15));
        Console.WriteLine("¿Está cansado? " + jugador1.cansado());

        Console.WriteLine("Jugador Amateur intenta correr 10 minutos más:");
        Console.WriteLine("¿Puede correr? " + jugador1.correr(10));

        Console.WriteLine("Descansando 10 minutos...");
        jugador1.descansar(10);
        Console.WriteLine("¿Está cansado ahora? " + jugador1.cansado());

        Console.WriteLine("\nJugador Profesional intenta correr 30 minutos:");
        Console.WriteLine("¿Puede correr? " + jugador2.correr(30));
        Console.WriteLine("¿Está cansado? " + jugador2.cansado());

        Console.WriteLine("Jugador Profesional intenta correr 15 minutos más:");
        Console.WriteLine("¿Puede correr? " + jugador2.correr(15));
    }
}

public interface Jugador
{
    bool correr(int minutos);
    bool cansado();
    void descansar(int minutos);
}

public class Amateur : Jugador
{
    private int minutosCorridos = 0;

    public bool correr(int minutos)
    {
        if (minutosCorridos + minutos > 20)
        {
            return false;
        }
        minutosCorridos += minutos;
        return true;
    }

    public bool cansado()
    {
        return minutosCorridos >= 20;
    }

    public void descansar(int minutos)
    {
        minutosCorridos -= minutos;
        if (minutosCorridos < 0)
        {
            minutosCorridos = 0;
        }
    }
}

public class Profesional : Jugador
{
    private int minutosCorridos = 0;

    public bool correr(int minutos)
    {
        if (minutosCorridos + minutos > 40)
        {
            return false;
        }
        minutosCorridos += minutos;
        return true;
    }

    public bool cansado()
    {
        return minutosCorridos >= 40;
    }

    public void descansar(int minutos)
    {
        minutosCorridos -= minutos;
        if (minutosCorridos < 0)
        {
            minutosCorridos = 0;
        }
    }
}
