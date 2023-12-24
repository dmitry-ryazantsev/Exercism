public static class AssemblyLine
{
    public static double SuccessRate(int speed) => speed switch
    {
        < 1 => 0,
        <= 4 => 1,
        <= 8 => 0.9,
        9 => 0.8,
        10 => 0.77,
        _ => 0
    };

    public static double ProductionRatePerHour(int speed) => speed * 221 * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => (int)ProductionRatePerHour(speed) / 60;
}
