class Box
{
    private double length; //Довжина
    private double width; //Ширина
    private double height; //Висота

    //Властивості
    public double Length { get; set; }
    public double Width { get; set; }
    public int Height { get; set; }

    //Конструктор
    public Box(double l, double w, double h) { length = l; width = w; height = h; }

    public double SurfaceArea() { return ((2 * length * width) + (2 * length * height) + (2 * width * height)); } //Площа поверхні
    public double LateralSurfaceArea() { return ((2 * length * height) + (2 * width * height)); } //Площа бічної поверхні
    public double Volume() { return (length * width * height); } //Об'єм
}