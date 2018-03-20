using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingbarHumidityBehavior : ILoadingbarBehavior
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

    public void displayLoading(float humidity,float maxHumid, float minHumid,Image loadingbarHumidity)
    {
        loadingbarHumidity.fillAmount = (humidity-minHumid)/ (maxHumid- minHumid);
    }
}
