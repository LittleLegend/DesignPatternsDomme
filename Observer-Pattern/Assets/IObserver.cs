using System.Collections;
using System.Collections.Generic;


public interface IObserver{

    void update(WeatherData weather);

    void Subscribe(WeatherData weather);

    void Unsubscribe(WeatherData weather);

}
