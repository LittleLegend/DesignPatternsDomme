using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RomanGodBuilder : GodBuilder {

    public RomanGodBuilder()
    {
        SetPantheon("roman");
    }

    public override void SetName(string setname)
    {
        name = setname;
    }

    public override void SetDomain(string setdomain)
    {
        domain = setdomain;
    }
    public override void SetPantheon(string setpantheon)
    {
        pantheon = setpantheon;
    }

    public override God Build()
    {
        return new God(name, domain, pantheon);
    }
}
