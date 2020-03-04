namespace Shapes.Models
{
  public class Circle
  {
    public double Radius { get; set; }
    public const double Pi = 3.14;

    public const double Two = 2;
    public Circle(double radius)
    {
      Radius = radius; 
    }

    public double GetCircumference() 
    {
      return Two * Pi * Radius; 
    }

    public double GetDiameter()
    {
        return Two * Radius;
    }

    
  }
}
