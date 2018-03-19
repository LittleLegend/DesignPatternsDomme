using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HumidityDisplay : MonoBehaviour, IObserver {

    public WeatherStationController weatherSation;
    public WeatherData weatherData;
    public Image LoadingbarHumidity;
    public int humidity;
    public LoadingbarHumidityBehavior loadingbarHumidityBehavior = new LoadingbarHumidityBehavior();
    public HumidityTextBehavior humidityTextBehavior = new HumidityTextBehavior();
    public TextMeshProUGUI HumidityTextfield;

    public void update()
    {
        
        humidity = weatherData.humidity;
        loadingbarHumidityBehavior.displayLoading(humidity, weatherData.maxHumid, weatherData.minHumid, LoadingbarHumidity);
        humidityTextBehavior.displayText(humidity.ToString() + "%", HumidityTextfield);

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

