using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingbarTemperatureBehavior : ILoadingbarBehavior
{
    public void activeLoading(Image LoadingBar, Image Outline)
    {
        LoadingBar.color = new Color32(0xAD, 0xA2, 0xAD, 0xFF);
        Outline.color = new Color32(0xAD, 0xA2, 0xAD, 0xFF);
    }

    public void deactiveLoading(Image LoadingBar, Image Outline)
    {
        LoadingBar.color = new Color32(0xFF, 0xFF, 0xFF, 0xFF);
        Outline.color = new Color32(0xFF, 0xFF, 0xFF, 0xFF);
    }

    public void displayLoading(float temperature, float maxTemp , float minTemp,Image loadingbarTemperature)
    {
        loadingbarTemperature.fillAmount = (temperature-minTemp)/(maxTemp-minTemp);
        
    }
}
