using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodData
{

    private readonly List<string> _domainList;
    private readonly List<string> _nameList;
    

    public GodData()
    {
        _domainList = new List<string>();
        _nameList = new List<string>();
        CreatDomainList();
        CreatNameList();
    }
     
    private void CreatDomainList()
    {
        _domainList.Add("of Love");
        _domainList.Add("of War");
        _domainList.Add("of the Sea");
        _domainList.Add("of Magic");
        _domainList.Add("of Medicine");
        _domainList.Add("of the Underworld");
        _domainList.Add("of Thunder");
    }
    

    private void CreatNameList()
    {
        _nameList.Add("Venus, Godess ");
        _nameList.Add("Mars, God ");
        _nameList.Add("Neptun, God ");
        _nameList.Add("Hekate, Godess ");
        _nameList.Add("Hermes, God ");
        _nameList.Add("Hades, God ");
        _nameList.Add("Jupiter, God ");
    }

    public List<string> GetDomainList
    {
        get { return _domainList; }

    }

    public List<string> GetNameList
    {
        get { return _nameList; }

    }

}
    
        





