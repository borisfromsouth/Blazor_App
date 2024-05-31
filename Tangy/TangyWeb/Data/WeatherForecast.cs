namespace TangyWeb.Data
{
    public class WeatherForecast  // класс-шаблон для передачи данных по прогнозу погоды
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
