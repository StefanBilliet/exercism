class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int minutesLasagnaHasBeenInTheOven)
    {
        return ExpectedMinutesInOven() - minutesLasagnaHasBeenInTheOven;
    }

    public int PreparationTimeInMinutes(int preparationTimeInMinutesPerLayer)
    {
        return preparationTimeInMinutesPerLayer * 2;
    }

    public int ElapsedTimeInMinutes(int numberOfLayersInLasagna, int minutesLasagnaHasBeenInTheOven)
    {
        return PreparationTimeInMinutes(numberOfLayersInLasagna) + minutesLasagnaHasBeenInTheOven;
    }
}
