﻿namespace CPG24_TheColor;

public class Color
{
    private byte R { get; }
    private byte G { get; }
    private byte B { get; }

    public static Color White { get; } = new Color(255, 255, 255);
    public static Color Black { get; } = new Color(0, 0, 0);
    public static Color Red { get; } = new Color(255, 0, 0);
    public static Color Green { get; } = new Color(0, 128, 0);
    public static Color Blue { get; } = new Color(0, 0, 255);
    public static Color Yellow { get; } = new Color(255, 255, 0);
    public static Color Orange { get; } = new Color(255, 165, 0);
    public static Color Purple { get; } = new Color(128, 0, 128);
    
    

    public Color(byte red, byte green, byte blue)
    {
        R = red;
        G = green;
        B = blue;
    }
    
}