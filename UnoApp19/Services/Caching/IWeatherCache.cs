namespace UnoApp19.Services.Caching;
using WeatherForecast = UnoApp19.Client.Models.WeatherForecast;
public interface IWeatherCache
{
    ValueTask<IImmutableList<WeatherForecast>> GetForecast(CancellationToken token);
}
