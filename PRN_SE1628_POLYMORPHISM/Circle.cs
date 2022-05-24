namespace Prn.Se1628;
public class Circle : IShape
{
    public double Radius { get; set; }
    public Circle() { }
   
    public Circle(double radius) => Radius = radius;
    public double GetArea() => Math.Pow(Radius, 2) * Math.PI;


    public double GetPerimeter() => 2 * Math.PI * Radius;

    public override string? ToString() => $"[The circle with radius is {Radius}, Area = {this.GetArea()}, Perimeter = {this.GetPerimeter()}]";
}