using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

public class Swimming : Activity
{
    private int _laps;
    private const double LapDistanceInMiles = 50.0 / 1000 * 0.62;

    public Swimming(DateTime date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        _laps = laps;
 
    }

    public override double GetDistance() => _laps * LapDistanceInMiles;
     public override double GetSpeed() => (GetDistance() / LengthInMinutes) * 60;
     public override double GetPace() => LengthInMinutes / GetDistance();
}