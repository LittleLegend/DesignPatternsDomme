using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ConcreteDisplay : MonoBehaviour,IDisplay {

    public bool active=true;

    public void display()
    {

    }

    public bool getActive()
    {
        return active;
    }

    abstract public int getMaxValue();

    abstract public int getMinValue();

    abstract public int getValue();

    abstract public void switchActive();




}
