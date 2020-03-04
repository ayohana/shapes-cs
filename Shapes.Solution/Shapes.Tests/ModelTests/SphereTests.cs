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
  }
  
}