
using System;

public class Semaforo
{
    private string colorActual;
    private int tiempoRestante;
    private bool intermitente;
    private bool mostrarAmarillo;

    private readonly string[] secuencia = { "Rojo", "Rojo-Amarillo", "Verde", "Amarillo" };
    private readonly int[] duraciones = { 30, 2, 20, 2 };
    private int indiceSecuencia = 0;

    public Semaforo(string colorInicial)
    {
        intermitente = false;
        mostrarAmarillo = true;

        // Encontrar el índice de la secuencia para el color inicial
        for (int i = 0; i < secuencia.Length; i++)
        {
            if (secuencia[i] == colorInicial)
            {
                indiceSecuencia = i;
                break;
            }
        }
        colorActual = secuencia[indiceSecuencia];
        tiempoRestante = duraciones[indiceSecuencia];
    }

    public void pasoDelTiempo(int segundos)
    {
        if (intermitente)
        {
            for (int i = 0; i < segundos; i++)
            {
                mostrarAmarillo = !mostrarAmarillo;
            }
            return;
        }

        while (segundos > 0)
        {
            if (segundos >= tiempoRestante)
            {
                segundos -= tiempoRestante;
                avanzarSecuencia();
            }
            else
            {
                tiempoRestante -= segundos;
                segundos = 0;
            }
        }
    }

    private void avanzarSecuencia()
    {
        indiceSecuencia = (indiceSecuencia + 1) % secuencia.Length;
        colorActual = secuencia[indiceSecuencia];
        tiempoRestante = duraciones[indiceSecuencia];
    }

    public void mostrarColor()
    {
        if (intermitente)
        {
            Console.WriteLine(mostrarAmarillo ? "Amarillo" : "Apagado");
        }
        else
        {
            Console.WriteLine(colorActual);
        }
    }

    public void ponerEnIntermitente()
    {
        intermitente = true;
    }

    public void sacarDeIntermitente()
    {
        intermitente = false;
    }
}
