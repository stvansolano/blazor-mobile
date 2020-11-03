using System.Threading.Tasks;
using MyApp.Shared.Models;

namespace MyApp.Shared.Services
{
    public interface IForecastService
	{
        Task<WeatherForecast[]> GetForecastAsync();
	}
}
