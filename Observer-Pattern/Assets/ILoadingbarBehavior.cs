﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


interface ILoadingbarBehavior{

     void displayLoading(float value, float maxValue, float minValue, Image loadingBar);
    
}