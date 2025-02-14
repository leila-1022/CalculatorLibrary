    using System;
    using System.Collections.Generic;
    using System.Linq;
public static class Circle
{
    public static double Radius { get; set; }

    public static double Area()
    {
        return Math.PI * (Radius * Radius);
    }

    public static double Circumference()
    {
        return 2 * Math.PI * Radius;
    }
}