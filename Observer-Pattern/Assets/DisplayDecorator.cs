using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  abstract class  DisplayDecorator : IDisplay {

    public IDisplay Display;

    abstract public void display();

    public bool getActive()
    {
       return  Display.getActive();
    }
    
    public int getMaxValue()
    {
        return Display.getMaxValue();
    }

    public int getMinValue()
    {
        return Display.getMinValue();
    }

    public int getValue()
    {
        return Display.getValue();
    }
}
