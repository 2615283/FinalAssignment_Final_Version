using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiverScript : MonoBehaviour
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

    public void Diver()
    {
        for (int j = 0; j < script.TilesInstances.Count; j++)
        {
            if (posScript.blackToken.transform.position == posScript.pos17 || posScript.blackToken.transform.position == posScript.pos21 || posScript.blackToken.transform.position == posScript.pos13)
            {
                if (script.TilesInstances[j].Tile.transform.position == posScript.blackToken.transform.position + new Vector3(1.4f, 0, 0))
                {
                    posScript.Indicator[0].IndicatorObject.transform.position = posScript.blackToken.transform.position + new Vector3(1.4f, 0, 0);
                }
                else
                {
                    posScript.Indicator[0].IndicatorObject.transform.position = posScript.blackToken.transform.position + new Vector3(2.8f, 0, 0);
                }
                if (script.TilesInstances[j].Tile.transform.position == posScript.blackToken.transform.position - new Vector3(0, 1.4f, 0))
                {
                    posScript.Indicator[1].IndicatorObject.transform.position = posScript.blackToken.transform.position - new Vector3(0, 1.4f, 0);
                }
                else
                {
                    posScript.Indicator[1].IndicatorObject.transform.position = posScript.blackToken.transform.position - new Vector3(0, 2.8f, 0);
                }
                posScript.Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                posScript.Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
            }
            else if (posScript.blackToken.transform.position == posScript.pos18 || posScript.blackToken.transform.position == posScript.pos22 || posScript.blackToken.transform.position == posScript.pos14)
            {
                if (script.TilesInstances[j].Tile.transform.position == posScript.blackToken.transform.position - new Vector3(1.4f, 0, 0))
                {
                    posScript.Indicator[0].IndicatorObject.transform.position = posScript.blackToken.transform.position - new Vector3(1.4f, 0, 0);
                }
                else
                {
                    posScript.Indicator[0].IndicatorObject.transform.position = posScript.blackToken.transform.position - new Vector3(2.8f, 0, 0);
                }
                if (script.TilesInstances[j].Tile.transform.position == posScript.blackToken.transform.position - new Vector3(0, 1.4f, 0))
                {
                    posScript.Indicator[1].IndicatorObject.transform.position = posScript.blackToken.transform.position - new Vector3(0, 1.4f, 0);
                }
                else
                {
                    posScript.Indicator[1].IndicatorObject.transform.position = posScript.blackToken.transform.position - new Vector3(0, 2.8f, 0);
                }
                posScript.Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                posScript.Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
            }
            else if (posScript.blackToken.transform.position == posScript.pos15 || posScript.blackToken.transform.position == posScript.pos23 || posScript.blackToken.transform.position == posScript.pos19)
            {
                if (script.TilesInstances[j].Tile.transform.position == posScript.blackToken.transform.position + new Vector3(1.4f, 0, 0))
                {
                    posScript.Indicator[0].IndicatorObject.transform.position = posScript.blackToken.transform.position + new Vector3(1.4f, 0, 0);
                }
                else
                {
                    posScript.Indicator[0].IndicatorObject.transform.position = posScript.blackToken.transform.position + new Vector3(2.8f, 0, 0);
                }
                if (script.TilesInstances[j].Tile.transform.position == posScript.blackToken.transform.position + new Vector3(0, 1.4f, 0))
                {
                    posScript.Indicator[1].IndicatorObject.transform.position = posScript.blackToken.transform.position + new Vector3(0, 1.4f, 0);
                }
                else
                {
                    posScript.Indicator[1].IndicatorObject.transform.position = posScript.blackToken.transform.position + new Vector3(0, 2.8f, 0);
                }
                posScript.Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                posScript.Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
            }
            else if (posScript.blackToken.transform.position == posScript.pos16 || posScript.blackToken.transform.position == posScript.pos24 || posScript.blackToken.transform.position == posScript.pos20)
            {
                if (script.TilesInstances[j].Tile.transform.position == posScript.blackToken.transform.position - new Vector3(1.4f, 0, 0))
                {
                    posScript.Indicator[0].IndicatorObject.transform.position = posScript.blackToken.transform.position - new Vector3(1.4f, 0, 0);
                }
                else
                {
                    posScript.Indicator[0].IndicatorObject.transform.position = posScript.blackToken.transform.position - new Vector3(2.8f, 0, 0);
                }
                if (script.TilesInstances[j].Tile.transform.position == posScript.blackToken.transform.position + new Vector3(0, 1.4f, 0))
                {
                    posScript.Indicator[1].IndicatorObject.transform.position = posScript.blackToken.transform.position + new Vector3(0, 1.4f, 0);
                }
                else
                {
                    posScript.Indicator[1].IndicatorObject.transform.position = posScript.blackToken.transform.position + new Vector3(0, 2.8f, 0);
                }
                posScript.Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                posScript.Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
            }
            else
            {
                if (script.TilesInstances[j].Tile.transform.position == posScript.blackToken.transform.position + new Vector3(1.4f, 0, 0))
                {
                    posScript.Indicator[0].IndicatorObject.transform.position = posScript.blackToken.transform.position + new Vector3(1.4f, 0, 0);
                }
                else
                {
                    posScript.Indicator[0].IndicatorObject.transform.position = posScript.blackToken.transform.position + new Vector3(2.8f, 0, 0);
                }
                if (script.TilesInstances[j].Tile.transform.position == posScript.blackToken.transform.position - new Vector3(1.4f, 0, 0))
                {
                    posScript.Indicator[1].IndicatorObject.transform.position = posScript.blackToken.transform.position - new Vector3(1.4f, 0, 0);
                }
                else
                {
                    posScript.Indicator[1].IndicatorObject.transform.position = posScript.blackToken.transform.position - new Vector3(2.8f, 0, 0);
                }
                if (script.TilesInstances[j].Tile.transform.position == posScript.blackToken.transform.position + new Vector3(0, 1.4f, 0))
                {
                    posScript.Indicator[2].IndicatorObject.transform.position = posScript.blackToken.transform.position + new Vector3(0, 1.4f, 0);
                }
                else
                {
                    posScript.Indicator[2].IndicatorObject.transform.position = posScript.blackToken.transform.position + new Vector3(0, 2.8f, 0);
                }
                if (script.TilesInstances[j].Tile.transform.position == posScript.blackToken.transform.position - new Vector3(0, 1.4f, 0))
                {
                    posScript.Indicator[3].IndicatorObject.transform.position = posScript.blackToken.transform.position - new Vector3(0, 1.4f, 0);
                }
                else
                {
                    posScript.Indicator[3].IndicatorObject.transform.position = posScript.blackToken.transform.position - new Vector3(0, 2.8f, 0);
                }
            }
        }
    }
}
