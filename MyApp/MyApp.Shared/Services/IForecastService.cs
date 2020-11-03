using System.Threading.Tasks;

namespace MyApp.Shared.Services
{
    public interface IForecastService
	{
        Task<WeatherForecast[]> GetForecastAsync();
	}
}
