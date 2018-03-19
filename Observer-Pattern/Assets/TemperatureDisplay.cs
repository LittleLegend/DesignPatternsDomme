using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TemperatureDisplay : MonoBehaviour,IObserver {

    public WeatherStationController weatherSation;
    public WeatherData weatherData;
    public Image LoadingbarTemperatrue;
    public int temperature;
    public LoadingbarTemperatureBehavior loadingbarTemperatureBehavior = new LoadingbarTemperatureBehavior();
    public TemperatureTextBehavior temperatureTextBehavior = new TemperatureTextBehavior();
    public TextMeshProUGUI TemperatureTextfield;

    public void update() {
      
        temperature = weatherData.temperature;
        loadingbarTemperatureBehavior.displayLoading(temperature,weatherData.maxTemp, weatherData.minTemp, LoadingbarTemperatrue);
        temperatureTextBehavior.displayText(temperature.ToString() + "C°", TemperatureTextfield);
    }

   
    public void Start()
    {
        weatherData = weatherSation.weatherData;
        this.SubcribeWeatherData();
    }

    public void SubcribeWeatherData()
    {
        weatherData.registerIObserver(this, weatherData.Displays);
    }

    public void UnsubcibeWeatherData()
    {
        weatherData.removeObserver(this, weatherData.Displays);
    }

}
