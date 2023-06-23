using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SandBags : MonoBehaviour
{
    ObjectManager script;
    PlayerTurns turnScript;
    Positions posScript;
    ShoreUp shoreScript;

    private void Awake()
    {
        script = GameObject.Find("GameCanvas").GetComponent<ObjectManager>();
        turnScript = GameObject.Find("GameCanvas").GetComponent<PlayerTurns>();
        posScript = GameObject.Find("GameCanvas").GetComponent<Positions>();
        shoreScript = GameObject.Find("GameCanvas").GetComponent<ShoreUp>();
    }

    // Start function adds the 'Use' buttons to the Sandbag cards and the Helicopter Lift cards
    private void Start()
    {
        for (int i = 0; i < script.TreasureCardInstances.Count; i++)
        {
            // It's supposed to say Sandbag... but Sadbag is funny, so I am not changing it. 
            if (script.TreasureCardInstances[i].Sadbag == true || script.TreasureCardInstances[i].HelicopterLift == true)
            {
                script.TreasureCardInstances[i].UseButt.SetActive(true);
            }
            else
            {
                script.TreasureCardInstances[i].UseButt.SetActive(false);
            }
        }
    }

    // When Sandbag is used
    public void SandBag()
    {
        // Takes 1 off the Action counter to account for the fact that it does not take an action to shore up a Tile with this card
        if (turnScript.Player1Turn == true)
        {
            turnScript.Player1 -= 1;
        }
        else if (turnScript.Player2Turn == true)
        {
            turnScript.Player2 -= 1;
        }

        // Places Shore Up Indicators on all the flooded Tiles that are on the board
        for (int j = 0; j < script.TilesInstances.Count; j++)
        {
            for (int i = 0; i < script.TilesInstances.Count; i++)
            {
                if (script.TilesInstances[i].Flooded == true && script.TilesInstances[i].Tile.transform.position == posScript.pos[0])
                {
                    shoreScript.IndicatorSU[0].Indicator.transform.position = posScript.pos[0];
                    script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                }
                if (script.TilesInstances[i].Flooded == true && script.TilesInstances[i].Tile.transform.position == posScript.pos[1])
                {
                    shoreScript.IndicatorSU[1].Indicator.transform.position = posScript.pos[1];
                    script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                }
                if (script.TilesInstances[i].Flooded == true && script.TilesInstances[i].Tile.transform.position == posScript.pos[2])
                {
                    shoreScript.IndicatorSU[2].Indicator.transform.position = posScript.pos[2];
                    script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                }
                if (script.TilesInstances[i].Flooded == true && script.TilesInstances[i].Tile.transform.position == posScript.pos[3])
                {
                    shoreScript.IndicatorSU[3].Indicator.transform.position = posScript.pos[3];
                    script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                }
                if (script.TilesInstances[i].Flooded == true && script.TilesInstances[i].Tile.transform.position == posScript.pos[4])
                {
                    shoreScript.IndicatorSU[4].Indicator.transform.position = posScript.pos[4];
                    script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                }
                if (script.TilesInstances[i].Flooded == true && script.TilesInstances[i].Tile.transform.position == posScript.pos[5])
                {
                    shoreScript.IndicatorSU[5].Indicator.transform.position = posScript.pos[5];
                    script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                }
                if (script.TilesInstances[i].Flooded == true && script.TilesInstances[i].Tile.transform.position == posScript.pos[6])
                {
                    shoreScript.IndicatorSU[6].Indicator.transform.position = posScript.pos[6];
                    script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                }
                if (script.TilesInstances[i].Flooded == true && script.TilesInstances[i].Tile.transform.position == posScript.pos[7])
                {
                    shoreScript.IndicatorSU[7].Indicator.transform.position = posScript.pos[7];
                    script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                }
                if (script.TilesInstances[i].Flooded == true && script.TilesInstances[i].Tile.transform.position == posScript.pos[8])
                {
                    shoreScript.IndicatorSU[8].Indicator.transform.position = posScript.pos[8];
                    script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                }
                if (script.TilesInstances[i].Flooded == true && script.TilesInstances[i].Tile.transform.position == posScript.pos[9])
                {
                    shoreScript.IndicatorSU[9].Indicator.transform.position = posScript.pos[9];
                    script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                }
                if (script.TilesInstances[i].Flooded == true && script.TilesInstances[i].Tile.transform.position == posScript.pos[10])
                {
                    shoreScript.IndicatorSU[10].Indicator.transform.position = posScript.pos[10];
                    script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                }
                if (script.TilesInstances[i].Flooded == true && script.TilesInstances[i].Tile.transform.position == posScript.pos[11])
                {
                    shoreScript.IndicatorSU[11].Indicator.transform.position = posScript.pos[11];
                    script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                }
                if (script.TilesInstances[i].Flooded == true && script.TilesInstances[i].Tile.transform.position == posScript.pos[12])
                {
                    shoreScript.IndicatorSU[12].Indicator.transform.position = posScript.pos[12];
                    script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                }
                if (script.TilesInstances[i].Flooded == true && script.TilesInstances[i].Tile.transform.position == posScript.pos[13])
                {
                    shoreScript.IndicatorSU[13].Indicator.transform.position = posScript.pos[13];
                    script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                }
                if (script.TilesInstances[i].Flooded == true && script.TilesInstances[i].Tile.transform.position == posScript.pos[14])
                {
                    shoreScript.IndicatorSU[14].Indicator.transform.position = posScript.pos[14];
                    script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                }
                if (script.TilesInstances[i].Flooded == true && script.TilesInstances[i].Tile.transform.position == posScript.pos[15])
                {
                    shoreScript.IndicatorSU[15].Indicator.transform.position = posScript.pos[15];
                    script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                }
                if (script.TilesInstances[i].Flooded == true && script.TilesInstances[i].Tile.transform.position == posScript.pos[16])
                {
                    shoreScript.IndicatorSU[16].Indicator.transform.position = posScript.pos[16];
                    script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                }
                if (script.TilesInstances[i].Flooded == true && script.TilesInstances[i].Tile.transform.position == posScript.pos[17])
                {
                    shoreScript.IndicatorSU[17].Indicator.transform.position = posScript.pos[17];
                    script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                }
                if (script.TilesInstances[i].Flooded == true && script.TilesInstances[i].Tile.transform.position == posScript.pos[18])
                {
                    shoreScript.IndicatorSU[18].Indicator.transform.position = posScript.pos[18];
                    script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                }
                if (script.TilesInstances[i].Flooded == true && script.TilesInstances[i].Tile.transform.position == posScript.pos[19])
                {
                    shoreScript.IndicatorSU[19].Indicator.transform.position = posScript.pos[19];
                    script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                }
                if (script.TilesInstances[i].Flooded == true && script.TilesInstances[i].Tile.transform.position == posScript.pos[20])
                {
                    shoreScript.IndicatorSU[20].Indicator.transform.position = posScript.pos[20];
                    script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                }
                if (script.TilesInstances[i].Flooded == true && script.TilesInstances[i].Tile.transform.position == posScript.pos[21])
                {
                    shoreScript.IndicatorSU[21].Indicator.transform.position = posScript.pos[21];
                    script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                }
                if (script.TilesInstances[i].Flooded == true && script.TilesInstances[i].Tile.transform.position == posScript.pos[22])
                {
                    shoreScript.IndicatorSU[22].Indicator.transform.position = posScript.pos[22];
                    script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                }
                if (script.TilesInstances[i].Flooded == true && script.TilesInstances[i].Tile.transform.position == posScript.pos[23])
                {
                    shoreScript.IndicatorSU[23].Indicator.transform.position = posScript.pos[23];
                    script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                }
            }
        }        
    }
}
