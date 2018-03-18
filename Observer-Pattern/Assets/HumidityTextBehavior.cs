﻿using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HumidityTextBehavior : ITextBehavior
{



    public void displayText(string humidity, TextMeshProUGUI textbox)
    {
        textbox.text = humidity;
        textbox.color = new Color32(0x5A, 0x6E, 0xE1, 0xFF);

        
    }
}