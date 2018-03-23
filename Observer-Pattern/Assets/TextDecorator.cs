using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

 class TextDecorator : DisplayDecorator
{
    public IDisplay Display;

    public TextDecorator(IDisplay Display, TextMeshProUGUI Label)
    {
        this.Display = Display;
    }

    public override void display()
    {
        Debug.Log(Display.getValue()+"Hi");
        

    }

    public override int getValue()
    {
        return Display.getValue();
    }
}
