using System;

namespace webapi
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }

    
    public class GLDef
    {
        private static readonly string[] NatureNameArr = new[]
        {
            "Asset", "Liability", "Income", "Expense", "Capital"
        };

        public DateTime OpenDate { get; set; }

        public string Desc { get; set; }

        public int Nature { get; set; }

        public string NatureName => NatureNameArr[Nature];

        
    }
}
