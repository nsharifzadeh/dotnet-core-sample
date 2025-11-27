using Xunit;
using MyApp;

public class MyClassTests
{

    [Fact]
    public void Display_Correctenss()
  {
        var car = new Car("Toyota", "Corolla", 2020);
        Assert.Equal("Toyota", car.Make);
        Assert.Equal("Corolla", car.Model); 
  }
}