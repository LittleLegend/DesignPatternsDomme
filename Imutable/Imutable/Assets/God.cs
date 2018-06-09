using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class God{

    private readonly string _pantheon;
    private readonly string _name;
    private readonly string _domain;

    public God(string name, string domain, string pantheon)
    {
        _pantheon = pantheon;
        _name = name;
        _domain = domain;
    }

    public string GetPantheon
    {
        get { return _pantheon; }
    }

    public string GetName
    {
        get { return _name; }
    }

    public string GetDomain
    {
        get { return _domain; }
    }
}
