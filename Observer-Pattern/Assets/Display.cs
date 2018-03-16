using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display : MonoBehaviour,IObserver {

    public WeatherStationController weatherSation;
    public WeatherData weatherData;
    public int humidity;
    public int temerature;

    public void update() {
        humidity = weatherData.humidity;
        temerature = weatherData.temperature;
        display();

    }

    public void display()
    {
        
    }

    public void Start()
    {
        weatherData = weatherSation.weatherData;
        weatherData.registerIObserver(this,weatherData.Displays);
    }
	
}
