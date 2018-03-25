using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherStationController : MonoBehaviour {

 
    public float inputDelay;
    public int minTemp;
    public int maxTemp;
    public int minHumid;
    public int maxHumid;
    public WeatherData weatherData = new WeatherData(0, 0);
    public HumidityDisplay humidityDisplay;
    public TemperatureDisplay temperatureDisplay;
    public IDisplay Display1;
    public IDisplay Display2;
    public Color32 Red;
    public Color32 Blue;
    public Color32 Gray;
    public Color32 White;

    void Start () {


        setWeatherData();
       


        Display1 = temperatureDisplay;
        Display1 = new TextDecorator(Display1, temperatureDisplay.TemperatureTextfield, Red, " C°");
        Display1 = new LoadingbarDecorator(Display1, temperatureDisplay.Outline, temperatureDisplay.Bar);
        Display1 = new ActivateDecorator(Display1, temperatureDisplay.Outline, temperatureDisplay.Bar, temperatureDisplay.TemperatureTextfield,White,Gray,Red);
        

        Display2 = humidityDisplay;
        Display2 = new TextDecorator(Display2, humidityDisplay.HumidityTextfield, Color.blue, " %");
        Display2 = new LoadingbarDecorator(Display2, humidityDisplay.Outline, humidityDisplay.Bar);
        Display2 = new ActivateDecorator(Display2, humidityDisplay.Outline, humidityDisplay.Bar, humidityDisplay.HumidityTextfield, White, Gray, Blue);
        

        humidityDisplay.Subscribe(weatherData);
        temperatureDisplay.Subscribe(weatherData);
        StartCoroutine(handleInput());



    }
	
	
    public void setWeatherData()
    {
        weatherData.temperature = minTemp + (maxTemp - minTemp) / 2;
        weatherData.humidity = minHumid +  (maxHumid - minHumid) / 2;
        weatherData.maxHumid = maxHumid;
        weatherData.minHumid = minHumid;
        weatherData.maxTemp = maxTemp;
        weatherData.minTemp = minTemp;
       

    }

    public IEnumerator handleInput()
    {

        while (weatherData!=null)
        {
                while (Input.anyKey)
                {
                    if (Input.GetKey(KeyCode.UpArrow)&& weatherData.temperature < maxTemp)
                    {
                        weatherData.temperature += 1;
                        weatherData.weatherChanged();
                    }

                    if (Input.GetKey(KeyCode.DownArrow) && weatherData.temperature > minTemp)
                    {
                        weatherData.temperature -= 1;
                        weatherData.weatherChanged();
                    }

                    if (Input.GetKey(KeyCode.LeftArrow) && weatherData.humidity > minHumid)
                    {
                        weatherData.humidity -= 1;
                        weatherData.weatherChanged();
                    }

                    if (Input.GetKey(KeyCode.RightArrow) && weatherData.humidity < maxHumid)
                    {
                        weatherData.humidity += 1;
                        weatherData.weatherChanged();
                    }

                    yield return new WaitForSeconds(inputDelay);
                }
                
            yield return true;
            
        }

    }


}
