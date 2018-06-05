using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodFactory{

    private readonly GodData _godData;

	public GodFactory(GodData godData)
    {
        _godData = godData;
    }
	
    public string GetRandomDomain
    {

        get { return _godData.GetDomainList[Random.Range(0, _godData.GetDomainList.Count - 1)]; }

    }

    public string GetRandomName
    {
        get { return _godData.GetNameList[Random.Range(0, _godData.GetNameList.Count - 1)]; }

    }

    public God CreateGod()
    {
        return new God(GetRandomName, GetRandomDomain);
    }
}
