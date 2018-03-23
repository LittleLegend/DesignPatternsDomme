using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class HumidityDisplay : MonoBehaviour, IObserver,IDisplay {

    public WeatherStationController weatherSation;
    public WeatherData weatherData;
    public Image LoadingbarHumidity;
    public int humidity;
    public int maxHumid;
    public int minHumid;
    public Image Outline;
    public Image Loadingbar;
    public LoadingbarHumidityBehavior loadingbarHumidityBehavior = new LoadingbarHumidityBehavior();
    public HumidityTextBehavior humidityTextBehavior = new HumidityTextBehavior();
    public TextMeshProUGUI HumidityTextfield;
    public bool active=true;

    public void update(WeatherData weather)
    {
        weatherData = weather;
        humidity = weather.humidity;
        maxHumid = weather.maxHumid;
        minHumid = weather.minHumid;
        display();

    }

    public void Subscribe(WeatherData weather)
    {
        weather.registerIObserver(this, weather.Displays);
        weather.weatherChanged();
    }

    public void Unsubscribe(WeatherData weather)
    {
        weather.removeObserver(this, weather.Displays);
        weather.weatherChanged();
    }

    public void display()
    {
       /* loadingbarHumidityBehavior.displayLoading(humidity, maxHumid, minHumid, LoadingbarHumidity);
        humidityTextBehavior.displayText(humidity.ToString() + "%", HumidityTextfield);*/
    }

   

    public void Switch()
    {/*
        if (active)
        {
            Unsubscribe(weatherData);
            loadingbarHumidityBehavior.activeLoading(Loadingbar, Outline);
            humidityTextBehavior.activeText(HumidityTextfield);
        }
        else
        {
            Subscribe(weatherData);
            loadingbarHumidityBehavior.deactiveLoading(Loadingbar, Outline);
            humidityTextBehavior.deactiveText(HumidityTextfield);
        }
        active = !active;
        */
    }

    public int getValue()
    {
        throw new NotImplementedException();
    }
}

