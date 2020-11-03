using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using MyApp.Shared.Models;

namespace MyApp
{
	public class MobileWeatherForecast : MyApp.Shared.Services.WeatherForecastService
	{
		public override async Task<WeatherForecast[]> GetForecastAsync()
		{
			return await JsonSerializer.DeserializeAsync<WeatherForecast[]>(
				new MemoryStream(System.Text.Encoding.UTF8.GetBytes(JSON))
			);
		}

        #region JSON
        private readonly string JSON = @"[
        {
          ""date"": ""2018-05-06"",
          ""temperatureC"": 1,
          ""summary"": ""Freezing"",
          ""temperatureF"": 33
        },
        {
          ""date"": ""2018-05-07"",
          ""temperatureC"": 14,
          ""summary"": ""Bracing"",
          ""temperatureF"": 57
        },
        {
          ""date"": ""2018-05-08"",
          ""temperatureC"": -13,
          ""summary"": ""Freezing"",
          ""temperatureF"": 9
        },
        {
          ""date"": ""2018-05-09"",
          ""temperatureC"": -16,
          ""summary"": ""Balmy"",
          ""temperatureF"": 4
        },
        {
          ""date"": ""2018-05-10"",
          ""temperatureC"": -2,
          ""summary"": ""Chilly"",
          ""temperatureF"": 29
        }
      ]";

		#endregion
	}
}