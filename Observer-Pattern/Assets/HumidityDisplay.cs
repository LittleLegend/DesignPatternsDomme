using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class HumidityDisplay : ConcreteDisplay, IObserver, IDisplay
{

    public WeatherStationController weatherSation;
    public WeatherData weatherData;
    public Image LoadingbarHumidity;
    public int humidity;
    public int maxHumid;
    public int minHumid;
    public Image Outline;
    public Image Bar;
    public TextMeshProUGUI HumidityTextfield;
   
    public void update(WeatherData weather)
    {
        weatherData = weather;
        humidity = weather.humidity;
        maxHumid = weather.maxHumid;
        minHumid = weather.minHumid;
        weatherSation.Display2.display();

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
    

    public override int getMaxValue()
    {
        return maxHumid;
    }

    public override int getMinValue()
    {
        
        return minHumid;
    }

    public override int getValue()
    {
        
        return humidity;
    }

    public override void switchActive()
    {
        if (active)
        {
            Unsubscribe(weatherData);
        }
        else
        {
            Subscribe(weatherData);
        }

        active = !active;
        weatherSation.Display2.display();

    }
    
}

