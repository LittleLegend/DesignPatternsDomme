using System.Collections;
using System.Collections.Generic;


public class Observable
{

    public void registerIObserver(IObserver observer, List<IObserver> list)
    {
        list.Add(observer);
    }

    public void removeObserver(IObserver observer, List<IObserver> list)
    {
        list.Remove(observer);
    }

    public void notifyObservers(List<IObserver> list, WeatherData weather)
    {
        foreach(IObserver observer in list)
        {
            observer.update();

        }
    }

    
}
