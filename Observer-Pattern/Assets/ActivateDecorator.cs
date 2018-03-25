using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ActivateDecorator : DisplayDecorator {

   public Image Outline;
    public Image Bar;
    public TextMeshProUGUI Label;
    public Color32 TextColor;
    public Color32 InactiveColor;
    public Color32 ActiveColor;

    public ActivateDecorator(IDisplay Display, Image Outline, Image Bar, TextMeshProUGUI Label, Color32 ActiveColor, Color32 InactiveColor, Color32 TextColor)
    {
        this.Display = Display;
        this.Outline = Outline;
        this.Bar = Bar;
        this.Label = Label;
        this.ActiveColor = ActiveColor;
        this.InactiveColor = InactiveColor;
        this.TextColor = TextColor;
    }


    public override void display()
    {
        Display.display();

        if(getActive()==true)
        {
            

            Label.color = TextColor;
            Outline.color = ActiveColor;
            Bar.color = ActiveColor;

        }
        else
        {
            Label.color = InactiveColor;
            Outline.color = InactiveColor;
            Bar.color = InactiveColor;
        }


        
    }

}
