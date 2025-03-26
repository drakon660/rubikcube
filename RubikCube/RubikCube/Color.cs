using System.Security.Cryptography;

namespace RubikCube;

public readonly struct Color : IEquatable<Color>
{
    private char Value { get; }

    private Color(char value)
    {
        Value = value;
    }

    public static Color W { get; } = new ('W');
    public static Color G { get; } = new ('G');
    public static Color Y { get; } = new ('Y');
    public static Color O { get; } = new ('O');
    public static Color R { get; } = new ('R');
    public static Color B { get; } = new ('B');
    
    public static Color From(char value)
    {
        return value switch
        {
            'W' => W,
            'G' => G,
            'Y' => Y,
            'O' => O,
            'R' => R,
            'B' => B,
            _ => throw new ArgumentException($"Invalid color character: {value}")
        };
    }

    public bool Equals(Color other)
    {
        return Value == other.Value;
    }

    public override bool Equals(object obj)
    {
        return obj is Color other && Equals(other);
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
    
    public static implicit operator char(Color color) => color.Value;
    public static implicit operator Color(char value) => new (value);

    public override string ToString()
    {
        return Value.ToString();
    }
}