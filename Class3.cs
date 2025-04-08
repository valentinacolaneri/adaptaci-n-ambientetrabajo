using System;

// INTERFAZ
public interface IJugador
{
    bool Correr(int minutos);
    bool Cansado();
    void Descansar(int minutos);
}

// JUGADOR PROFESIONAL
public class Profesional : IJugador
{
    public int tiempoCorriendo;
    public const int limiteCansancio = 40;

    public Profesional()
    {
        tiempoCorriendo = 0;
    }

    public bool Correr(int minutos)
    {
        if (Cansado())
            return false;

        tiempoCorriendo += minutos;
        return !Cansado();
    }

    public bool Cansado()
    {
        return tiempoCorriendo >= limiteCansancio;
    }

    public void Descansar(int minutos)
    {
        tiempoCorriendo -= minutos;
        if (tiempoCorriendo < 0)
            tiempoCorriendo = 0;
    }
}

// JUGADOR AMATEUR
public class Amateur : IJugador
{
    public int tiempoCorriendo;
    private const int limiteCansancio = 20;

    public Amateur()
    {
        tiempoCorriendo = 0;
    }

    public bool Correr(int minutos)
    {
        if (Cansado())
            return false;

        tiempoCorriendo += minutos;
        return !Cansado();
    }

    public bool Cansado()
    {
        return tiempoCorriendo >= limiteCansancio;
    }

    public void Descansar(int minutos)
    {
        tiempoCorriendo -= minutos;
        if (tiempoCorriendo < 0)
            tiempoCorriendo = 0;
    }
}