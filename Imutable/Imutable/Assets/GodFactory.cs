using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodFactory{

    private readonly GodData _godData;
    public string pantheon;
    private GodBuilder GodBuilder;

	public GodFactory(GodData godData)
    {
        _godData = godData;
        SetRandomPantheon();
    }
	
    public void SetRandomPantheon()
    {
        switch(Random.Range(0,2))
        {

            case 0:
                pantheon = "greek";
                GodBuilder = new GreekGodBuilder();
                break;

            case 1:
                pantheon = "roman";
                GodBuilder = new RomanGodBuilder();
                break;
                
        }
    }

    public string GetRandomDomain()
    {

         return _godData.GetDomainList[Random.Range(0, _godData.GetDomainList.Count - 1)]; 

    }

    public string GetRandomName()
    {
        switch (pantheon)
        {
            case "greek":
            return _godData.GetGreekNameList[Random.Range(0, _godData.GetGreekNameList.Count - 1)];
                break;

            case "roman":
                return _godData.GetRomanNameList[Random.Range(0, _godData.GetRomanNameList.Count - 1)];
                break;

            default:
                return "";
                break;
        }
        

    }

    public God CreateGod()
    {
        GodBuilder.SetDomain(GetRandomDomain());
        GodBuilder.SetName(GetRandomName());

        return GodBuilder.Build();
    }
}
