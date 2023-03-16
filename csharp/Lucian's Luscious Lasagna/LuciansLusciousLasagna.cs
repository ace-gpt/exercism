class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int InOven) => ExpectedMinutesInOven() - InOven;
    
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int NumOfLayers) => NumOfLayers * 2;
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int NumOfLayers, int MinsInOven) => PreparationTimeInMinutes(NumOfLayers) + MinsInOven;
}