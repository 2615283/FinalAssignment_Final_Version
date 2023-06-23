using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Use : MonoBehaviour
{
    Treasures treasureScript;
    ObjectManager script;

    private void Awake()
    {
        treasureScript = GameObject.Find("GameCanvas").GetComponent<Treasures>();
        script = GameObject.Find("GameCanvas").GetComponent<ObjectManager>();
    }

    // Sets Use Boolean to false
    public void UseFalse()
    {
        for (int i = 0; i < script.TreasureCardInstances.Count; i++)
        {
            script.TreasureCardInstances[i].Use = false;
        }
    }

    // Below are all the Use booleans. they are set to true when the use button is pressed. This is relevant in the treasures Script, as it is 
    // used to indicate the amount of cards you have of a treasure typr

    public void Use1()
    {
        script.TreasureCardInstances[0].Use = true;
    }

    public void Use2()
    {
        script.TreasureCardInstances[1].Use = true;
    }

    public void Use3()
    {
        script.TreasureCardInstances[2].Use = true;
    }

    public void Use4()
    {
        script.TreasureCardInstances[3].Use = true;
    }

    public void Use5()
    {
        script.TreasureCardInstances[4].Use = true;
    }

    public void Use6()
    {
        script.TreasureCardInstances[5].Use = true;
    }

    public void Use7()
    {
        script.TreasureCardInstances[6].Use = true;
    }

    public void Use8()
    {
        script.TreasureCardInstances[7].Use = true;
    }

    public void Use9()
    {
        script.TreasureCardInstances[8].Use = true;
    }

    public void Use10()
    {
        script.TreasureCardInstances[9].Use = true;
    }

    public void Use11()
    {
        script.TreasureCardInstances[10].Use = true;
    }

    public void Use12()
    {
        script.TreasureCardInstances[11].Use = true;
    }

    public void Use13()
    {
        script.TreasureCardInstances[12].Use = true;
    }

    public void Use14()
    {
        script.TreasureCardInstances[13].Use = true;
    }

    public void Use15()
    {
        script.TreasureCardInstances[14].Use = true;
    }

    public void Use16()
    {
        script.TreasureCardInstances[15].Use = true;
    }

    public void Use17()
    {
        script.TreasureCardInstances[16].Use = true;
    }

    public void Use18()
    {
        script.TreasureCardInstances[17].Use = true;
    }

    public void Use19()
    {
        script.TreasureCardInstances[18].Use = true;
    }

    public void Use20()
    {
        script.TreasureCardInstances[19].Use = true;
    }
}
