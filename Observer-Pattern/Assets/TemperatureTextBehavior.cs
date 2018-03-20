using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TemperatureTextBehavior:ITextBehavior{


    public void activeText(TextMeshProUGUI Text)
    {
        
        Text.color = new Color32(0xAD, 0xA2, 0xAD, 0xFF);
    }

    public void deactiveText(TextMeshProUGUI Text)
    {
        Text.color = new Color32(0xD9, 0x58, 0x63, 0xFF);
    }

    public void displayText(string temperature, TextMeshProUGUI textbox )
    {
        textbox.text = temperature;
        textbox.color = new Color32(0xD9, 0x58, 0x63, 0xFF);
    }

    
}
