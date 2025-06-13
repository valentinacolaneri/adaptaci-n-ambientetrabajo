using System;

class Program
{
    static void Main(string[] args)
    {
        Semaforo semaforo = new Semaforo("Rojo");

        semaforo.mostrarColor();

        semaforo.pasoDelTiempo(10);
        semaforo.mostrarColor();

        semaforo.pasoDelTiempo(25);
        semaforo.mostrarColor();

        semaforo.ponerEnIntermitente();
        for (int i = 0; i < 5; i++)
        {
            semaforo.pasoDelTiempo(1);
            semaforo.mostrarColor();
        }

        semaforo.sacarDeIntermitente();
        semaforo.mostrarColor();
    }
}
