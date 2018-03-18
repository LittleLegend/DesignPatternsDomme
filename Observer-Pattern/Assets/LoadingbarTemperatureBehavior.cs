using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingbarTemperatureBehavior : ILoadingbarBehavior
{
    public void displayLoading(float temperature, float maxTemp , float minTemp,Image loadingbarTemperature)
    {
        loadingbarTemperature.fillAmount = (temperature-minTemp)/(maxTemp-minTemp);
        
    }
}
