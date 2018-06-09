using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GodBuilder{


    public string domain;
    public string name;
    public string pantheon;

    public abstract void SetDomain(string setdomain);
    public abstract void SetName(string setname);
    public abstract void SetPantheon(string setpantheon);
    public abstract God Build();
}
