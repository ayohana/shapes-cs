using System;

namespace Shapes.Models
{
  public class Sphere
  {
    public Circle Face { get; set; }

    public double GetVolume()
    {
      return Math.Round((4 * Circle.Pi * Math.Pow(Face.Radius, 3) /3), 1);
      // MathRound(value, decimalPoints)
    }

    public double GetSurfaceArea()
    {
      return Math.Round((4 * Circle.Pi * Math.Pow(Face.Radius, 2)), 2); 
    }
    
  }
}