using System;

public class Semaforo
{
    public string colorActual; --guarda el color actual del semáforo(Rojo, Verde, etc.).
    public int tiempoRestante; --cuántos segundos faltan para cambiar al siguiente color.
    public bool intermitente;  --indica si el semáforo está en modo intermitente(True o False).
    public int tiempoIntermitente;  --contador para alternar entre “Amarillo” y “Apagado” cada segundo cuando está en modo intermitente.


    --Constructor semáforo
    --Cuando creamos un semáforo, definimos el color inicial(por ejemplo: "Rojo").
    --Se desactiva el modo intermitente y se resetea el tiempo intermitente.
    -- Se llama a CambiarColor(colorInicial) para iniciar el temporizador del color elegido.

    public Semaforo(String colorInicial)
    {
        intermitente = false;
        tiempoIntermitente = 0;
        CambiarColor(colorInicial);
    }


    --METODO
    --Si el semáforo está en modo intermitente, solo se suma el tiempo(para alternar amarillo/apagado).
    --Si NO está en intermitente: Se descuenta el tiempo(tiempoRestante -= segundos) / Si se termina el tiempo, avanza al siguiente color llamando a AvanzarColor(). 

    public void pasoDelTiempo(int segundos)
    {
        if (intermitente)
        {
            tiempoIntermitente += segundos;
        }
        else
        {
            tiempoRestante -= segundos;
            while (tiempoRestante <= 0)
            {
                AvanzarColor();
            }
        }
    }

    --METODO
    --Si está en intermitente: Alterna entre “Amarillo” y “Apagado” cada segundo.
    --Si no está en intermitente, muestra el color actual del semáforo.
    public void mostrarColor()
    {
        if (intermitente)
        {
            if ((tiempoIntermitente % 2) == 0)
                Console.WriteLine("Amarillo (intermitente)");
            else
                Console.WriteLine("Apagado");
        }
        else
        {
            Console.WriteLine(colorActual);
        }
    }

    --METODO
    --ponerEnIntermitente() activa el modo intermitente y reinicia el contador.
    --sacarDeIntermitente() vuelve al modo normal.

    public void ponerEnIntermitente()
    {
        intermitente = true;
        tiempoIntermitente = 0;
    }

    public void sacarDeIntermitente()
    {
        intermitente = false;
        tiempoIntermitente = 0;
    }
    }

    --METODO
    --Define el tiempo que dura cada color al cambiar.
    --El color actual se actualiza y se le asigna su tiempo correspondiente.
    private void CambiarColor(string color)
    {
        colorActual = color;
        switch (color)
        {
            case "Rojo":
                tiempoRestante = 30;
                break;
            case "RojoAmarillo":
                tiempoRestante = 2;
                break;
            case "Verde":
                tiempoRestante = 20;
                break;
            case "Amarillo":
                tiempoRestante = 2;
                break;
        }
    }

    --METODO
    --Define la secuencia del semáforo: Rojo → RojoAmarillo → Verde → Amarillo → Rojo
    --- Cada vez que se acaba el tiempo del color actual, se llama a esta función para avanzar.
    
    public void AvanzarColor()
    {
        switch (colorActual)
        {
            case "Rojo":
                CambiarColor("RojoAmarillo");
                break;
            case "RojoAmarillo":
                CambiarColor("Verde");
                break;
            case "Verde":
                CambiarColor("Amarillo");
                break;
            case "Amarillo":
                CambiarColor("Rojo");
                break;
        }
    }
}
 