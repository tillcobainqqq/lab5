using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("length: ");

        double l = double.Parse(Console.ReadLine());

        Console.Write("width: ");

        double w = double.Parse(Console.ReadLine());

        Console.Write("height: ");

        double h = double.Parse(Console.ReadLine());

        if (l > 0 && w > 0 && h > 0)
        {
            Box box = new Box(l, w, h);

            Console.WriteLine("\nSurface Area - " + box.SurfaceArea());
            Console.WriteLine("Lateral Surface Area - " + box.LateralSurfaceArea());
            Console.WriteLine("Volume - " + box.Volume());
        }
        else
        {
            Console.WriteLine();

            if (l <= 0)
                throw new ArgumentException("Length cannot be zero or negative");
            if (w <= 0)
                throw new ArgumentException("Width cannot be zero or negative");
            if (h <= 0)
                throw new ArgumentException("Height cannot be zero or negative");
        }
    }
}
