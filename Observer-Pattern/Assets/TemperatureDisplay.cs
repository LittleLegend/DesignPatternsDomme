using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class TemperatureDisplay: MonoBehaviour ,IObserver, IDisplay
{

    public WeatherStationController weatherSation;
    public WeatherData weatherData;
    public Image LoadingbarTemperatrue;
    public int temperature;
    public int maxTemp;
    public int minTemp;
    public Image Outline;
    public Image Loadingbar;
    public LoadingbarTemperatureBehavior loadingbarTemperatureBehavior = new LoadingbarTemperatureBehavior();
    public TemperatureTextBehavior temperatureTextBehavior = new TemperatureTextBehavior();
    public TextMeshProUGUI TemperatureTextfield;
    public bool active = true;

    
    public void update(WeatherData weather) {
        weatherData= weather;
        temperature = weather.temperature;
        maxTemp = weather.maxTemp;
        minTemp = weather.minTemp;
        weatherSation.Display1.display();
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

   
   

    public void Switch()
    {/*
        if (active)
        {
            Unsubscribe(weatherData);
            loadingbarTemperatureBehavior.activeLoading(Loadingbar, Outline);
            temperatureTextBehavior.activeText(TemperatureTextfield);
        }
        else
        {
            Subscribe(weatherData);
            loadingbarTemperatureBehavior.deactiveLoading(Loadingbar, Outline);
            temperatureTextBehavior.deactiveText(TemperatureTextfield);
        }
        active = !active;
        */
    }

    public int getValue()
    {
        return temperature;
    }

    public void display()
    {
        Debug.Log(getValue());
    }
}
