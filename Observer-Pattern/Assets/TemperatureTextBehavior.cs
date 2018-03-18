using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TemperatureTextBehavior:ITextBehavior{

    public void displayText(string temperature, TextMeshProUGUI textbox )
    {
        textbox.text = temperature;
        textbox.color = new Color32(0xD9, 0x58, 0x63, 0xFF);
    }

    
}
