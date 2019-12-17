using CrudApi.Controllers;
using System;
using Xunit;

namespace CrudApi.Test
{
    public class UnitTest1
    {
        WeatherForecastController weatherForecastController = new WeatherForecastController();

        [Fact]
        public void getShouldReturnMyName()
        {
            var result = weatherForecastController.Get();
            Assert.Equal("Irfan", result.Value);
        }


        [Fact]
        public void Test1()
        {

        }
    }
}
