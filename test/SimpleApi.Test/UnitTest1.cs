using Xunit;
using SimpleApi.Controllers;
namespace SimpleApi.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }
     ValuesController controller = new ValuesController();
    // WeatherForecastController controller = new WeatherForecastController();
    [Fact]
    
    public void GetReturnsCorrectNumber()
    {
         var returnValue = controller.Get(1);
        Assert.Equal("Les Jackson", returnValue.Value);
    }
}