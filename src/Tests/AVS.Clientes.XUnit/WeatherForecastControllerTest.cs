using AVS.Clientes.Api.Controllers;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;

namespace AVS.Clientes.XUnit
{

    public class WeatherForecastControllerTest
    {
        [Fact(DisplayName = "Obter temperaturas com sucesso")]
        [Trait("Categoria", "Weather Forecast Controller Test")]
        public void WeatherForecastController_Get_DeveExecutarComSucesso()
        {
            //Arrange
            var logger = new Mock<ILogger<WeatherForecastController>>();
            var ctl = new WeatherForecastController(logger.Object);

            //Act
            var result = ctl.Get();

            //Asset
            result.Should().HaveCountGreaterThan(0);
        }
    }
}
