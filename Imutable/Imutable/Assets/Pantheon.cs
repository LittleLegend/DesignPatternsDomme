using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pantheon : MonoBehaviour {

    public GodFactory GodFactory;
    public GodData GodData;
    public List<God> GodList;
    public GameState CurrentGameState;
    public God NewGod;
    

	void Start () {

        GodData = new GodData();
        GodFactory = new GodFactory(GodData);
        GodList = new List<God>();
        CurrentGameState = GameState.Create;

    }

    public enum GameState { Create, Compare};

	void Update () {
        Create();
        Compare();
    }

    public void Create()
    {
        if (CurrentGameState == GameState.Create)
        {
            if (Input.GetMouseButtonUp(0))
            {
                NewGod = GodFactory.CreateGod();
                CurrentGameState = GameState.Compare;
            }
        }

    }

    public void Compare()
    {
        if (CurrentGameState == GameState.Compare)
        {
            God killedGod=null;
            for (int i=0;i<GodList.Count;i++)
            {
                if(GodList[i].GetName == NewGod.GetName)
                {
                    killedGod = GodList[i];
                }
            }

            if(killedGod == null)
            {
                Join();
            }else
            {
                Kill(killedGod, NewGod);
            }

            CurrentGameState = GameState.Create;
        }
    }
    public void Kill(God killedGod, God murderGod)
    {
        if (CurrentGameState == GameState.Compare)
        {
            Debug.Log(killedGod.GetName + killedGod.GetDomain + " was killed by " + murderGod.GetName + murderGod.GetDomain);
            GodList.Remove(killedGod);
            GodList.Add(murderGod);
            
        }
    }

    public void Join()
    {
        if (CurrentGameState == GameState.Compare)
        {
            Debug.Log(NewGod.GetName + NewGod.GetDomain + " joined the Pantheon !");
            GodList.Add(NewGod);
            
        }
    }
}
