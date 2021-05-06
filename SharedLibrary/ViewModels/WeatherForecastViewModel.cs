using SharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedLibrary.ViewModels
{
    public class WeatherForecastViewModel
    {
        public string Meta { get; set; }
        public List<WeatherForecast> WeatherForecasts { get; set; }
    }
}
