namespace SpaceAge;

public class SpaceAge
{
    private int _seconds;

    public SpaceAge(int seconds)
    {
        _seconds = seconds;
    }

    public double OnEarth()
    {
        const double SecondsInYear = 31557600;
        return _seconds / SecondsInYear;
    }

    public double OnMercury()
    {
        const double MercuryOrbitalPeriodInEarthYears = 0.2408467;
        return OnEarth() / MercuryOrbitalPeriodInEarthYears;
    }

    public double OnVenus()
    {
        const double VenusOrbitalPeriodInEarthYears = 0.61519726;
        return OnEarth() / VenusOrbitalPeriodInEarthYears;
    }

    public double OnMars()
    {
        const double MarsOrbitalPeriodInEarthYears = 1.8808158;
        return OnEarth() / MarsOrbitalPeriodInEarthYears;
    }

    public double OnJupiter()
    {
        const double MercuryOrbitalPeriodInEarthYears = 11.862615;
        return OnEarth() / MercuryOrbitalPeriodInEarthYears;
    }

    public double OnSaturn()
    {
        const double SaturnOrbitalPeriodInEarthYears = 29.447498;
        return OnEarth() / SaturnOrbitalPeriodInEarthYears;
    }

    public double OnUranus()
    {
        const double UranusOrbitalPeriodInEarthYears = 84.016846;
        return OnEarth() / UranusOrbitalPeriodInEarthYears;
    }

    public double OnNeptune()
    {
        const double NeptuneOrbitalPeriodInEarthYears = 164.79132;
        return OnEarth() / NeptuneOrbitalPeriodInEarthYears;
    }
}