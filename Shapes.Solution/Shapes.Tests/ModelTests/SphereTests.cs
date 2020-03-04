using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class SphereTests
  {

    [TestMethod]
    public void Sphere_GetVolume_VolumeOfSphere()
    {
      // Arrange
      Sphere newSphere = new Sphere();
      newSphere.Face = new Circle(2);
      // Act
      double result = newSphere.GetVolume();
      // Assert
      Assert.AreEqual(result, 33.5);
    }

    [TestMethod]
    public void Sphere_GetSurfaceArea_SurfaceAreaOfSphere()
    {
      Sphere newSphere = new Sphere();
      newSphere.Face = new Circle(2);
      double result = newSphere.GetSurfaceArea();
      Assert.AreEqual(result, 50.24);
    }
  }
  
}