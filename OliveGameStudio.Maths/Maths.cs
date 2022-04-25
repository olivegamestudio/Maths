using System;

namespace OliveGameStudio;

public static class Maths
{
    public static double ToDegrees(double radians)
    {
        return (180 / Math.PI) * radians;
    }

    public static double ToRadians(double degrees)
    {
        return (Math.PI / 180) * degrees;
    }
}
