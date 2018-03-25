using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingbarDecorator : DisplayDecorator {

   
    public Image Outline;
    public Image Bar;

    public LoadingbarDecorator(IDisplay Display,Image Outline, Image Bar )
    {
        this.Display = Display;
        this.Bar = Bar;
        this.Outline = Outline;

    }
    
    public override void display()
    {
        Display.display();
        float fillAmount = ((float)Display.getValue() - Display.getMinValue()) / ((float)Display.getMaxValue() - Display.getMinValue());
        Bar.fillAmount = fillAmount;

    }

   
}
