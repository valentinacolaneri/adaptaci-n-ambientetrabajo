using System;

--minutos y segundos: son las variables que guarda el tiempo transcurrido. Se inician en 0 cuando el cronómetro se reinicia.
public class Cronometro
{
    public int minutos;
    public int segundos;

    --CONSTRUCTOR
    --Cuando se crea un cronómetro, se llama al método Reiniciar() para que empiece desde cero.
    public Cronometro()
    {
        Reiniciar();
    }

    --Este método resetea los dos contadores a 0
    public void Reiniciar()
    {
        minutos = 0;
        segundos = 0;
    }

    --Cada vez que se llama este método: Aumenta en 1 el contador de segundos.
    --O Si se llega a 60 segundos, se suma 1 minuto y se reinician los segundos a 0 
    public void IncrementarTiempo()
    {
        segundos++;
        if (segundos >= 60)
        {
            minutos++;
            segundos = 0;
        }
    }

    --Devuelve un string con el tiempo actual del cronómetro en el formato pedido: X minutos, Y segundos
    public string MostrarTiempo()
    {
        return $"{minutos} minutos, {segundos} segundos";
    }
}