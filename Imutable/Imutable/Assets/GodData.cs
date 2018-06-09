using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodData
{

    private readonly List<string> _domainList;
    private readonly List<string> _greekNameList;
    private readonly List<string> _romanNameList;


    public GodData()
    {
        _domainList = new List<string>();
        _greekNameList = new List<string>();
        _romanNameList = new List<string>();
        CreatDomainList();
        CreatNameLists();
    }
     
    private void CreatDomainList()
    {
        _domainList.Add("of Love");
        _domainList.Add("of War");
        _domainList.Add("of the Sea");
        _domainList.Add("of Messages");
        _domainList.Add("of the Underworld");
        _domainList.Add("of Thunder");
    }
    

    private void CreatNameLists()
    {
        _greekNameList.Add("Aphrodite, Godess ");
        _greekNameList.Add("Ares, God ");
        _greekNameList.Add("Poseidon, God ");
        _greekNameList.Add("Hermes, God ");
        _greekNameList.Add("Hades, God ");
        _greekNameList.Add("Zeus, God ");

        _romanNameList.Add("Venus, Godess ");
        _romanNameList.Add("Mars, God ");
        _romanNameList.Add("Neptun, God ");
        _romanNameList.Add("Mercury, God ");
        _romanNameList.Add("Pluto, God ");
        _romanNameList.Add("Jupiter, God ");
    }

    public List<string> GetDomainList
    {
        get { return _domainList; }

    }

    public List<string> GetRomanNameList
    {
        get { return _romanNameList; }

    }

    public List<string> GetGreekNameList
    {
        get { return _greekNameList; }

    }

}
    
        





