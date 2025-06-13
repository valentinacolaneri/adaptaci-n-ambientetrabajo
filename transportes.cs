using System;

public class EjercicioVehiculos
{
    public static void Ejecutar()
    {
        Auto fiat = new Auto(45);
        Bicicleta bici = new Bicicleta();
        Camion camion = new Camion();

        bici.mover(20);
        Console.WriteLine("Bicicleta posición: " + bici.posicion() + " metros");
        bici.mover(10);
        Console.WriteLine("Bicicleta nueva posición: " + bici.posicion() + " metros");

        Carrera carrera1 = new Carrera(fiat, camion);
        Console.WriteLine("\nInicia carrera entre auto y camión (duración: 10 segundos)");
        carrera1.correr(10);
    }
}

public interface Vehiculo
{
    void mover(int tiempo);
    int posicion();
    void reiniciarPosicion();
}

public class Bicicleta : Vehiculo
{
    private int posicionActual = 0;
    private const int velocidad = 10;

    public void mover(int tiempo)
    {
        posicionActual += velocidad * tiempo;
    }

    public int posicion()
    {
        return posicionActual;
    }

    public void reiniciarPosicion()
    {
        posicionActual = 0;
    }
}

public class Camion : Vehiculo
{
    private int posicionActual = 0;
    private const int velocidad = 30;

    public void mover(int tiempo)
    {
        posicionActual += velocidad * tiempo;
    }

    public int posicion()
    {
        return posicionActual;
    }

    public void reiniciarPosicion()
    {
        posicionActual = 0;
    }
}

public class Auto : Vehiculo
{
    private int posicionActual = 0;
    private int velocidad;

    public Auto(int velocidad = 40)
    {
        this.velocidad = velocidad;
    }

    public void mover(int tiempo)
    {
        posicionActual += velocidad * tiempo;
    }

    public int posicion()
    {
        return posicionActual;
    }

    public void reiniciarPosicion()
    {
        posicionActual = 0;
    }
}

public class Carrera
{
    private Vehiculo v1;
    private Vehiculo v2;

    public Carrera(Vehiculo vehiculo1, Vehiculo vehiculo2)
    {
        v1 = vehiculo1;
        v2 = vehiculo2;
    }

    public void correr(int segundos)
    {
        v1.mover(segundos);
        v2.mover(segundos);
        Console.WriteLine("Posición del vehículo 1: " + v1.posicion() + " metros");
        Console.WriteLine("Posición del vehículo 2: " + v2.posicion() + " metros");
    }
}
