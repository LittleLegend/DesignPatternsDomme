using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class TemperatureDisplay : ConcreteDisplay, IObserver
{

    public WeatherStationController weatherSation;
    public WeatherData weatherData;
    public Image LoadingbarTemperatrue;
    public int temperature;
    public int maxTemp;
    public int minTemp;
    public Image Outline;
    public Image Bar;
    public TextMeshProUGUI TemperatureTextfield;
    
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
    public override int getMaxValue()
    {
        return maxTemp;
        
    }

    public override int getMinValue()
    {
        return minTemp;
    }

    public override int getValue()
    {
        return temperature;
        
    }

    public override void switchActive()
    {
        if(active)
        {
            Unsubscribe(weatherData);
        }else
        {
            Subscribe(weatherData);
        }
        
        active = !active;
        weatherSation.Display1.display();


    }
}
