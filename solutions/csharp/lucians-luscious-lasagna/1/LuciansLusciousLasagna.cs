class Lasagna
{
    // 1. Devuelve los minutos esperados en el horno (40)
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // 2. Calcula el tiempo restante restando los minutos en horno
    public int RemainingMinutesInOven(int actualMinutes)
    {
        return ExpectedMinutesInOven() - actualMinutes;
    }

    // 3. Calcula el tiempo de preparación (2 minutos por cada capa)
    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    // 4. Suma el tiempo de preparación y los minutos que lleva en el horno
    public int ElapsedTimeInMinutes(int layers, int actualMinutes)
    {
        return PreparationTimeInMinutes(layers) + actualMinutes;
    }
}