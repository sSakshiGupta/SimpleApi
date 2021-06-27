using SimpleApi.Controllers;
using System;
using Xunit;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            WeatherForecastController wController = new WeatherForecastController();
           var data= wController.FetchData(1);
            Assert.Equal("Sakshi", data);
        }
    }
}
