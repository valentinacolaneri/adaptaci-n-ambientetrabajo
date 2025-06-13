using System;

public class EjercicioCronometro
{
    public static void Ejecutar()
    {
        Cronometro cronometro = new Cronometro();

        for (int i = 0; i < 5000; i++)
        {
            cronometro.IncrementarTiempo();
        }

        Console.WriteLine(cronometro.MostrarTiempo());
    }
}

public class Cronometro
{
    private int minutos;
    private int segundos;

    public Cronometro()
    {
        minutos = 0;
        segundos = 0;
    }

    public void Reiniciar()
    {
        minutos = 0;
        segundos = 0;
    }

    public void IncrementarTiempo()
    {
        segundos++;

        if (segundos >= 60)
        {
            minutos++;
            segundos = 0;
        }
    }

    public string MostrarTiempo()
    {
        return minutos + " minutos, " + segundos + " segundos";
    }
}
