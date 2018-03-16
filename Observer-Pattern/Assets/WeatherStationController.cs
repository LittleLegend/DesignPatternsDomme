using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherStationController : MonoBehaviour {

    public WeatherData weatherData = new WeatherData(50,50);
    public float inputDelay;
   

	void Start () {
        weatherData.weatherChanged();
        StartCoroutine(handleInput());
    }
	
	

    public IEnumerator handleInput()
    {
        while(true)
        {

            if (Input.GetKey(KeyCode.UpArrow))
            {
                weatherData.temperature += 1;
                weatherData.weatherChanged();
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                weatherData.temperature -= 1;
                weatherData.weatherChanged();
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                weatherData.humidity -= 1;
                weatherData.weatherChanged();
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                weatherData.humidity += 1;
                weatherData.weatherChanged();
            }

            yield return new WaitForSeconds(inputDelay);
        }

    }


}
