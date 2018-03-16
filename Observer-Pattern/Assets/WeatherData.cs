using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherData: Observable{

    public int humidity;
    public int temperature;
    public List<IObserver> Displays = new List<IObserver>();

    public WeatherData(int h, int t)
    {
        humidity = h;
        temperature = t;

    }

	public void weatherChanged()
    {
        notifyObservers(Displays,this);
    }

}
