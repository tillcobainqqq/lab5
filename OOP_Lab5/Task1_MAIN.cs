using System;

class Task1_MAIN
{
    static void Main(string[] args)
    {
        Console.Write("length: ");

        double l = double.Parse(Console.ReadLine());

        Console.Write("width: ");

        double w = double.Parse(Console.ReadLine());

        Console.Write("height: ");

        double h = double.Parse(Console.ReadLine());

        Box box = new Box(l, w, h);

        Console.WriteLine("\nSurface Area - " + box.SurfaceArea());
        Console.WriteLine("Lateral Surface Area - " + box.LateralSurfaceArea());
        Console.WriteLine("Volume - " + box.Volume());
    }
}