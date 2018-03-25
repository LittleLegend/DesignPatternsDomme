using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

class TextDecorator : DisplayDecorator
{
    
    public TextMeshProUGUI Label;
    public Color32 Color;
    public string Symbol;

    public TextDecorator(IDisplay Display, TextMeshProUGUI Label, Color32 Color, string Symbol)
    {
        this.Display = Display;
        this.Label = Label;
        this.Color = Color;
        this.Symbol = Symbol;
    }

    public override void display()
    {
        Display.display();
        Label.text = Display.getValue() + Symbol;
        Label.color = Color;

    }

    
}
