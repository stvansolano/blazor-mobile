using System.Threading.Tasks;
using MyApp.Shared  .Models;

namespace MyApp.Shared.Services
{
    public abstract class WeatherForecastService : IForecastService
	{
        public abstract Task<WeatherForecast[]> GetForecastAsync();
    }
}