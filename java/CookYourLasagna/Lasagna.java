public class Lasagna {
    public int expectedMinutesInOven() {
        return 40;
    };

    public int remainingMinutesInOven(int minutesRemaining) {
        return expectedMinutesInOven() - minutesRemaining;
    };

    public int preparationTimeInMinutes(int numberOfLayers) {
        return numberOfLayers * 2;
    };

    public int totalTimeInMinutes(int numberOfLayers, int numberOfMinutes) {
        return preparationTimeInMinutes(numberOfLayers) + numberOfMinutes;
    };
}