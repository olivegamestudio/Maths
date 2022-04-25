using System.Runtime.CompilerServices;

namespace OliveGameStudio;

public readonly struct Angle
{
    readonly float _degrees;

    public Angle(float degrees = 0)
    {
        _degrees = degrees;
    }

    public static Angle operator *(Angle source, float value)
    {
        return new Angle(source._degrees * value);
    }

    public static Angle operator +(Angle source, float value)
    {
        return new Angle(source._degrees + value);
    }

    public static Angle operator -(Angle source, float value)
    {
        return new Angle(source._degrees - value);
    }

    public static Angle operator -(Angle source)
    {
        return new Angle(-source._degrees);
    }

    public static Angle operator +(Angle source, Angle value)
    {
        return new Angle(source._degrees + value._degrees);
    }

    public static Angle operator -(Angle source, Angle value)
    {
        return new Angle(source._degrees - value._degrees);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public float ToDegrees()
    {
        return _degrees;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public float ToRadians()
    {
        return (float)Maths.ToRadians(_degrees);
    }
}
