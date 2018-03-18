using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingbarHumidityBehavior : ILoadingbarBehavior
{
    public void displayLoading(float humidity,float maxHumid, float minHumid,Image loadingbarHumidity)
    {
        loadingbarHumidity.fillAmount = (humidity-minHumid)/ (maxHumid- minHumid);
    }
}
